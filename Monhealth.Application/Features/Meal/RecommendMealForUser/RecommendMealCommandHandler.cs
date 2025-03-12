using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
using Microsoft.Extensions.Logging;
using Monhealth.Domain.Enum;
using Monhealth.Application.Features.Meal.RecommendMealForUser.SupportFunction;
using Monhealth.Domain;
using Monhealth.Identity.Models;

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
        private readonly IFoodRepository _foodRepository;
        private readonly IUserRepository _userRepository;

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
            CreateMealForTypeHandler createMealForTypeHandler,
            IFoodRepository foodRepository,
            IUserRepository userRepository)
        {
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
            _dailyMealRepository = dailyMealRepository;
            _goalRepository = goalRepository;
            _logger = logger;
            _filterFoodListHandler = filterFoodListHandler;
            _createMealForTypeHandler = createMealForTypeHandler;
            _foodRepository = foodRepository;
            _userRepository = userRepository;
        }

        public async Task<Guid> Handle(CreateRecommendMealCommand request, CancellationToken cancellationToken)
        {
            var userId = request.UserId;

            _logger.LogInformation($"Handling meal recommendation for UserId: {userId}");

            AppUser? gettingUser = await _userRepository.GetByIdAsync(userId);

            int days = 3;
            for (int i = 0; i < days; i++)
            {
                var currentDate = DateTime.Now.Date.AddDays(i);
                var breakfast = await CreateMealForType(MealType.Breakfast, gettingUser);
                var lunch = await CreateMealForType(MealType.Lunch, gettingUser);
                var dinner = await CreateMealForType(MealType.Dinner, gettingUser);
                _dailyMealRepository.Add(new DailyMeal
                {
                    GoalId = gettingUser.Goals.OrderByDescending(g=>g.CreatedAt).FirstOrDefault()?.GoalId ?? Guid.Empty,
                    UserId = userId,
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate,
                    TotalCalories = 0,
                    TotalProteins = 0,
                    TotalCarbs = 0,
                    TotalFats = 0,
                    TotalFibers = 0,
                    TotalSugars = 0
                });
            }
            await _dailyMealRepository.SaveChangeAsync();
            return Guid.Empty;

            // var userGoal = await _goalRepository.GetCurrentGoalByUserIdAsync(userId);
            // if (userGoal == null)
            // {
            //     _logger.LogError("No nutrition goal found for the user.");
            //     throw new Exception("Không tìm thấy mục tiêu dinh dưỡng cho người dùng.");
            // }


            // // if either one of two empty throw exception
            // if(proteinFoodId == null && carbsFoodId == null)
            // {
            //     _logger.LogError("No protein and carbs food found.");
            //     throw new Exception("Không tìm thấy thức ăn chứa protein và carbs.");
            // }

            // // Tính toán lượng calo cho mỗi bữa ăn
            // var totalCalories = userGoal.CaloriesGoal;
            





            // List<MealCaloriesDTO> mealCalories = [];
            // _logger.LogInformation($"Total calories for the user: {totalCalories}");

            // float breakfastCalories = 0f, lunchCalories = 0f, dinnerCalories = 0f;
            // var goalType = userGoal.GoalType;
            // switch (goalType)
            // {
            //     case GoalType.WeightLoss:
            //         breakfastCalories = totalCalories * 0.20f;
            //         lunchCalories = totalCalories * 0.40f;
            //         dinnerCalories = totalCalories * 0.30f;
            //         break;
            //     case GoalType.WeightGain:
            //         breakfastCalories = totalCalories * 0.25f;
            //         lunchCalories = totalCalories * 0.35f;
            //         dinnerCalories = totalCalories * 0.30f;
            //         break;
            //     case GoalType.Maintenance:
            //         breakfastCalories = totalCalories * 0.30f;
            //         lunchCalories = totalCalories * 0.35f;
            //         dinnerCalories = totalCalories * 0.25f;
            //         break;
            // }
            // mealCalories.AddRange(
            //     [
            //         new MealCaloriesDTO { MealType = MealType.Breakfast, Calories = breakfastCalories },
            //         new MealCaloriesDTO { MealType = MealType.Lunch, Calories = lunchCalories },
            //         new MealCaloriesDTO { MealType = MealType.Dinner, Calories = dinnerCalories }
            //     ]
            // );

            // _logger.LogInformation($"GoalType: {userGoal.GoalType}, Breakfast: {breakfastCalories}, Lunch: {lunchCalories}, Dinner: {dinnerCalories}");

            // // Lọc món ăn phù hợp từ FilterFoodListQueryHandler
            // var foodList = await _filterFoodListHandler.FilterFoodListQueryHandler(userId);

            // _logger.LogInformation($"Total foods available after filtering: {foodList.Count}");

            // // Tạo các bữa ăn cho 3 ngày
            // var currentDate = DateTime.Now.Date;
            // var mealIds = new List<Guid>();

            // for (int dayOffset = 0; dayOffset < 3; dayOffset++)
            // {
            //     var targetDate = currentDate.AddDays(dayOffset);

            //     _logger.LogInformation($"Processing meals for {targetDate.ToShortDateString()}");

            //     // Kiểm tra bữa ăn đã tồn tại trong ngày hiện tại
            //     var existingMeal = await _mealRepository.GetByUserIdAndMealType(userId, MealType.Breakfast, targetDate.Date.Day);
            //     if (existingMeal != null)
            //     {
            //         mealIds.Add(existingMeal.MealId);
            //         _logger.LogInformation($"Meal already exists for {MealType.Breakfast} on {targetDate.ToShortDateString()}.");
            //         continue;
            //     }

            //     // Tạo bữa ăn mới nếu không tồn tại
            //     var breakfast = await _createMealForTypeHandler.CreateMealForType(foodList, MealType.Breakfast, breakfastCalories, targetDate, request.UserId, goalType);
            //     var lunch = await _createMealForTypeHandler.CreateMealForType(foodList, MealType.Lunch, lunchCalories, targetDate, request.UserId, goalType);
            //     var dinner = await _createMealForTypeHandler.CreateMealForType(foodList, MealType.Dinner, dinnerCalories, targetDate, request.UserId, goalType);

            //     // Log the meal creation
            //     _logger.LogInformation($"Created meals for {MealType.Breakfast}, {MealType.Lunch}, and {MealType.Dinner} on {targetDate.ToShortDateString()}.");

            //     // Lưu các bữa ăn vào cơ sở dữ liệu
            //     _mealRepository.Add(breakfast);
            //     _mealRepository.Add(lunch);
            //     _mealRepository.Add(dinner);
            //     await _mealRepository.SaveChangeAsync();

            //     mealIds.Add(breakfast.MealId);
            //     mealIds.Add(lunch.MealId);
            //     mealIds.Add(dinner.MealId);
            // }

            // // Cập nhật thông tin DailyMeal và MealFood cho 3 ngày
            // // Cập nhật thông tin DailyMeal và MealFood cho 3 ngày
            // foreach (var mealId in mealIds)
            // {
            //     var meal = await _mealRepository.GetByIdAsync(mealId);
            //     var dailyMeal = await _dailyMealRepository.GetDailyMealByUserAndDate(meal.CreatedAt.Value, userId);
            //     var goal = await _goalRepository.GetByUserIdAsync(userId);

            //     // Kiểm tra nếu không tìm thấy DailyMeal cho ngày hiện tại
            //     if (dailyMeal == null)
            //     {
            //         dailyMeal = new Monhealth.Domain.DailyMeal
            //         {
            //             GoalId = goal.GoalId,
            //             UserId = userId,
            //             CreatedAt = meal.CreatedAt,
            //             UpdatedAt = DateTime.Now,
            //             TotalCalories = 0,
            //             TotalProteins = 0,
            //             TotalCarbs = 0,
            //             TotalFats = 0,
            //             TotalFibers = 0,
            //             TotalSugars = 0
            //         };
            //         _dailyMealRepository.Add(dailyMeal);
            //         await _dailyMealRepository.SaveChangeAsync();  // Lưu DailyMeal và lấy DailyMealId
            //     }
            //     // else
            //     // {
            //     //     dailyMeal.TotalCalories = 0;
            //     //     dailyMeal.TotalProteins = 0;
            //     //     dailyMeal.TotalCarbs = 0;
            //     //     dailyMeal.TotalFats = 0;
            //     //     dailyMeal.TotalFibers = 0;
            //     //     dailyMeal.TotalSugars = 0;
            //     // }


            //     // Gán DailyMealId cho bữa ăn
            //     meal.DailyMealId = dailyMeal.DailyMealId;
            //     _mealRepository.Update(meal);

            //     // Lấy các MealFood của bữa ăn
            //     var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);
            //     foreach (var mealFood in mealFoods)
            //     {
            //         var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);
            //         if (portion == null)
            //         {
            //             throw new Exception($"Không tìm thấy Portion với PortionId: {mealFood.PortionId}");
            //         }

            //         // Nếu món ăn đã hoàn thành, tính toán dinh dưỡng
            //         if (mealFood.IsCompleted == true)
            //         {
            //             var food = mealFood.Food;
            //             var portionWeight = portion.PortionWeight;

            //             // Cập nhật dinh dưỡng vào DailyMeal
            //             dailyMeal.TotalCalories += (food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
            //             dailyMeal.TotalProteins += (food.Nutrition.Protein / 100) * (mealFood.Quantity * portionWeight);
            //             dailyMeal.TotalCarbs += (food.Nutrition.Carbs / 100) * (mealFood.Quantity * portionWeight);
            //             dailyMeal.TotalFats += (food.Nutrition.Fat / 100) * (mealFood.Quantity * portionWeight);
            //             dailyMeal.TotalFibers += (food.Nutrition.Fiber / 100) * (mealFood.Quantity * portionWeight);
            //             dailyMeal.TotalSugars += (food.Nutrition.Sugar / 100) * (mealFood.Quantity * portionWeight);

            //             _logger.LogInformation($"Updated daily meal total for {food.FoodId}: Calories = {food.Nutrition.Calories}, Quantity = {mealFood.Quantity}");
            //         }
            //     }

            //     // Cập nhật lại thông tin DailyMeal sau khi tính toán
            //     dailyMeal.UpdatedAt = DateTime.Now;
            //     await _dailyMealRepository.SaveChangeAsync();
            // }

            // return mealIds.First();
        }

        private async Task<Meal> CreateMealForType(MealType mealType, AppUser user)
        {
            // Get Random First
            var (proteinFood, carbFood) = await _foodRepository.GetRandomProteinAndCarbFood([]);
            var totalCaloriesDaily = user.Goals.OrderByDescending(g=>g.CreatedAt).FirstOrDefault()?.CaloriesGoal ?? 0;

            var mealCalories = mealType switch
            {
                MealType.Breakfast => user.Goals.OrderByDescending(g=>g.CreatedAt).FirstOrDefault()?.GoalType switch{
                    GoalType.WeightLoss => totalCaloriesDaily * 0.20f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.25f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.30f,
                    _ => 0
                },
                MealType.Lunch => user.Goals.OrderByDescending(g=>g.CreatedAt).FirstOrDefault()?.GoalType switch{
                    GoalType.WeightLoss => totalCaloriesDaily * 0.40f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.35f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.35f,
                    _ => 0
                },
                MealType.Dinner => user.Goals.OrderByDescending(g=>g.CreatedAt).FirstOrDefault()?.GoalType switch{
                    GoalType.WeightLoss => totalCaloriesDaily * 0.30f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.30f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.25f,
                    _ => 0
                },
                _ => 0
            };
            var (proteinCalories, carbsCalories) = (mealCalories * 0.40f, mealCalories * 0.60f);
            var proteinWeight = 100 * (proteinFood.Nutrition.Calories/proteinCalories);
            var carbWeight = 100 * (carbFood.Nutrition.Calories/carbsCalories);
            // Create Meal
            Guid proteinPortionId = Guid.NewGuid();
            Guid carbPortionId = Guid.NewGuid();
            _portionRepository.Add(new(){
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                PortionWeight = proteinWeight,
                CreatedBy = user.Id,
                UpdatedBy = user.Id,
                PortionId = proteinPortionId,
                PortionSize = "phan",
                MeasurementUnit = "gram"
            });
            _portionRepository.Add(new(){
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                PortionWeight = proteinWeight,
                CreatedBy = user.Id,
                UpdatedBy = user.Id,
                PortionId = carbPortionId,
                PortionSize = "phan",
                MeasurementUnit = "gram"
            });
            var meal = new Meal
            {
                MealType = mealType,
                UserId = user.Id,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                MealFoods = new List<MealFood>
                {
                    new MealFood
                    {
                        FoodId = proteinFood.FoodId,
                        Quantity = 1,
                        IsCompleted = false,
                        PortionId = proteinPortionId
                    },
                    new MealFood
                    {
                        FoodId = carbFood.FoodId,
                        Quantity = 1,
                        IsCompleted = false,
                        PortionId = carbPortionId
                    }
                }
            };
            _mealRepository.Add(meal);
            return meal;
        }
    }
}