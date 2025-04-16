using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Meal.Commands.CreateMeal
{
    public class CreateMealCommandHandler : IRequestHandler<CreateMealCommand, Guid>
    {
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IFoodPortionRepository _foodPortionRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IFoodRepository _foodRepository;

        public CreateMealCommandHandler(
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IPortionRepository portionRepository,
            IFoodPortionRepository foodPortionRepository,
            IDailyMealRepository dailyMealRepository,
            IGoalRepository goalRepository,
            IFoodRepository foodRepository)
        {
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
            _foodPortionRepository = foodPortionRepository;
            _dailyMealRepository = dailyMealRepository;
            _goalRepository = goalRepository;
            _foodRepository = foodRepository;
        }

        public async Task<Guid> Handle(CreateMealCommand request, CancellationToken cancellationToken)
        {
            var userId = request.CreateMeal.UserId;
            var currentDate = DateTime.Now.Date.Day; // Lấy toàn bộ ngày, không chỉ số ngày
            if (request.CreateMeal.MealType == null)
            {
                throw new ArgumentException("MealType không được để trống.");
            }

            var mealTypeString = request.CreateMeal.MealType.ToString();

            if (!Enum.TryParse(mealTypeString, out MealType mealTypeEnum) ||
                          !Enum.IsDefined(typeof(MealType), mealTypeEnum))
            {
                throw new ArgumentException("MealType phải là một trong các giá trị: Breakfast, Lunch, Dinner, Snack");
            }

            // Kiểm tra bữa ăn đã tồn tại trong ngày hiện tại
            var existingMeal = await _mealRepository.GetByUserIdAndMealType(userId, mealTypeEnum, currentDate);
            Console.WriteLine(existingMeal != null ? $"Meal exists: {existingMeal.MealId}" : "Meal not found");

            Monhealth.Domain.Meal model;

            if (existingMeal != null)
            {
                Console.WriteLine("Updating existing meal...");
                model = existingMeal;
                model.UpdatedAt = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Creating new meal...");
                model = new Monhealth.Domain.Meal
                {
                    UserId = userId,
                    MealType = mealTypeEnum,
                    MealDate = request.CreateMeal.MealDate,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                };

                _mealRepository.Add(model);
            }

            await _mealRepository.SaveChangeAsync();


            foreach (var item in request.CreateMeal.Items)
            {
                if (item.Quantity <= 0) throw new Exception("Quantity phải lớn hơn hoặc bằng 0");

                var existingPortion = await _portionRepository.GetPortionAsync(item.MeasurementUnit, item.PortionSize, item.PortionWeight);
                Portion portion = existingPortion ?? new Portion
                {
                    MeasurementUnit = item.MeasurementUnit,
                    PortionSize = item.PortionSize,
                    PortionWeight = item.PortionWeight,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                Guid portionId;
                if (existingPortion == null)
                {
                    _portionRepository.Add(portion);
                    await _portionRepository.SaveChangesAsync();
                    _foodPortionRepository.Add(new FoodPortion
                    {
                        FoodId = item.FoodId,
                        PortionId = portion.PortionId
                    });
                    portionId = portion.PortionId;
                }
                else
                {
                    portionId = existingPortion.PortionId;
                }

                var existingMealItem = await _mealFoodRepository.GetByMealIdAndFoodId(model.MealId, item.FoodId);
                if (existingMealItem != null && existingMealItem.PortionId == portionId)
                {
                    existingMealItem.Quantity += item.Quantity;
                    existingMealItem.UpdatedAt = DateTime.Now;
                }
                else
                {
                    var mealFood = new Domain.MealFood
                    {
                        MealId = model.MealId,
                        FoodId = item.FoodId,
                        Quantity = item.Quantity,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        PortionId = portionId,
                        IsRecommended = false,
                        IsCompleted = false,
                    };
                    _mealFoodRepository.Add(mealFood);
                }

                await _mealRepository.SaveChangeAsync();
                var food = await _foodRepository.GetByIdAsync(item.FoodId);
                if (food != null)
                {
                    food.Views += 1;
                    _foodRepository.Update(food);
                    await _foodRepository.SaveChangesAsync();
                }
            }

            var currentDate1 = DateTime.Now.Date;
            var mealsForDay = await _mealRepository.GetMealByUserAndDate(request.CreateMeal.MealDate, userId);

            var dailyMeal = await _dailyMealRepository.GetDailyMealByUserAndDate(request.CreateMeal.MealDate, userId);
            var goal = await _goalRepository.GetByUserIdAsync(userId);

            if (goal == null)
            {
                throw new Exception($"Kong tìm thấy Goal nào liên kết với UserId: {userId}");
            }

            if (dailyMeal == null)
            {
                dailyMeal = new Domain.DailyMeal
                {
                    GoalId = goal.GoalId,
                    UserId = userId,
                    CreatedAt = currentDate1,
                    UpdatedAt = DateTime.Now,
                    DailyMealDate = request.CreateMeal.MealDate,
                    TotalCalories = 0,
                    TotalProteins = 0,
                    TotalCarbs = 0,
                    TotalFats = 0,
                    TotalFibers = 0,
                    TotalSugars = 0
                };
                _dailyMealRepository.Add(dailyMeal);

                // Lưu DailyMeal để lấy DailyMealID
                await _dailyMealRepository.SaveChangeAsync();
            }
            else
            {
                dailyMeal.TotalCalories = 0;
                dailyMeal.TotalProteins = 0;
                dailyMeal.TotalCarbs = 0;
                dailyMeal.TotalFats = 0;
                dailyMeal.TotalFibers = 0;
                dailyMeal.TotalSugars = 0;
            }

            // Gán DailyMealID cho từng Meal
            foreach (var meal in mealsForDay)
            {
                meal.DailyMealId = dailyMeal.DailyMealId; // Gán DailyMealID cho Meal
                _mealRepository.Update(meal);

                var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);

                foreach (var mealFood in mealFoods)
                {
                    var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);
                    if (portion == null)
                    {
                        throw new Exception($"Không tìm thấy Portion với PortionId: {mealFood.PortionId}");
                    }
                    if (mealFood.IsCompleted == true)
                    {
                        var food = mealFood.Food;
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

            return model.MealId;
        }
    }
}
