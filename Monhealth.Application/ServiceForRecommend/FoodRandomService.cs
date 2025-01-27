using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Food.AddFood;
using Monhealth.Application.ServiceForRecommend.DTO;
using Monhealth.Application.Services;
using Monhealth.Core.Enum;

namespace Monhealth.Application.ServiceForRecommend
{
    public class FoodRandomService
    {
        private readonly IFoodRepository _foodRepository;
        private readonly FoodFilterService _foodFilterService;
        private readonly GoalService _goalService;
        private readonly ILogger<FoodRandomService> _logger;

        public FoodRandomService(
            IFoodRepository foodRepository,
            FoodFilterService foodFilterService,
            GoalService goalService,
            ILogger<FoodRandomService> logger)
        {
            _foodRepository = foodRepository;
            _foodFilterService = foodFilterService;
            _goalService = goalService;
            _logger = logger;
        }

        public async Task<MealPlanWithAllocationDTO> GetMealPlanWithAllocationAsync(Guid userId)
        {
            var mealAllocations = await _goalService.GetMealAllocationByUserIdAsync(userId);

            if (mealAllocations == null || !mealAllocations.Any())
            {
                _logger.LogWarning($"No goal allocation found for user {userId}.");
                return new MealPlanWithAllocationDTO();
            }

            return new MealPlanWithAllocationDTO
            {
                Breakfast = await GenerateMealAsync(MealType.Breakfast, mealAllocations["breakfast"], userId),
                Lunch = await GenerateMealAsync(MealType.Lunch, mealAllocations["lunch"], userId),
                Dinner = await GenerateMealAsync(MealType.Dinner, mealAllocations["dinner"], userId)
            };
        }

        private async Task<MealDTO> GenerateMealAsync(MealType mealType, MealAllocationDTO allocation, Guid userId)
        {
            if (mealType == MealType.Breakfast)
            {
                var mainDishRatio = 0.8f;
                return new MealDTO
                {
                    MainDish = await GetRandomDishWithPortionAsync(mealType.ToString(), DishType.MainDish, userId, allocation, mainDishRatio)
                };
            }
            else
            {
                var mainDishRatio = 0.5f;
                var sideDishRatio = 0.3f;
                var dessertRatio = 0.1f;

                return new MealDTO
                {
                    MainDish = await GetRandomDishWithPortionAsync(mealType.ToString(), DishType.MainDish, userId, allocation, mainDishRatio),
                    SideDish = await GetRandomDishWithPortionAsync(mealType.ToString(), DishType.SideDish, userId, allocation, sideDishRatio),
                    Dessert = await GetRandomDishWithPortionAsync(mealType.ToString(), DishType.Dessert, userId, allocation, dessertRatio)
                };
            }
        }

        private async Task<DishDTO?> GetRandomDishWithPortionAsync(string mealType, DishType dishType, Guid userId, MealAllocationDTO allocation, float ratio)
        {
            var filteredFoods = await _foodFilterService.GetFilterFoodAsync(
                userId,
                1,
                100,
                new List<string> { mealType },
                new List<string> { dishType.ToString() }
            );

            if (filteredFoods == null || !filteredFoods.Items.Any())
            {
                _logger.LogInformation($"No foods found for MealType {mealType} with DishType {dishType} for user {userId}.");
                return null;
            }

            var foodIds = filteredFoods.Items.Select(f => f.FoodId).ToList();
            if (foodIds == null || !foodIds.Any())
            {
                _logger.LogInformation($"No valid food IDs for MealType {mealType} with DishType {dishType}.");
                return null;
            }

            var nutritionData = await _foodRepository.GetNutritionByFoodIdsAsync(foodIds);
            if (nutritionData == null || !nutritionData.Any())
            {
                _logger.LogInformation($"No nutrition data found for foods in MealType {mealType} and DishType {dishType} for user {userId}.");
                return null;
            }

            var scoredFoods = nutritionData
           .Select(n => new
           {
               Nutrition = n,
               Portion = CalculateNewPortion(
              new NutritionDTO
              {
                  Calories = n.Calories,
                  Protein = n.Protein,
                  Carbs = n.Carbs,
                  Fat = n.Fat,
                  Fiber = n.Fiber,
                  Sugar = n.Sugar
              },
              allocation,
              ratio
          ),
               Score = Math.Sqrt(
              Math.Pow(n.Calories - allocation.Calories * ratio, 2) +
              Math.Pow(n.Protein - allocation.Protein * ratio, 2) +
              Math.Pow(n.Carbs - allocation.Carbs * ratio, 2) +
              Math.Pow(n.Fat - allocation.Fat * ratio, 2) +
              Math.Pow(n.Fiber - allocation.Fiber * ratio, 2) +
              Math.Pow(n.Sugar - allocation.Sugar * ratio, 2)
          )
           })
      .OrderBy(x => x.Score)
      .ToList();


            if (!scoredFoods.Any())
            {
                _logger.LogInformation("No suitable food found after scoring.");
                return null;
            }

            var random = new Random();
            var bestFood = scoredFoods.Take(Math.Min(5, scoredFoods.Count)).OrderBy(x => random.Next()).First();

            return new DishDTO
            {
                Food = new FoodDTO
                {
                    FoodId = bestFood.Nutrition.FoodId ?? Guid.Empty,
                    FoodName = filteredFoods.Items.FirstOrDefault(f => f.FoodId == bestFood.Nutrition.FoodId)?.FoodName ?? "Unknown Food"
                },
                Allocation = new MealAllocationDTO
                {
                    Calories = bestFood.Nutrition.Calories,
                    Protein = bestFood.Nutrition.Protein,
                    Carbs = bestFood.Nutrition.Carbs,
                    Fat = bestFood.Nutrition.Fat,
                    Fiber = bestFood.Nutrition.Fiber,
                    Sugar = bestFood.Nutrition.Sugar
                },
                GoalAllocation = new MealAllocationDTO
                {
                    Calories = allocation.Calories * ratio,
                    Protein = allocation.Protein * ratio,
                    Carbs = allocation.Carbs * ratio,
                    Fat = allocation.Fat * ratio,
                    Fiber = allocation.Fiber * ratio,
                    Sugar = allocation.Sugar * ratio
                },
                Portion = bestFood.Portion
            };
        }

        private PortionDTO CalculateNewPortion(NutritionDTO nutrition, MealAllocationDTO allocation, float ratio)
        {
            var portionWeight = 100 * (allocation.Calories * ratio / nutrition.Calories);

            return new PortionDTO
            {
                PortionWeight = portionWeight,
                MeasurementUnit = "g" // Đơn vị cố định là gram
            };
        }
    }

    public class MealPlanWithAllocationDTO
    {
        public MealDTO Breakfast { get; set; } = new MealDTO();
        public MealDTO Lunch { get; set; } = new MealDTO();
        public MealDTO Dinner { get; set; } = new MealDTO();
    }

    public class MealDTO
    {
        public DishDTO? MainDish { get; set; }
        public DishDTO? SideDish { get; set; }
        public DishDTO? Dessert { get; set; }
    }

    public class DishDTO
    {
        public FoodDTO? Food { get; set; }
        public MealAllocationDTO? Allocation { get; set; }
        public MealAllocationDTO? GoalAllocation { get; set; }
        public PortionDTO? Portion { get; set; }
    }

    public class FoodDTO
    {
        public Guid FoodId { get; set; }
        public string FoodName { get; set; } = string.Empty;
    }

    public class PortionDTO
    {
        public string PortionSize { get; set; } = "";
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; } = "g";
    }
}
