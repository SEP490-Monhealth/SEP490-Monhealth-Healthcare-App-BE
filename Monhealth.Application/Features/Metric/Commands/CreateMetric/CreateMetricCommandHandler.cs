﻿using AutoMapper;
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
            if (meal?.MainDish?.Food == null) return;

            // 🔹 Kiểm tra Meal đã tồn tại chưa
            var existingMeal = await _mealRepository.GetByUserIdAndMealType(userId, mealType, date.Day);
            Monhealth.Domain.Meal model;

            if (existingMeal != null)
            {
                model = existingMeal;
                model.UpdatedAt = DateTime.Now;
            }
            else
            {
                model = new Monhealth.Domain.Meal
                {
                    UserId = userId,
                    MealType = mealType.ToString(),
                    CreatedAt = date,
                    UpdatedAt = DateTime.Now
                };
                _mealRepository.Add(model);
                await _mealRepository.SaveChangeAsync();
            }

            // 🔹 Thêm món ăn vào Meal
            await AddDishToMealAsync(meal.MainDish, model.MealId, goal, mealType);
            if (meal.SideDish?.Food != null) await AddDishToMealAsync(meal.SideDish, model.MealId, goal, mealType);
            if (meal.Dessert?.Food != null) await AddDishToMealAsync(meal.Dessert, model.MealId, goal, mealType);

            // 🔹 Liên kết Meal với DailyMeal
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
            if (food == null || food.Nutrition == null) return;

            var mealRatio = mealType switch
            {
                MealType.Breakfast => 0.3f,
                MealType.Lunch => 0.35f,
                MealType.Dinner => 0.25f,
                MealType.Snack => 0.1f,
                _ => throw new Exception($"MealType không hợp lệ: {mealType}")
            };

            float mealCaloriesTarget = goal.CaloriesGoal * mealRatio;

            float portionWeight = mealCaloriesTarget / food.Nutrition.Calories * 100;
            portionWeight = Math.Clamp(portionWeight, 30, 500);

            var portion = new Portion
            {
                MeasurementUnit = "g",
                PortionSize = "",
                PortionWeight = portionWeight,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _portionRepository.Add(portion);
            await _portionRepository.SaveChangesAsync();

            _mealFoodRepository.Add(new Monhealth.Domain.MealFood
            {
                MealId = mealId,
                FoodId = dish.Food.FoodId,
                PortionId = portion.PortionId,
                Quantity = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            await _mealRepository.SaveChangeAsync();
        }

        private async Task AddMealToDailyMeal(Guid userId, DateTime date)
        {
            var mealsForDay = await _mealRepository.GetMealByUserAndDate(date.Date, userId);
            if (mealsForDay == null || !mealsForDay.Any())
            {
                Console.WriteLine($"⚠️ Không có Meal nào cho User {userId} vào ngày {date}");
                return;
            }
            Console.WriteLine($"✅ Tìm thấy {mealsForDay.Count()} Meal(s) cho User {userId} vào ngày {date}");

            var goal = await _goalRepository.GetByUserIdAsync(userId);
            if (goal == null)
            {
                throw new Exception($"❌ Không tìm thấy Goal nào liên kết với UserId: {userId}");
            }

            // 🔹 Kiểm tra nếu `DailyMeal` đã tồn tại
            var dailyMeal = await _dailyMealRepository.GetDailyMealByUserAndDate(date.Date, userId);
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
                await _dailyMealRepository.SaveChangeAsync(); // 🔹 Lưu vào DB để có `DailyMealId`
                Console.WriteLine($"✅ Tạo mới DailyMeal với ID: {dailyMeal.DailyMealId}");
            }
            else
            {
                Console.WriteLine($"🔍 DailyMeal đã tồn tại với ID: {dailyMeal.DailyMealId}");
            }

            // 🔹 Reset lại giá trị dinh dưỡng trước khi tính toán
            dailyMeal.TotalCalories = 0;
            dailyMeal.TotalProteins = 0;
            dailyMeal.TotalCarbs = 0;
            dailyMeal.TotalFats = 0;
            dailyMeal.TotalFibers = 0;
            dailyMeal.TotalSugars = 0;

            foreach (var meal in mealsForDay)
            {
                meal.DailyMealId = dailyMeal.DailyMealId;
                _mealRepository.Update(meal);

                var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);
                if (mealFoods == null || !mealFoods.Any())
                {
                    Console.WriteLine($"⚠️ Không có MealFood nào cho Meal {meal.MealId}");
                    continue;
                }
                Console.WriteLine($"✅ Tìm thấy {mealFoods.Count()} MealFood(s) cho Meal {meal.MealId}");

                foreach (var mealFood in mealFoods)
                {
                    var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);
                    if (portion == null)
                    {
                        Console.WriteLine($"⚠️ Không tìm thấy Portion với PortionId: {mealFood.PortionId}");
                        continue;
                    }

                    var food = await _foodRepository.GetByIdAsync(mealFood.FoodId);
                    if (food == null || food.Nutrition == null)
                    {
                        Console.WriteLine($"⚠️ Không tìm thấy Food hoặc Nutrition với FoodId: {mealFood.FoodId}");
                        continue;
                    }

                    if (mealFood.Status) // 🔹 Chỉ cập nhật nếu mealFood đã được đánh dấu là hợp lệ
                    {
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

            // 🔹 Cập nhật `DailyMeal` vào DB
            _dailyMealRepository.Update(dailyMeal);
            await _dailyMealRepository.SaveChangeAsync();

            Console.WriteLine($"✅ DailyMeal saved for User {userId} on {date}: {dailyMeal.TotalCalories} calories");
        }
    }
}
