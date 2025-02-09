using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Contracts.Services;
using Monhealth.Application.ServiceForRecommend;
using Monhealth.Core.Enum;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Metric.Commands.CreateMetric
{
    public class CreateMetricCommandHandler : IRequestHandler<CreateMetricCommand, Unit>
    {
        private readonly IMetricsCalculator _metricCalculator;
        private readonly IGoalsCalculator _goalCalculator;
        private readonly IMetricRepository _metricRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        private readonly IWaterReminderRepository _reminderRepository;
        private readonly FoodRandomService _foodRandomService;
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IFoodPortionRepository _foodPortionRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IFoodRepository _foodRepository;

        public CreateMetricCommandHandler(
            IMetricRepository metricRepository,
            IMapper mapper,
            IMetricsCalculator metricCalculator,
            IGoalRepository goalRepository,
            IGoalsCalculator goalsCalculator,
            IWaterReminderRepository reminderRepository,
            FoodRandomService foodRandomService,
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IPortionRepository portionRepository,
            IFoodPortionRepository foodPortionRepository,
            IDailyMealRepository dailyMealRepository,
            IFoodRepository foodRepository)
        {
            _metricCalculator = metricCalculator;
            _metricRepository = metricRepository;
            _mapper = mapper;
            _goalRepository = goalRepository;
            _goalCalculator = goalsCalculator;
            _reminderRepository = reminderRepository;
            _foodRandomService = foodRandomService;
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
            _foodPortionRepository = foodPortionRepository;
            _dailyMealRepository = dailyMealRepository;
            _foodRepository = foodRepository;
        }

        public async Task<Unit> Handle(CreateMetricCommand request, CancellationToken cancellationToken)
        {
            // Tính toán Metric
            #region Metric Calculation
            var newMetric = _mapper.Map<Monhealth.Domain.Metric>(request.CreateMetricDTO);
            var age = DateTime.Now.Year - request.CreateMetricDTO.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < request.CreateMetricDTO.DateOfBirth.DayOfYear)
            {
                age--;
            }
            newMetric.Bmi = (float)_metricCalculator.CalculateBMI(request.CreateMetricDTO.Weight, request.CreateMetricDTO.Height);
            newMetric.Bmr = _metricCalculator.CalculateBMR(request.CreateMetricDTO.Weight, request.CreateMetricDTO.Height, age, request.CreateMetricDTO.Gender.ToString());
            newMetric.Tdee = _metricCalculator.CalculateTDEE(newMetric.Bmr, request.CreateMetricDTO.ActivityLevel);
            newMetric.Ibw = _metricCalculator.CalculateIBW(request.CreateMetricDTO.Height, request.CreateMetricDTO.Gender.ToString());

            newMetric.MetricId = Guid.NewGuid();
            newMetric.CreatedAt = DateTime.Now;
            newMetric.UpdatedAt = DateTime.Now;
            _metricRepository.Add(newMetric);
            #endregion

            // Tính toán Goal
            #region Goal Calculation
            var newGoal = _mapper.Map<Goal>(request.CreateMetricDTO);
            _goalCalculator.CreateCalculateGoal(newGoal, request.CreateMetricDTO, newMetric.Tdee);
            newGoal.GoalId = Guid.NewGuid();
            newGoal.Status = GoalStatus.Active;
            newGoal.CreatedAt = DateTime.Now;
            newGoal.UpdatedAt = DateTime.Now;
            _goalRepository.Add(newGoal);
            #endregion

            // Tạo Reminder
            #region Reminder Creation
            Guid? userId = request.CreateMetricDTO.UserId;
            var reminders = await _reminderRepository.CreateReminders(newGoal.WaterIntakesGoal, userId);
            foreach (var reminder in reminders)
            {
                _reminderRepository.Add(reminder);
            }
            #endregion

            // **Tạo Meal cho 3 ngày**
            #region Generate Meals for 3 Days
            for (int i = 0; i < 3; i++)
            {
                var currentDate = DateTime.Now.Date.AddDays(i);

                var goalType = await _goalRepository.GetGoalTypeByUserIdAsync(userId.Value) ?? GoalType.Maintenance;
                var activityLevel = await _goalRepository.GetActivityLevelByUserIdAsync(userId.Value);

                var mealPlan = await _foodRandomService.GetMealPlanWithAllocationAsync(userId.Value, goalType, activityLevel);

                await CreateMealAsync(MealType.Breakfast, mealPlan.Breakfast, newGoal, userId.Value, currentDate);
                await CreateMealAsync(MealType.Lunch, mealPlan.Lunch, newGoal, userId.Value, currentDate);
                await CreateMealAsync(MealType.Dinner, mealPlan.Dinner, newGoal, userId.Value, currentDate);
                await CreateMealAsync(MealType.Snack, mealPlan.Snack, newGoal, userId.Value, currentDate);

            }

            #endregion
            await _reminderRepository.SaveChangeAsync();

            return Unit.Value;
        }


        private async Task CreateMealAsync(MealType mealType, MealDTO meal, Goal goal, Guid userId, DateTime date)
        {
            if (meal?.MainDish?.Food == null)
            {
                return;
            }

            var existingMeal = await _mealRepository.GetByUserIdAndMealType(userId, mealType, date.Day);
            var model = existingMeal ?? new Monhealth.Domain.Meal
            {
                UserId = userId,
                MealType = mealType.ToString(),
                CreatedAt = date,
                UpdatedAt = DateTime.Now
            };

            if (existingMeal == null)
            {
                _mealRepository.Add(model);
                await _mealRepository.SaveChangeAsync();
            }
            else
            {
                model.UpdatedAt = DateTime.Now;
            }

            // 🔹 Truyền Goal thay vì Metric
            await AddDishToMealAsync(meal.MainDish, model.MealId, goal, mealType);
            if (meal.SideDish?.Food != null) await AddDishToMealAsync(meal.SideDish, model.MealId, goal, mealType);
            if (meal.Dessert?.Food != null) await AddDishToMealAsync(meal.Dessert, model.MealId, goal, mealType);

            await AddMealToDailyMeal(userId, date);
        }





        // private (float mainDish, float sideDish, float dessert) GetMealRatios(MealType mealType, GoalType goalType, float activityLevel)
        // {
        //     return mealType switch
        //     {
        //         MealType.Breakfast => (1f, 0f, 0f),
        //         MealType.Lunch => (0.55f, 0.3f, 0.15f),
        //         MealType.Dinner => (goalType == GoalType.WeightLoss || activityLevel < 1.725) ? (0.65f, 0.35f, 0f) : (0.6f, 0.3f, 0.1f),
        //         MealType.Snack => (0.8f, 0.2f, 0f),
        //         _ => throw new Exception($"MealType không hợp lệ: {mealType}")
        //     };
        // }


        private async Task AddDishToMealAsync(DishDTO dish, Guid mealId, Goal goal, MealType mealType)
        {
            if (dish == null) return;

            var food = await _foodRepository.GetByIdAsync(dish.Food.FoodId);
            if (food == null || food.Nutrition == null)
            {
                throw new Exception($"Không tìm thấy Food hoặc Nutrition với FoodId: {dish.Food.FoodId}");
            }

            // 🔹 Xác định lượng calories mục tiêu dựa trên Goal
            var mealRatio = mealType switch
            {
                MealType.Breakfast => 0.3f,
                MealType.Lunch => 0.35f,
                MealType.Dinner => 0.25f,
                MealType.Snack => 0.1f,
                _ => throw new Exception($"MealType không hợp lệ: {mealType}")
            };
            float mealCaloriesTarget = goal.CaloriesGoal * mealRatio;

            // 🔹 Tính portionWeight dựa trên Goal
            // ✅ Tính portionWeight dựa trên CaloriesGoal mà không bị giới hạn cứng
            float portionWeight = (mealCaloriesTarget / food.Nutrition.Calories) * 100;

            // 🔹 Nếu portionWeight quá thấp, tăng tỷ lệ calories của bữa ăn (Snack có thể cần điều chỉnh)
            if (portionWeight < 30 && mealType != MealType.Snack)
            {
                portionWeight = (mealCaloriesTarget * 1.2f / food.Nutrition.Calories) * 100; // Tăng 20% nếu quá thấp
            }

            // 🔹 Nếu portionWeight quá cao, giảm tỷ lệ (Dinner có thể cần giảm lại)
            if (portionWeight > 150 && mealType == MealType.Dinner)
            {
                portionWeight = (mealCaloriesTarget * 0.8f / food.Nutrition.Calories) * 100; // Giảm 20% nếu quá cao
            }

            // Làm tròn số để tránh sai số tính toán
            portionWeight = MathF.Round(portionWeight, 2);

            // 🔥 Debug log để kiểm tra kết quả
            Console.WriteLine($"MealType: {mealType}, Calories Target: {mealCaloriesTarget}, Portion Weight: {portionWeight}, Food Calories: {food.Nutrition.Calories}");

            // 🔹 Debug thông tin
            Console.WriteLine($"MealType: {mealType}, Calories Target: {mealCaloriesTarget}, Portion Weight: {portionWeight}, Food Calories: {food.Nutrition.Calories}");

            // 🔹 Tạo portion mới hoặc lấy portion cũ
            var existingPortion = await _portionRepository.GetPortionAsync(
                dish.Portion?.MeasurementUnit ?? "g",
                dish.Portion?.PortionSize ?? "",
                portionWeight
            );

            Portion portion = existingPortion ?? new Portion
            {
                MeasurementUnit = dish.Portion?.MeasurementUnit ?? "g",
                PortionSize = dish.Portion?.PortionSize ?? "",
                PortionWeight = portionWeight,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            if (existingPortion == null)
            {
                _portionRepository.Add(portion);
                await _portionRepository.SaveChangesAsync();
            }

            // 🔹 Cập nhật vào FoodPortion và MealFood
            _foodPortionRepository.Add(new FoodPortion
            {
                FoodId = dish.Food.FoodId,
                PortionId = portion.PortionId
            });

            _mealFoodRepository.Add(new Monhealth.Domain.MealFood
            {
                MealId = mealId,
                FoodId = dish.Food.FoodId,
                PortionId = portion.PortionId,
                Quantity = 1, // 🔥 Không nhân đôi
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            await _mealRepository.SaveChangeAsync();
        }






        private async Task AddMealToDailyMeal(Guid userId, DateTime date)
        {
            var mealsForDay = await _mealRepository.GetMealByUserAndDate(date, userId);
            var dailyMeal = await _dailyMealRepository.GetDailyMealByUserAndDate(date, userId);
            var goal = await _goalRepository.GetByUserIdAsync(userId);

            if (goal == null)
            {
                throw new Exception($"Không tìm thấy Goal nào liên kết với UserId: {userId}");
            }

            if (dailyMeal == null)
            {
                dailyMeal = new Monhealth.Domain.DailyMeal
                {
                    GoalId = goal.GoalId,
                    UserId = userId,
                    CreatedAt = date,
                    UpdatedAt = DateTime.Now,
                    TotalCalories = 0,
                    TotalProteins = 0,
                    TotalCarbs = 0,
                    TotalFats = 0,
                    TotalFibers = 0,
                    TotalSugars = 0
                };

                _dailyMealRepository.Add(dailyMeal);
                await _dailyMealRepository.SaveChangeAsync();
            }

            foreach (var meal in mealsForDay)
            {
                meal.DailyMealId = dailyMeal.DailyMealId;
                _mealRepository.Update(meal);

                var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);

                foreach (var mealFood in mealFoods)
                {
                    var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);
                    if (portion == null)
                    {
                        throw new Exception($"Không tìm thấy Portion với PortionId: {mealFood.PortionId}");
                    }

                    if (mealFood.Status)
                    {
                        var food = await _foodRepository.GetByIdAsync(mealFood.FoodId);
                        if (food == null || food.Nutrition == null)
                        {
                            throw new Exception($"Không tìm thấy Food hoặc Nutrition với FoodId: {mealFood.FoodId}");
                        }

                        var portionWeight = portion.PortionWeight;

                        dailyMeal.TotalCalories += (food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalProteins += (food.Nutrition.Protein / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalCarbs += (food.Nutrition.Carbs / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalFats += (food.Nutrition.Fat / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalFibers += (food.Nutrition.Fiber / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalSugars += (food.Nutrition.Sugar / 100) * (mealFood.Quantity * portionWeight);
                    }
                }
            }

            dailyMeal.UpdatedAt = DateTime.Now;
            await _dailyMealRepository.SaveChangeAsync();
        }

    }
}
