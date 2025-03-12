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
            var (proteinFood, carbFood) = await _foodRepository.GetRandomProteinAndCarbFood([]);
            var totalCaloriesDaily = user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault()?.CaloriesGoal ?? 0;

            var mealCalories = mealType switch
            {
                MealType.Breakfast => user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault()?.GoalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.20f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.25f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.30f,
                    _ => 0
                },
                MealType.Lunch => user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault()?.GoalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.40f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.35f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.35f,
                    _ => 0
                },
                MealType.Dinner => user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault()?.GoalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.30f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.30f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.25f,
                    _ => 0
                },
                _ => 0
            };

            //check them goal type va meal type
            var (proteinCalories, carbsCalories) = (mealCalories * 0.40f, mealCalories * 0.60f);

            var proteinWeight = 100 * (proteinFood.Nutrition.Calories / proteinCalories);
            var carbWeight = 100 * (carbFood.Nutrition.Calories / carbsCalories);
            // luu tam vao de check sau do moi luu db

            // Create Meal
            Guid proteinPortionId = Guid.NewGuid();
            Guid carbPortionId = Guid.NewGuid();
            _portionRepository.Add(new()
            {
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                PortionWeight = proteinWeight,
                CreatedBy = user.Id,
                UpdatedBy = user.Id,
                PortionId = proteinPortionId,
                PortionSize = "phan",
                MeasurementUnit = "gram"
            });
            _portionRepository.Add(new()
            {
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