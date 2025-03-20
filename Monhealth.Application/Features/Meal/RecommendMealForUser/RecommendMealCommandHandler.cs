using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
using Microsoft.Extensions.Logging;
using Monhealth.Domain.Enum;
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
            IFoodRepository foodRepository,
            IUserRepository userRepository)
        {
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
            _dailyMealRepository = dailyMealRepository;
            _goalRepository = goalRepository;
            _logger = logger;
            _foodRepository = foodRepository;
            _userRepository = userRepository;
        }
        public async Task<Guid> Handle(CreateRecommendMealCommand request, CancellationToken cancellationToken)
        {
            var userId = request.UserId;

            _logger.LogInformation($"Handling meal recommendation for UserId: {userId}");
            AppUser? gettingUser = await _userRepository.GetUserByIdAsync(userId);

            if (gettingUser == null)
            {
                throw new Exception("User not found");
            }

            int days = 3;
            // Biến để lưu currentDate
            DateTime? storedCurrentDate = null;

            // Thêm DailyMeal cho mỗi ngày và gán currentDate vào Meal
            for (int i = 0; i < days; i++)
            {
                var currentDate = DateTime.Now.Date.AddDays(i);
                storedCurrentDate = currentDate;  // Lưu giá trị currentDate vào biến
                var dailyMealId = Guid.NewGuid();
                _dailyMealRepository.Add(new DailyMeal
                {
                    GoalId = gettingUser.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault()?.GoalId ?? Guid.Empty,
                    DailyMealId = dailyMealId,
                    UserId = userId,
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate,
                    TotalCalories = 0,
                    TotalProteins = 0,
                    TotalCarbs = 0,
                    TotalFats = 0,
                    TotalFibers = 0,
                    TotalSugars = 0,
                    Meals = [
                    await CreateMealForType(MealType.Breakfast, gettingUser,dailyMealId), //Breakfast
                    await CreateMealForType(MealType.Lunch, gettingUser,dailyMealId), //Lunch
                    await CreateMealForType(MealType.Dinner, gettingUser,dailyMealId), //Dinner
                    ],
                });
            }
            await _dailyMealRepository.SaveChangeAsync();

            return Guid.Empty;
        }




        private async Task<Meal> CreateMealForType(MealType mealType, AppUser user, Guid dailyMealId)
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
            double proteinCalories = 0;
            double carbsCalories = 0;
            double vegetableCalories = 0;
            double balanceCalories = 0;
            if (mealCalories > 0)
            {

                if (userGoal.GoalType == GoalType.WeightLoss)
                {
                    proteinCalories = mealCalories * 0.4;
                    carbsCalories = mealCalories * 0.5;
                    vegetableCalories = mealCalories * 0.1;
                    balanceCalories = mealCalories * 0.9;
                }
                else if (userGoal.GoalType == GoalType.WeightGain)
                {
                    proteinCalories = mealCalories * 0.5;
                    carbsCalories = mealCalories * 0.4;
                    vegetableCalories = mealCalories * 0.1;
                    balanceCalories = mealCalories * 0.9;
                }
                else if (userGoal.GoalType == GoalType.Maintenance)
                {
                    proteinCalories = mealCalories * 0.45;
                    carbsCalories = mealCalories * 0.45;
                    vegetableCalories = mealCalories * 0.1;
                    balanceCalories = mealCalories * 0.9;
                }
            }
            // Phân bổ calo cho protein, carbs và rau
            var vegetableWeight = 100 * vegetableCalories / vegetableFood!.Nutrition.Calories;

            Guid proteinPortionId = Guid.NewGuid();
            Guid carbPortionId = Guid.NewGuid();
            Guid vegetablePortionId = Guid.NewGuid();
            Guid balancePortionFoodId = Guid.NewGuid();

            Meal meal = new Meal();
            var mealFoods = new List<MealFood>();
            foreach (var item in mealFoods)
            {

                var existingMealItem = await _mealFoodRepository.GetByMealIdAndFoodId(meal.MealId, item.FoodId);
                if (existingMealItem != null)
                {
                    existingMealItem.Quantity += item.Quantity;
                    existingMealItem.UpdatedAt = DateTime.Now;
                }
            }
            if (balanceFood != null)
            {
                mealFoods.Add(new MealFood
                {
                    FoodId = balanceFood.FoodId,
                    Quantity = 1,
                    IsCompleted = false,
                    PortionId = balancePortionFoodId,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                mealFoods.Add(new MealFood
                {
                    FoodId = vegetableFood.FoodId,
                    PortionId = vegetablePortionId,
                    Quantity = 1,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
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
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                mealFoods.Add(new MealFood
                {
                    FoodId = carbFood.FoodId,
                    PortionId = carbPortionId,
                    Quantity = 1,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                mealFoods.Add(new MealFood
                {
                    FoodId = vegetableFood.FoodId,
                    PortionId = vegetablePortionId,
                    Quantity = 1,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
            }
            var currentDate = DateTime.Now.Date.Day;
            var existingMeal = await _mealRepository.GetByUserIdAndMealType(user.Id, mealType, currentDate);
            if (existingMeal != null)
            {

                Console.WriteLine("Updating existing meal...");
                meal = existingMeal;
                meal.UpdatedAt = DateTime.Now;
            }
            else
            {

                meal = new Meal
                {
                    MealType = mealType,
                    UserId = user.Id,
                    DailyMealId = dailyMealId,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MealFoods = mealFoods,
                };

            }

            // Thêm các Portion cho Balance, Protein, Carb và Vegetable
            if (balanceFood != null)
            {
                var balanceWeight = 100 * balanceCalories / balanceFood.Nutrition.Calories;

                _portionRepository.Add(new Portion
                {
                    PortionId = balancePortionFoodId,
                    PortionSize = "phần",
                    PortionWeight = (float)balanceWeight,
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
                    PortionWeight = (float)vegetableWeight,
                    MeasurementUnit = "g",
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
            }
            else
            {
                var proteinWeight = 100 * proteinCalories / proteinFood.Nutrition.Calories;
                var carbWeight = 100 * carbsCalories / carbFood.Nutrition.Calories;

                _portionRepository.Add(new Portion
                {
                    PortionId = proteinPortionId,
                    PortionSize = "phần",
                    PortionWeight = (float)proteinWeight,
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
                    PortionWeight = (float)carbWeight,
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
                    PortionWeight = (float)vegetableWeight,
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