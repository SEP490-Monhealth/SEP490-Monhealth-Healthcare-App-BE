using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
using Microsoft.Extensions.Logging;
using Monhealth.Domain.Enum;
using Monhealth.Application.Features.Meal.RecommendMealForUser.SupportFunction;
using Monhealth.Domain;
using Monhealth.Identity.Models;
using Microsoft.EntityFrameworkCore;

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

            // Get user with their goals
            AppUser? gettingUser = await _userRepository.GetUserByIdAsync(userId);
            if (gettingUser == null)
            {
                throw new Exception($"User with ID {userId} not found");
            }

            // Get user's most recent goal
            var latestGoal = gettingUser.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();
            if (latestGoal == null)
            {
                throw new Exception($"No goals found for user {userId}");
            }

            // Get user's allergens to filter out
            var userAllergies = await _filterFoodListHandler.FilterFoodListQueryHandler(userId);
            var allergiesIds = gettingUser.UserAllergies?.Select(ua => ua.AllergyId).ToList() ?? new List<Guid>();

            // Generate meal plans for the next 3 days
            int days = 3;
            List<Guid> createdDailyMealIds = new List<Guid>();

            for (int i = 0; i < days; i++)
            {
                var currentDate = DateTime.Now.Date.AddDays(i);

                // Create a DailyMeal record for this day
                var dailyMeal = new DailyMeal
                {
                    DailyMealId = Guid.NewGuid(),
                    GoalId = latestGoal.GoalId,
                    UserId = userId,
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate,
                    TotalCalories = 0,
                    TotalProteins = 0,
                    TotalCarbs = 0,
                    TotalFats = 0,
                    TotalFibers = 0,
                    TotalSugars = 0,
                    Meals = new List<Meal>()
                };

                // Create meals for each meal type
                var breakfast = await CreateMealForType(MealType.Breakfast, gettingUser, latestGoal, allergiesIds);
                var lunch = await CreateMealForType(MealType.Lunch, gettingUser, latestGoal, allergiesIds);
                var dinner = await CreateMealForType(MealType.Dinner, gettingUser, latestGoal, allergiesIds);

                // Add meals to the daily meal
                dailyMeal.Meals.Add(breakfast);
                dailyMeal.Meals.Add(lunch);
                dailyMeal.Meals.Add(dinner);

                // Calculate and update daily meal nutritional totals
                await UpdateDailyMealNutrition(dailyMeal);

                // Save to repository
                _dailyMealRepository.Add(dailyMeal);
                createdDailyMealIds.Add(dailyMeal.DailyMealId);
            }

            // Save all changes at once
            await _dailyMealRepository.SaveChangeAsync();

            // Return the ID of the first daily meal
            return createdDailyMealIds.FirstOrDefault();
        }

        private async Task UpdateDailyMealNutrition(DailyMeal dailyMeal)
        {
            // Reset nutritional totals
            dailyMeal.TotalCalories = 0;
            dailyMeal.TotalProteins = 0;
            dailyMeal.TotalCarbs = 0;
            dailyMeal.TotalFats = 0;
            dailyMeal.TotalFibers = 0;
            dailyMeal.TotalSugars = 0;

            // Sum up nutrition from all meals
            foreach (var meal in dailyMeal.Meals)
            {
                foreach (var mealFood in meal.MealFoods)
                {
                    // Get the portion from the repository using the PortionId
                    var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);

                    if (portion != null)
                    {
                        // Calculate scaling factor based on portion weight
                        float scalingFactor = portion.PortionWeight / 100f; // Assuming nutrition values are per 100g

                        // Get nutrition for this food
                        var nutrition = mealFood.Food?.Nutrition;
                        if (nutrition != null)
                        {
                            dailyMeal.TotalCalories += nutrition.Calories * scalingFactor;
                            dailyMeal.TotalProteins += nutrition.Protein * scalingFactor;
                            dailyMeal.TotalCarbs += nutrition.Carbs * scalingFactor;
                            dailyMeal.TotalFats += nutrition.Fat * scalingFactor;
                            dailyMeal.TotalFibers += nutrition.Fiber * scalingFactor;
                            dailyMeal.TotalSugars += nutrition.Sugar * scalingFactor;
                        }
                    }
                }
            }
        }

        private async Task<Meal> CreateMealForType(MealType mealType, AppUser user, Goal userGoal, List<Guid> allergiesIds)
        {
            _logger.LogInformation($"Creating {mealType} meal for user {user.Id}");

            // Get foods based on nutritional requirements
            var (proteinFood, carbFood, balanceFood, vegetableFood) = await GetFoodsForMeal(allergiesIds);

            // Check if we have the necessary foods
            if (vegetableFood == null)
            {
                _logger.LogWarning("No suitable vegetable found for meal");
                // Use a fallback or default vegetable if available
            }

            // Calculate total calories for this meal type based on goal
            var totalCaloriesDaily = userGoal.CaloriesGoal;
            var mealCalories = CalculateMealCalories(mealType, userGoal.GoalType, totalCaloriesDaily);

            // Create meal entity
            var meal = new Meal
            {
                MealId = Guid.NewGuid(),
                MealType = mealType,
                UserId = user.Id,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                MealFoods = new List<MealFood>()
            };

            // Use balanced meal if available, otherwise separate protein and carbs
            if (balanceFood != null)
            {
                await AddFoodToMeal(meal, balanceFood, mealCalories * 0.9f, user.Id);
                if (vegetableFood != null)
                {
                    await AddFoodToMeal(meal, vegetableFood, mealCalories * 0.1f, user.Id);
                }
            }
            else
            {
                // Add protein, carbs, and vegetables with appropriate calorie distribution
                if (proteinFood != null)
                {
                    await AddFoodToMeal(meal, proteinFood, mealCalories * 0.4f, user.Id);
                }

                if (carbFood != null)
                {
                    await AddFoodToMeal(meal, carbFood, mealCalories * 0.5f, user.Id);
                }

                if (vegetableFood != null)
                {
                    await AddFoodToMeal(meal, vegetableFood, mealCalories * 0.1f, user.Id);
                }
            }

            // Add the meal to repository
            _mealRepository.Add(meal);

            return meal;
        }

        private async Task AddFoodToMeal(Meal meal, Food food, float targetCalories, Guid userId)
        {
            if (food == null || food.Nutrition == null)
            {
                _logger.LogWarning("Cannot add null food or food without nutrition to meal");
                return;
            }

            // Calculate portion weight based on desired calories
            // Formula: weight = (targetCalories / caloriesPer100g) * 100
            var portionWeight = (targetCalories / food.Nutrition.Calories) * 100;

            // Create a new portion
            var portionId = Guid.NewGuid();
            var portion = new Portion
            {
                PortionId = portionId,
                PortionSize = "phần",
                PortionWeight = portionWeight,
                MeasurementUnit = "g",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = userId,
                UpdatedBy = userId
            };

            // Add portion to repository
            _portionRepository.Add(portion);

            // Create meal-food relationship
            var mealFood = new MealFood
            {
                MealFoodId = Guid.NewGuid(),
                FoodId = food.FoodId,
                MealId = meal.MealId,
                PortionId = portionId,
                Quantity = 1,
                IsCompleted = false
            };

            // Add to meal foods collection
            meal.MealFoods.Add(mealFood);
        }

        private float CalculateMealCalories(MealType mealType, GoalType goalType, float totalCaloriesDaily)
        {
            // Calculate meal calories based on meal type and goal type
            return mealType switch
            {
                MealType.Breakfast => goalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.20f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.25f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.30f,
                    _ => totalCaloriesDaily * 0.25f // Default
                },
                MealType.Lunch => goalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.40f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.35f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.35f,
                    _ => totalCaloriesDaily * 0.35f // Default
                },
                MealType.Dinner => goalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.30f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.30f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.25f,
                    _ => totalCaloriesDaily * 0.30f // Default
                },
                _ => totalCaloriesDaily * 0.30f // Default for unknown meal types
            };
        }

        private async Task<(Food?, Food?, Food?, Food?)> GetFoodsForMeal(List<Guid> allergiesIds)
        {
            try
            {
                // First attempt: Try getting foods through repository method
                var foods = await _foodRepository.GetRandomProteinAndCarbFood(allergiesIds);

                // Check if we got all needed foods
                if ((foods.Item1 != null && foods.Item2 != null) || foods.Item3 != null)
                {
                    if (foods.Item4 == null)
                    {
                        // If vegetable is missing, try to find one
                        foods.Item4 = await FindVegetableFood(allergiesIds);
                    }
                    return foods;
                }

                // Fallback: If repository method fails, try constructing foods manually
                return await FallbackFoodSelection(allergiesIds);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error selecting foods for meal");
                return await FallbackFoodSelection(allergiesIds);
            }
        }

        private async Task<Food?> FindVegetableFood(List<Guid> allergiesIds)
        {
            // Implementation to find a vegetable food when the main method fails
            return await _foodRepository.GetAll()
                .Where(f =>
                    f.Nutrition != null &&
                    f.Nutrition.VitaminC >= 0.1f ||
                    (f.Nutrition.VitaminA ?? 0) >= 0.1f &&
                    !allergiesIds.Any(al => f.FoodAllergies.Any(fa => fa.AllergyId == al))
                )
                .OrderBy(x => Guid.NewGuid()) // Random selection
                .FirstOrDefaultAsync();
        }

        private async Task<(Food?, Food?, Food?, Food?)> FallbackFoodSelection(List<Guid> allergiesIds)
        {
            // Fallback implementation when main food selection fails

            // Try to find a protein-rich food
            var proteinFood = await _foodRepository.GetAll()
                .Where(f =>
                    f.Nutrition != null &&
                    f.Nutrition.Protein >= 15 &&
                    !allergiesIds.Any(al => f.FoodAllergies.Any(fa => fa.AllergyId == al))
                )
                .OrderBy(x => Guid.NewGuid())
                .FirstOrDefaultAsync();

            // Try to find a carb-rich food
            var carbFood = await _foodRepository.GetAll()
                .Where(f =>
                    f.Nutrition != null &&
                    f.Nutrition.Carbs >= 15 &&
                    !allergiesIds.Any(al => f.FoodAllergies.Any(fa => fa.AllergyId == al))
                )
                .OrderBy(x => Guid.NewGuid())
                .FirstOrDefaultAsync();

            // Try to find a balanced food
            var balanceFood = await _foodRepository.GetAll()
                .Where(f =>
                    f.Nutrition != null &&
                    f.Nutrition.Protein >= 10 &&
                    f.Nutrition.Carbs >= 10 &&
                    !allergiesIds.Any(al => f.FoodAllergies.Any(fa => fa.AllergyId == al))
                )
                .OrderBy(x => Guid.NewGuid())
                .FirstOrDefaultAsync();

            // Try to find a vegetable
            var vegetableFood = await FindVegetableFood(allergiesIds);

            return (proteinFood, carbFood, balanceFood, vegetableFood);
        }
    }
}