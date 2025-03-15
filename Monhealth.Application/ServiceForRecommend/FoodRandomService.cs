// using Microsoft.Extensions.Logging;
// using Monhealth.Application.Contracts.Persistence;
// using Monhealth.Application.Features.Food.AddFood;
// using Monhealth.Application.ServiceForRecommend.DTO;
// using Monhealth.Application.Services;
// using Monhealth.Core.Enum;
// using Monhealth.Domain;
// using Monhealth.Domain.Enum;

// namespace Monhealth.Application.ServiceForRecommend
// {
//     public class FoodRandomService
//     {
//         private readonly IFoodRepository _foodRepository;
//         private readonly FoodFilterService _foodFilterService;
//         private readonly GoalService _goalService;
//         private readonly ILogger<FoodRandomService> _logger;

//         public FoodRandomService(
//             IFoodRepository foodRepository,
//             FoodFilterService foodFilterService,
//             GoalService goalService,
//             ILogger<FoodRandomService> logger)
//         {
//             _foodRepository = foodRepository;
//             _foodFilterService = foodFilterService;
//             _goalService = goalService;
//             _logger = logger;
//         }

//         public async Task<MealPlanWithAllocationDTO> GetMealPlanWithAllocationAsync(Guid userId, GoalType goalType, float activityLevel)
//         {
//             var mealAllocations = await _goalService.GetMealAllocationByUserIdAsync(userId);

//             if (mealAllocations == null || !mealAllocations.Any())
//             {
//                 _logger.LogWarning($"⚠️ Không tìm thấy goal allocation cho user {userId}.");
//                 return new MealPlanWithAllocationDTO(); // Trả về rỗng
//             }

//             _logger.LogInformation($"✅ Tạo Meal Plan cho user {userId} với {mealAllocations.Count} loại bữa ăn.");

//             var breakfast = await GenerateMealAsync(MealType.Breakfast, mealAllocations["breakfast"], userId, goalType, activityLevel);
//             var lunch = await GenerateMealAsync(MealType.Lunch, mealAllocations["lunch"], userId, goalType, activityLevel);
//             var dinner = await GenerateMealAsync(MealType.Dinner, mealAllocations["dinner"], userId, goalType, activityLevel);
//             var snack = await GenerateMealAsync(MealType.Snack, mealAllocations["snack"], userId, goalType, activityLevel);

//             return new MealPlanWithAllocationDTO
//             {
//                 Breakfast = breakfast,
//                 Lunch = lunch,
//                 Dinner = dinner,
//                 Snack = snack
//             };
//         }

//         private async Task<MealDTO> GenerateMealAsync(MealType mealType, MealAllocationDTO allocation, Guid userId, GoalType goalType, float activityLevel)
//         {
//             _logger.LogInformation($"🔍 Bắt đầu tạo {mealType} cho user {userId}...");

//             var (mainDishRatio, sideDishRatio, dessertRatio) = GetMealRatios(mealType, goalType, activityLevel);

//             var mainDish = await GetRandomDishWithPortionAsync(mealType, DishType.MainDish, userId, allocation, mainDishRatio);
//             if (mainDish == null)
//             {
//                 _logger.LogWarning($"⚠️ Không tìm thấy món chính cho {mealType}.");
//             }

//             DishDTO? sideDish = null;
//             if (sideDishRatio > 0)
//             {
//                 sideDish = await GetRandomDishWithPortionAsync(mealType, DishType.SideDish, userId, allocation, sideDishRatio, mainDish);
//             }

//             DishDTO? dessert = null;
//             if (dessertRatio > 0)
//             {
//                 dessert = await GetRandomDishWithPortionAsync(mealType, DishType.Dessert, userId, allocation, dessertRatio);
//             }

//             return new MealDTO
//             {
//                 MainDish = mainDish,
//                 SideDish = sideDish,
//                 Dessert = dessert
//             };
//         }
//         private (float mainDish, float sideDish, float dessert) GetMealRatios(MealType mealType, GoalType goalType, float activityLevel)
//         {
//             return mealType switch
//             {
//                 MealType.Breakfast => (1f, 0f, 0f), // 100% món chính
//                 MealType.Lunch => (0.55f, 0.3f, 0.15f), // 55% main, 30% side, 15% dessert
//                 MealType.Dinner => (goalType == GoalType.WeightLoss || activityLevel < 1.725)
//                     ? (0.65f, 0.35f, 0f) // Nếu giảm cân hoặc ít vận động → không có dessert
//                     : (0.6f, 0.3f, 0.1f), // Nếu bình thường → 60% main, 30% side, 10% dessert
//                 MealType.Snack => (0.8f, 0.2f, 0f), // Snack: 80% món chính, 20% side
//                 _ => (1f, 0f, 0f) // Mặc định chỉ có món chính
//             };
//         }


//         private async Task<DishDTO?> GetRandomDishWithPortionAsync(
//             MealType mealType, DishType dishType, Guid userId,
//             MealAllocationDTO allocation, float ratio, DishDTO? mainDish = null)
//         {
//             _logger.LogInformation($"🔍 Đang tìm món ăn {dishType} cho {mealType}...");

//             var mealTypeList = new List<MealType> { MealType.Breakfast, MealType.Lunch  , MealType.Dinner , MealType.Snack};
//             var dishTypeList = new List<DishType> { DishType.MainDish, DishType.SideDish , DishType.Soup , DishType.Dessert , DishType.Drink };

//             // ✅ Chuyển `List<MealType>` thành `List<string>`
//             var mealTypeStringList = mealTypeList.Select(mt => mt.ToString()).ToList();
//             var dishTypeStringList = dishTypeList.Select(dt => dt.ToString()).ToList();

//             var filteredFoods = await _foodFilterService.GetFilterFoodAsync(
//                 userId, 1, 100,
//                 mealTypeStringList,  // ✅ Đã chuyển thành `List<string>`
//                 dishTypeStringList   // ✅ Đã chuyển thành `List<string>`
//             );

//             if (filteredFoods == null || !filteredFoods.Items.Any())
//             {
//                 _logger.LogWarning($"⚠️ Không có món ăn nào phù hợp với {mealType} - {dishType}.");
//                 return null;
//             }

//             _logger.LogInformation($"✅ Số món ăn phù hợp: {filteredFoods.Items.Count()}");

//             var foodList = filteredFoods.Items.Select(f => new FoodDTO123
//             {
//                 FoodId = f.FoodId,
//                 FoodName = f.FoodName,
//                 FoodType = f.FoodType
//             }).ToList();

//             var selectedFood = SelectWeightedRandom(foodList, mealType, dishType, mainDish);
//             if (selectedFood == null)
//             {
//                 _logger.LogWarning($"⚠️ Không tìm thấy món {dishType} phù hợp cho {mealType}.");
//                 return null;
//             }

//             return new DishDTO { Food = selectedFood };
//         }

//         private FoodDTO123? SelectWeightedRandom(List<FoodDTO123> foodList, MealType mealType, DishType dishType, DishDTO? mainDish = null)
//         {
//             var validFoods = foodList.Where(f => f.FoodType != null).ToList();

//             if (dishType == DishType.SideDish && mainDish != null)
//             {
//                 var allowedSideDishes = GetAllowedSideDishTypes(mainDish.Food?.FoodType ?? new List<FoodType>());

//                 validFoods = validFoods
//                     .Where(f => f.FoodType.Any(ft => allowedSideDishes.Contains(ft)))
//                     .ToList();
//             }

//             if (!validFoods.Any())
//             {
//                 _logger.LogWarning($"No suitable {dishType} found for {mealType}.");
//                 return null;
//             }

//             return validFoods.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
//         }

//         public List<FoodType> GetAllowedSideDishTypes(List<FoodType>? mainDishTypes)
//         {
//             if (mainDishTypes == null || !mainDishTypes.Any())
//             {
//                 return new List<FoodType> { FoodType.Vegetables };
//             }

//             var allowedTypes = new HashSet<FoodType>();

//             foreach (var type in mainDishTypes)
//             {
//                 var result = type switch
//                 {
//                     FoodType.Carbs => new List<FoodType> { FoodType.Protein, FoodType.Vegetables },
//                     FoodType.Protein => new List<FoodType> { FoodType.Vegetables },
//                     FoodType.Vegetables => new List<FoodType> { FoodType.Protein, FoodType.Carbs },
//                     _ => new List<FoodType> { FoodType.Vegetables }
//                 };

//                 allowedTypes.UnionWith(result);
//             }

//             return allowedTypes.ToList();
//         }
//     }
// }


// public class MealPlanWithAllocationDTO
// {
//     public MealDTO Breakfast { get; set; } = new MealDTO();
//     public MealDTO Lunch { get; set; } = new MealDTO();
//     public MealDTO Dinner { get; set; } = new MealDTO();
//     public MealDTO Snack { get; set; } = new MealDTO();
// }

// public class MealDTO
// {
//     public DishDTO MainDish { get; set; } = new DishDTO();
//     public DishDTO SideDish { get; set; } = new DishDTO();
//     public DishDTO Soup { get; set; } = new DishDTO();
//     public DishDTO Dessert { get; set; } = new DishDTO();
//     public DishDTO Snack { get; set; } = new DishDTO();
// }

// public class DishDTO
// {
//     public FoodDTO123? Food { get; set; }
//     public MealAllocationDTO? Allocation { get; set; }
//     public MealAllocationDTO? GoalAllocation { get; set; }
//     public PortionDTO? Portion { get; set; }
// }

// public class FoodDTO123
// {
//     public Guid FoodId { get; set; }
//     public string FoodName { get; set; } = string.Empty;
//     public List<FoodType> FoodType { get; set; }
// }

// // public class PortionDTO
// // {
// //     public string PortionSize { get; set; } = "";
// //     public float PortionWeight { get; set; }
// //     public string MeasurementUnit { get; set; } = "g";
// // }