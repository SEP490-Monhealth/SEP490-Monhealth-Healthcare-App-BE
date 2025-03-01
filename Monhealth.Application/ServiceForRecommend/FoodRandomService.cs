using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Food.AddFood;
using Monhealth.Application.ServiceForRecommend.DTO;
using Monhealth.Application.Services;
using Monhealth.Core.Enum;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.ServiceForRecommend
{
    public class FoodRandomService
    {
        // private readonly IFoodRepository _foodRepository;
        // private readonly FoodFilterService _foodFilterService;
        // private readonly GoalService _goalService;
        // private readonly ILogger<FoodRandomService> _logger;

        // public FoodRandomService(
        //     IFoodRepository foodRepository,
        //     FoodFilterService foodFilterService,
        //     GoalService goalService,
        //     ILogger<FoodRandomService> logger)
        // {
        //     _foodRepository = foodRepository;
        //     _foodFilterService = foodFilterService;
        //     _goalService = goalService;
        //     _logger = logger;
        // }

        // public async Task<MealPlanWithAllocationDTO> GetMealPlanWithAllocationAsync(Guid userId, GoalType goalType, float activityLevel)
        // {
        //     var mealAllocations = await _goalService.GetMealAllocationByUserIdAsync(userId);
        //     if (mealAllocations == null || !mealAllocations.Any())
        //     {
        //         _logger.LogWarning($"No goal allocation found for user {userId}.");
        //         return new MealPlanWithAllocationDTO();
        //     }

        //     return new MealPlanWithAllocationDTO
        //     {
        //         Breakfast = await GenerateMealAsync(MealType.Breakfast, mealAllocations["breakfast"], userId, goalType, activityLevel),
        //         Lunch = await GenerateMealAsync(MealType.Lunch, mealAllocations["lunch"], userId, goalType, activityLevel),
        //         Dinner = await GenerateMealAsync(MealType.Dinner, mealAllocations["dinner"], userId, goalType, activityLevel),
        //         Snack = await GenerateMealAsync(MealType.Snack, mealAllocations["snack"], userId, goalType, activityLevel)
        //     };
        // }

        // private async Task<MealDTO> GenerateMealAsync(MealType mealType, MealAllocationDTO allocation, Guid userId, GoalType goalType, float activityLevel)
        // {
        //     var (mainDishRatio, sideDishRatio, dessertRatio) = GetMealRatios(mealType, goalType, activityLevel);

        //     var mainDish = await GetRandomDishWithPortionAsync(mealType, DishType.MainDish, userId, allocation, mainDishRatio);
        //     DishDTO? sideDish = null;
        //     DishDTO? dessert = null;

        //     if (sideDishRatio > 0)
        //     {
        //         sideDish = await GetRandomDishWithPortionAsync(mealType, DishType.SideDish, userId, allocation, sideDishRatio, mainDish);
        //     }

        //     if (dessertRatio > 0)
        //     {
        //         dessert = await GetRandomDishWithPortionAsync(mealType, DishType.Dessert, userId, allocation, dessertRatio);
        //     }

        //     return new MealDTO
        //     {
        //         MainDish = mainDish,
        //         SideDish = sideDish,
        //         Dessert = dessert
        //     };
        // }

        // private async Task<DishDTO?> GetRandomDishWithPortionAsync(MealType mealType, DishType dishType, Guid userId, MealAllocationDTO allocation, float ratio, DishDTO? mainDish = null)
        // {
        //     var filteredFoods = await _foodFilterService.GetFilterFoodAsync(
        //         userId, 1, 100,
        //         new List<string> { mealType.ToString() },
        //         new List<string> { dishType.ToString() }
        //     );

        //     if (filteredFoods == null || !filteredFoods.Items.Any())
        //     {
        //         _logger.LogWarning($"No available foods found for {mealType} - {dishType}.");
        //         return null;
        //     }

        //     var foodList = filteredFoods.Items
        //         .Select(f => new FoodDTO123
        //         {
        //             FoodId = f.FoodId,
        //             FoodName = f.FoodName,
        //             FoodType = f.FoodType
        //         })
        //         .ToList();

        //     var selectedFood = SelectWeightedRandom(foodList, mealType, dishType, mainDish);
        //     if (selectedFood == null)
        //     {
        //         _logger.LogWarning($"No suitable {dishType} found for {mealType}.");
        //         return null;
        //     }

        //     var foodNutrition = await _foodRepository.GetFoodByIdAsync(selectedFood.FoodId);
        //     if (foodNutrition?.Nutrition == null)
        //     {
        //         _logger.LogWarning($"No nutrition data found for foodId {selectedFood.FoodId}.");
        //         return null;
        //     }
        //     var mappedNutrition = new Monhealth.Application.Features.Food.AddFood.NutritionDTO
        //     {
        //         Calories = foodNutrition.Nutrition.Calories,
        //         Protein = foodNutrition.Nutrition.Protein,
        //         Carbs = foodNutrition.Nutrition.Carbs,
        //         Fat = foodNutrition.Nutrition.Fat,
        //         Fiber = foodNutrition.Nutrition.Fiber,
        //         Sugar = foodNutrition.Nutrition.Sugar
        //     };

        //     var portion = CalculateNewPortion(mappedNutrition, allocation, ratio);

        //     return new DishDTO
        //     {
        //         Food = selectedFood,
        //         Allocation = new MealAllocationDTO
        //         {
        //             Calories = allocation.Calories * ratio,
        //             Protein = allocation.Protein * ratio,
        //             Carbs = allocation.Carbs * ratio,
        //             Fat = allocation.Fat * ratio,
        //             Fiber = allocation.Fiber * ratio,
        //             Sugar = allocation.Sugar * ratio
        //         },
        //         Portion = portion
        //     };
        // }

        // private PortionDTO CalculateNewPortion(NutritionDTO nutrition, MealAllocationDTO allocation, float ratio)
        // {
        //     float portionWeight = 100 * (allocation.Calories * ratio / Math.Max(nutrition.Calories, 1));

        //     return new PortionDTO
        //     {
        //         PortionWeight = portionWeight,
        //         MeasurementUnit = "g",
        //         PortionSize = "default"
        //     };
        // }

        // private (float mainDish, float sideDish, float dessert) GetMealRatios(MealType mealType, GoalType goalType, float activityLevel)
        // {
        //     return mealType switch
        //     {
        //         MealType.Breakfast => (1f, 0f, 0f),
        //         MealType.Lunch => (0.55f, 0.3f, 0.15f),
        //         MealType.Dinner => (goalType == GoalType.WeightLoss || activityLevel < 1.725) ? (0.65f, 0.35f, 0f) : (0.6f, 0.3f, 0.1f),
        //         MealType.Snack => (0.8f, 0.2f, 0f),
        //         _ => (1f, 0f, 0f)
        //     };
        // }

        // private FoodDTO123? SelectWeightedRandom(List<FoodDTO123> foodList, MealType mealType, DishType dishType, DishDTO? mainDish = null)
        // {
        //     var validFoods = foodList.Where(f => f.FoodType != null).ToList();

        //     if (dishType == DishType.SideDish && mainDish != null)
        //     {
        //         var allowedSideDishes = GetAllowedSideDishTypes(mainDish.Food?.FoodType ?? new List<FoodType>());

        //         validFoods = validFoods
        //             .Where(f => f.FoodType.Any(ft => allowedSideDishes.Contains(ft)))
        //             .ToList();
        //     }

        //     if (!validFoods.Any())
        //     {
        //         _logger.LogWarning($"No suitable {dishType} found for {mealType}.");
        //         return null;
        //     }

        //     return validFoods.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
        // }

        // public List<FoodType> GetAllowedSideDishTypes(List<FoodType>? mainDishTypes)
        // {
        //     if (mainDishTypes == null || !mainDishTypes.Any())
        //     {
        //         return new List<FoodType> { FoodType.Vegetables }; // Default safe value
        //     }

        //     var allowedTypes = new HashSet<FoodType>();

        //     foreach (var type in mainDishTypes)
        //     {
        //         var result = type switch
        //         {
        //             FoodType.Carbs => new List<FoodType> { FoodType.Protein, FoodType.Vegetables },
        //             FoodType.Protein => new List<FoodType> { FoodType.Vegetables },
        //             FoodType.Vegetables => new List<FoodType> { FoodType.Protein, FoodType.Carbs },
        //             _ => new List<FoodType> { FoodType.Vegetables }
        //         };

        //         allowedTypes.UnionWith(result);
        //     }

        //     return allowedTypes.ToList();
        // }
    }
}

public class MealPlanWithAllocationDTO
{
    public MealDTO Breakfast { get; set; } = new MealDTO();
    public MealDTO Lunch { get; set; } = new MealDTO();
    public MealDTO Dinner { get; set; } = new MealDTO();
    public MealDTO Snack { get; set; } = new MealDTO();
}

public class MealDTO
{
    public DishDTO MainDish { get; set; } = new DishDTO();
    public DishDTO SideDish { get; set; } = new DishDTO();
    public DishDTO Soup { get; set; } = new DishDTO();
    public DishDTO Dessert { get; set; } = new DishDTO();
    public DishDTO Snack { get; set; } = new DishDTO();
}

public class DishDTO
{
    public FoodDTO123? Food { get; set; }
    public MealAllocationDTO? Allocation { get; set; }
    public MealAllocationDTO? GoalAllocation { get; set; }
    public PortionDTO? Portion { get; set; }
}

public class FoodDTO123
{
    public Guid FoodId { get; set; }
    public string FoodName { get; set; } = string.Empty;
    public List<FoodType> FoodType { get; set; }
}

// public class PortionDTO
// {
//     public string PortionSize { get; set; } = "";
//     public float PortionWeight { get; set; }
//     public string MeasurementUnit { get; set; } = "g";
// }