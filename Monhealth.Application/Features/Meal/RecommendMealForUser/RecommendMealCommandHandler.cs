using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
using Microsoft.Extensions.Logging;
using Monhealth.Domain.Enum;
using Monhealth.Application.Features.Meal.RecommendMealForUser.SupportFunction;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class RecommendMealCommandHandler : IRequestHandler<CreateRecommendMealCommand, Guid>
    {
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly FilterFoodListHandler _filterFoodListHandler;
        private readonly ILogger<RecommendMealCommandHandler> _logger;
        private readonly CreateMealForTypeHandler _createMealForTypeHandler;

        public RecommendMealCommandHandler(
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IPortionRepository portionRepository,
            IDailyMealRepository dailyMealRepository,
            IGoalRepository goalRepository,
            ILogger<RecommendMealCommandHandler> logger,
            FilterFoodListHandler filterFoodListHandler,
            CreateMealForTypeHandler createMealForTypeHandler)
        {
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
            _dailyMealRepository = dailyMealRepository;
            _goalRepository = goalRepository;
            _logger = logger;
            _filterFoodListHandler = filterFoodListHandler;
            _createMealForTypeHandler = createMealForTypeHandler;
        }

        public async Task<Guid> Handle(CreateRecommendMealCommand request, CancellationToken cancellationToken)
        {
            var userId = request.UserId;

            _logger.LogInformation($"Handling meal recommendation for UserId: {userId}");

            var userGoal = await _goalRepository.GetCurrentGoalByUserIdAsync(userId);
            if (userGoal == null)
            {
                _logger.LogError("No nutrition goal found for the user.");
                throw new Exception("Không tìm thấy mục tiêu dinh dưỡng cho người dùng.");
            }

            var totalCalories = userGoal.CaloriesGoal;
            List<MealCaloriesDTO> mealCalories = [];
            _logger.LogInformation($"Total calories for the user: {totalCalories}");

            float breakfastCalories = 0f, lunchCalories = 0f, dinnerCalories = 0f;
            switch (userGoal.GoalType)
            {
                case GoalType.WeightLoss:
                    breakfastCalories = totalCalories * 0.20f;
                    lunchCalories = totalCalories * 0.40f;
                    dinnerCalories = totalCalories * 0.30f;
                    break;
                case GoalType.WeightGain:
                    breakfastCalories = totalCalories * 0.25f;
                    lunchCalories = totalCalories * 0.35f;
                    dinnerCalories = totalCalories * 0.30f;
                    break;
                case GoalType.Maintenance:
                    breakfastCalories = totalCalories * 0.30f;
                    lunchCalories = totalCalories * 0.35f;
                    dinnerCalories = totalCalories * 0.25f;
                    break;
            }
            mealCalories.AddRange(
                [
                    new MealCaloriesDTO { MealType = MealType.Breakfast, Calories = breakfastCalories },
                    new MealCaloriesDTO { MealType = MealType.Lunch, Calories = lunchCalories },
                    new MealCaloriesDTO { MealType = MealType.Dinner, Calories = dinnerCalories }
                ]
            );

            _logger.LogInformation($"GoalType: {userGoal.GoalType}, Breakfast: {breakfastCalories}, Lunch: {lunchCalories}, Dinner: {dinnerCalories}");

            // Lọc món ăn phù hợp từ FilterFoodListQueryHandler
            var foodList = await _filterFoodListHandler.FilterFoodListQueryHandler(userId);

            _logger.LogInformation($"Total foods available after filtering: {foodList.Count}");

            // Tạo các bữa ăn cho 3 ngày
            var currentDate = DateTime.Now.Date;
            var mealIds = new List<Guid>();
            
            for (int dayOffset = 0; dayOffset < 3; dayOffset++)
            {
                var targetDate = currentDate.AddDays(dayOffset);

                _logger.LogInformation($"Processing meals for {targetDate.ToShortDateString()}");

                // Kiểm tra bữa ăn đã tồn tại trong ngày hiện tại
                var existingMeal = await _mealRepository.GetByUserIdAndMealType(userId, MealType.Breakfast, targetDate.Date.Day);
                if (existingMeal != null)
                {
                    mealIds.Add(existingMeal.MealId);
                    _logger.LogInformation($"Meal already exists for {MealType.Breakfast} on {targetDate.ToShortDateString()}.");
                    continue;
                }

                // Tạo bữa ăn mới nếu không tồn tại
                var breakfast = await _createMealForTypeHandler.CreateMealForType(foodList, MealType.Breakfast,breakfastCalories, targetDate, request.UserId);
                var lunch = await _createMealForTypeHandler.CreateMealForType(foodList, MealType.Lunch, lunchCalories, targetDate, request.UserId);
                var dinner = await _createMealForTypeHandler.CreateMealForType(foodList, MealType.Dinner, dinnerCalories, targetDate, request.UserId);

                // Log the meal creation
                _logger.LogInformation($"Created meals for {MealType.Breakfast}, {MealType.Lunch}, and {MealType.Dinner} on {targetDate.ToShortDateString()}.");

                // Lưu các bữa ăn vào cơ sở dữ liệu
                _mealRepository.Add(breakfast);
                _mealRepository.Add(lunch);
                _mealRepository.Add(dinner);
                await _mealRepository.SaveChangeAsync();

                mealIds.Add(breakfast.MealId);
                mealIds.Add(lunch.MealId);
                mealIds.Add(dinner.MealId);
            }

            // Cập nhật thông tin DailyMeal và MealFood cho 3 ngày
            foreach (var mealId in mealIds)
            {
                var meal = await _mealRepository.GetByIdAsync(mealId);
                var dailyMeal = await _dailyMealRepository.GetDailyMealByUserAndDate(meal.CreatedAt.Value, userId);
                var goal = await _goalRepository.GetByUserIdAsync(userId);

                if (dailyMeal == null)
                {
                    dailyMeal = new Monhealth.Domain.DailyMeal
                    {
                        GoalId = goal.GoalId,
                        UserId = userId,
                        CreatedAt = meal.CreatedAt,
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

                var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);
                foreach (var mealFood in mealFoods)
                {
                    var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);
                    if (portion == null) throw new Exception("Portion not found.");

                    var food = mealFood.Food;
                    var portionWeight = portion.PortionWeight;

                    dailyMeal.TotalCalories += food.Nutrition.Calories / 100 * (mealFood.Quantity * portionWeight);
                    dailyMeal.TotalProteins += food.Nutrition.Protein / 100 * (mealFood.Quantity * portionWeight);
                    dailyMeal.TotalCarbs += food.Nutrition.Carbs / 100 * (mealFood.Quantity * portionWeight);
                    dailyMeal.TotalFats += food.Nutrition.Fat / 100 * (mealFood.Quantity * portionWeight);
                    dailyMeal.TotalFibers += food.Nutrition.Fiber / 100 * (mealFood.Quantity * portionWeight);
                    dailyMeal.TotalSugars += food.Nutrition.Sugar / 100 * (mealFood.Quantity * portionWeight);

                    // Log information about each meal food
                    _logger.LogInformation($"MealFood added: FoodId = {food.FoodId}, Quantity = {mealFood.Quantity}, PortionWeight = {portionWeight}, Calories = {food.Nutrition.Calories}");
                }
                dailyMeal.UpdatedAt = DateTime.Now;
                await _dailyMealRepository.SaveChangeAsync();
            }
            return mealIds.First();
        }

    }
}
