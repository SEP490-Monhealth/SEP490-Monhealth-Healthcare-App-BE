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

        public RecommendMealCommandHandler(
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IPortionRepository portionRepository,
            IDailyMealRepository dailyMealRepository,
            IGoalRepository goalRepository,
            ILogger<RecommendMealCommandHandler> logger,
            FilterFoodListHandler filterFoodListHandler,
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
            _foodRepository = foodRepository;
            _userRepository = userRepository;
        }

        public async Task<Guid> Handle(CreateRecommendMealCommand request, CancellationToken cancellationToken)
        {
            var userId = request.UserId;

            _logger.LogInformation($"Handling meal recommendation for UserId: {userId}");

            AppUser? gettingUser = await _userRepository.GetUserByIdAsync(userId);

            int days = 3;
            for (int i = 0; i < days; i++)
            {
                var currentDate = DateTime.Now.Date.AddDays(i);
                var breakfast = await CreateMealForType(MealType.Breakfast, gettingUser);
                var lunch = await CreateMealForType(MealType.Lunch, gettingUser);
                var dinner = await CreateMealForType(MealType.Dinner, gettingUser);
                _dailyMealRepository.Add(new DailyMeal
                {
                    GoalId = gettingUser.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault()?.GoalId ?? Guid.Empty,
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
        }

        private async Task<Meal> CreateMealForType(MealType mealType, AppUser user)
        {
            // Get Random First
            var (proteinFood, carbFood, balanceFood, vegetableFood) = await _foodRepository.GetRandomProteinAndCarbFood([]);

            // Lấy mục tiêu gần nhất (mới nhất) của người dùng
            var userGoal = user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();
            if (userGoal == null)
            {
                throw new Exception("Không tìm thấy mục tiêu cho người dùng.");
            }

            var totalCaloriesDaily = userGoal.CaloriesGoal; // Lấy CaloriesGoal từ userGoal nếu tồn tại

            var mealCalories = mealType switch
            {
                MealType.Breakfast => userGoal.GoalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.20f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.25f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.30f,
                    _ => 0
                },
                MealType.Lunch => userGoal.GoalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.40f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.35f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.35f,
                    _ => 0
                },
                MealType.Dinner => userGoal.GoalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.30f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.30f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.25f,
                    _ => 0
                },
                _ => 0
            };

            // Phân bổ calo cho protein, carbs và rau
            var proteinCalories = mealCalories;
            var carbsCalories = mealCalories;
            var vegetableCalories = mealCalories;
            var balanceCalories = mealCalories;

            var vegetableWeight = 100 * (vegetableFood.Nutrition.Calories / vegetableCalories);

            Guid proteinPortionId = Guid.NewGuid();
            Guid carbPortionId = Guid.NewGuid();
            Guid vegetablePortionId = Guid.NewGuid();
            Guid balancePortionFoodId = Guid.NewGuid();

            var mealFoods = new List<MealFood>();

            if (balanceFood != null)
            {
                mealFoods.Add(new MealFood
                {
                    FoodId = balanceFood.FoodId,
                    Quantity = 1,
                    IsCompleted = false,
                    PortionId = balancePortionFoodId
                });

                mealFoods.Add(new MealFood
                {
                    FoodId = vegetableFood.FoodId,
                    PortionId = vegetablePortionId,
                    Quantity = 1,
                    IsCompleted = false
                });
            }
            else
            {
                // Nếu balanceFood không tồn tại, thêm proteinFood, carbFood và vegetableFood vào mealFoods
                mealFoods.Add(new MealFood
                {
                    FoodId = proteinFood.FoodId,
                    PortionId = proteinPortionId,
                    Quantity = 1,
                    IsCompleted = false
                });

                mealFoods.Add(new MealFood
                {
                    FoodId = carbFood.FoodId,
                    PortionId = carbPortionId,
                    Quantity = 1,
                    IsCompleted = false
                });

                mealFoods.Add(new MealFood
                {
                    FoodId = vegetableFood.FoodId,
                    PortionId = vegetablePortionId,
                    Quantity = 1,
                    IsCompleted = false
                });
            }

            var meal = new Meal
            {
                MealType = mealType,
                UserId = user.Id,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                MealFoods = mealFoods
            };

            // Thêm các Portion cho Balance, Protein, Carb và Vegetable
            if (balanceFood != null)
            {
                var balanceWeight = 100 * (balanceFood.Nutrition.Calories / balanceCalories);

                _portionRepository.Add(new Portion
                {
                    PortionId = balancePortionFoodId,
                    PortionSize = "phần",
                    PortionWeight = balanceWeight,
                    MeasurementUnit = "g",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });

                _portionRepository.Add(new Portion
                {
                    PortionId = vegetablePortionId,
                    PortionSize = "phần",
                    PortionWeight = vegetableWeight,
                    MeasurementUnit = "g",
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
            }
            else
            {
                var proteinWeight = 100 * (proteinFood.Nutrition.Calories / proteinCalories);
                var carbWeight = 100 * (carbFood.Nutrition.Calories / carbsCalories);

                _portionRepository.Add(new Portion
                {
                    PortionId = proteinPortionId,
                    PortionSize = "phần",
                    PortionWeight = proteinWeight,
                    MeasurementUnit = "g",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });

                _portionRepository.Add(new Portion
                {
                    PortionId = carbPortionId,
                    PortionSize = "phần",
                    PortionWeight = carbWeight,
                    MeasurementUnit = "g",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });

                _portionRepository.Add(new Portion
                {

                    PortionId = vegetablePortionId,
                    PortionSize = "phần",
                    PortionWeight = vegetableWeight,
                    MeasurementUnit = "g",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });
            }

            // Lưu meal vào repository
            _mealRepository.Add(meal);
            return meal;
        }
    }
}