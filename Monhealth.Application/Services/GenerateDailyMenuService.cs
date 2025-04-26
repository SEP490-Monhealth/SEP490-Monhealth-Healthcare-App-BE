// using Microsoft.Extensions.Logging;
// using Monhealth.Application.Contracts.Persistence;
// using Monhealth.Application.Contracts.Services;
// using Monhealth.Application.Features.Metric.Commands.CreateMetric;
// using Monhealth.Core.Enum;
// using Monhealth.Domain;

// namespace Monhealth.Application.Services
// {
//     public class GenerateDailyMenuService : IGenerateDailyMenuService
//     {
//         private readonly IFoodRepository _foodRepository;
//         private readonly IMealFoodRepository _mealFoodRepository;
//         private readonly IPortionRepository _portionRepository;
//         private readonly IFoodPortionRepository _foodPortionRepository;
//         private readonly ILogger<GenerateDailyMenuService> _logger;
//         public GenerateDailyMenuService(IFoodRepository foodRepository, IMealFoodRepository mealFoodRepository,
//          IPortionRepository portionRepository, IFoodPortionRepository foodPortionRepository,
//          ILogger<GenerateDailyMenuService> logger)
//         {
//             _foodRepository = foodRepository;
//             _mealFoodRepository = mealFoodRepository;
//             _portionRepository = portionRepository;
//             _foodPortionRepository = foodPortionRepository;
//             _logger = logger;
//         }

//         public async Task<DailyMeal> GenerateDailyMealAsync(Guid userId, double tdee, string goal)
//         {
//             string[] categoryNames = { "Hải sản", "Rau củ", "Trái cây", "Thịt" };
//             double targetCalories = goal.ToLower() switch
//             {
//                 "lose" => tdee * 0.8,
//                 "gain" => tdee * 1.1,
//                 _ => tdee
//             };

//             // Phân bổ calo cho các bữa
//             double breakfastCalories = targetCalories * 0.3;
//             double lunchCalories = targetCalories * 0.35;
//             double dinnerCalories = targetCalories * 0.25;
//             double snackCalories = targetCalories * 0.1;

//             // Tỷ lệ macro theo mục tiêu
//             (double proteinRatio, double carbsRatio, double fatRatio) = goal.ToLower() switch
//             {
//                 "lose" => (0.4, 0.35, 0.25),
//                 "gain" => (0.3, 0.5, 0.2),
//                 _ => (0.3, 0.4, 0.3)
//             };




//             //get list food
//             var foodLists = await _foodRepository.GetFoodsByCategoryNameAsync(categoryNames);

//             Guid dailyMealId = Guid.NewGuid();
//             //breakfast 

//             var breakfast = await CreateBalancedMeal(MealType.Breakfast, breakfastCalories, proteinRatio, carbsRatio, fatRatio, foodLists, userId, dailyMealId);
//             var lunch = await CreateBalancedMeal(MealType.Lunch, lunchCalories, proteinRatio, carbsRatio, fatRatio, foodLists, userId, dailyMealId);
//             var dinner = await CreateBalancedMeal(MealType.Dinner, dinnerCalories, proteinRatio, carbsRatio, fatRatio, foodLists, userId, dailyMealId);

//             // Tổng hợp dinh dưỡng
//             double totalCalories = breakfast.TotalCalories + lunch.TotalCalories + dinner.TotalCalories;
//             double totalProteins = breakfast.TotalProteins + lunch.TotalProteins + dinner.TotalProteins;
//             double totalCarbs = breakfast.TotalCarbs + lunch.TotalCarbs + dinner.TotalCarbs;
//             double totalFats = breakfast.TotalFats + lunch.TotalFats + dinner.TotalFats;
//             double totalFibers = breakfast.TotalFibers + lunch.TotalFibers + dinner.TotalFibers;
//             double totalSugars = breakfast.TotalSugars + lunch.TotalSugars + dinner.TotalSugars;
//             // Trả về thực đơn hàng ngày
//             return new DailyMeal
//             {
//                 DailyMealId = dailyMealId,
//                 UserId = userId,
//                 TotalCalories = (float)totalCalories,
//                 TotalCarbs = (float)totalCarbs,
//                 TotalFats = (float)totalFats,
//                 TotalProteins = (float)totalProteins,
//                 TotalFibers = (float)totalFibers,
//                 TotalSugars = (float)totalSugars,

//                 Meals = new List<Meal> { breakfast.Meal, lunch.Meal, dinner.Meal },
//                 CreatedAt = DateTime.Now,
//                 UpdatedAt = DateTime.Now
//             };
//         }
//         private double CalculatePortionMultiplier(double requiredValue, double nutritionValue)
//         {
//             if (nutritionValue <= 0) return double.MaxValue; // Không có giá trị dinh dưỡng
//             return requiredValue / nutritionValue;
//         }
//         private async Task<MealWithNutrition> CreateBalancedMeal(MealType mealType, double targetCalories, double proteinRatio, double carbsRatio, double fatRatio, List<Food> foodList, Guid userId, Guid dailyMealId)
//         {
//             Guid mealId = Guid.NewGuid();
//             var selectedFoods = new List<MealFood>();
//             double totalCalories = 0, totalProteins = 0, totalCarbs = 0, totalFats = 0, totalFibers = 0, totalSugars = 0;

//             // Nhu cầu dinh dưỡng cho 1 bữa ăn 
//             double targetProtein = Math.Round(targetCalories * proteinRatio / 4);
//             double targetCarbs = Math.Round(targetCalories * carbsRatio / 4);
//             double targetFat = Math.Round(targetCalories * fatRatio / 9);

//             // 1. Chọn thực phẩm giàu protein
//             var proteinFood = foodList
//                 .OrderByDescending(f => f.Nutrition.Protein)
//                 .FirstOrDefault();

//             if (proteinFood != null)
//             {
//                 var nutrition = proteinFood.Nutrition;
//                 double portionMultiplier = Math.Round(
//                     CalculatePortionMultiplier(targetProtein, nutrition.Protein), 2);

//                 //dinh lượng của mon an cần 
//                 double foodAmount = Math.Round(portionMultiplier * 100); //số g

//                 // Tính dinh dưỡng theo khẩu phần
//                 double foodCalories = Math.Round(nutrition.Calories * portionMultiplier);
//                 double foodProteins = Math.Round(nutrition.Protein * portionMultiplier);
//                 double foodCarbs = Math.Round(nutrition.Carbs * portionMultiplier);
//                 double foodFats = Math.Round(nutrition.Fat * portionMultiplier);
//                 double foodFiber = Math.Round(nutrition.Fiber * portionMultiplier);
//                 double foodSugar = Math.Round(nutrition.Sugar * portionMultiplier);
//                 var mealFood = new MealFood
//                 {
//                     MealId = mealId,
//                     FoodId = proteinFood.FoodId,
//                     Quantity = 1,
//                     CreatedAt = DateTime.Now,
//                     UpdatedAt = DateTime.Now,
//                 };

//                 _mealFoodRepository.Add(mealFood);
//                 var portion = await _portionRepository.GetPortionAsync("g", "", (float)foodAmount);
//                 if (portion == null)
//                 {
//                     var newPortion = new Portion
//                     {
//                         PortionId = new Guid(),
//                         MeasurementUnit = "g",
//                         PortionSize = "",
//                         PortionWeight = (float)foodAmount,
//                         CreatedAt = DateTime.Now,
//                         UpdatedAt = DateTime.Now
//                     };
//                     _portionRepository.Add(newPortion);
//                     portion = newPortion;
//                 }
//                 _foodPortionRepository.Add(new FoodPortion
//                 {
//                     FoodId = proteinFood.FoodId,
//                     PortionId = portion.PortionId
//                 });

//                 // Cập nhật tổng dinh dưỡng
//                 totalCalories += foodCalories;
//                 totalProteins += foodProteins;
//                 totalCarbs += foodCarbs;
//                 totalFats += foodFats;
//                 totalFibers += foodFiber;
//                 totalSugars += foodSugar;
//                 // Loại bỏ thức ăn này khỏi danh sách
//                 foodList.Remove(proteinFood);
//             }

//             // 2. Chọn thực phẩm giàu carbs
//             var carbsFood = foodList
//                 .OrderByDescending(f => f.Nutrition.Carbs)
//                 .FirstOrDefault();

//             if (carbsFood != null)
//             {
//                 var nutrition = carbsFood.Nutrition;
//                 double portionMultiplier = Math.Round(
//                     CalculatePortionMultiplier(targetCarbs, nutrition.Carbs), 2);

//                 //dinh lượng của mon an cần 
//                 double foodAmount = Math.Round(portionMultiplier * 100); //số g

//                 // Tính dinh dưỡng theo khẩu phần
//                 double foodCalories = Math.Round(nutrition.Calories * portionMultiplier);
//                 double foodProteins = Math.Round(nutrition.Protein * portionMultiplier);
//                 double foodCarbs = Math.Round(nutrition.Carbs * portionMultiplier);
//                 double foodFats = Math.Round(nutrition.Fat * portionMultiplier);
//                 double foodFiber = Math.Round(nutrition.Fiber * portionMultiplier);
//                 double foodSugar = Math.Round(nutrition.Sugar * portionMultiplier);
//                 var mealFood = new MealFood
//                 {
//                     MealId = mealId,
//                     FoodId = carbsFood.FoodId,
//                     Quantity = 1,
//                     CreatedAt = DateTime.Now,
//                     UpdatedAt = DateTime.Now,
//                 };

//                 _mealFoodRepository.Add(mealFood);
//                 var portion = await _portionRepository.GetPortionAsync("g", "", (float)foodAmount);
//                 if (portion == null)
//                 {
//                     var newPortion = new Portion
//                     {
//                         PortionId = new Guid(),
//                         MeasurementUnit = "g",
//                         PortionSize = "",
//                         PortionWeight = (float)foodAmount,
//                         CreatedAt = DateTime.Now,
//                         UpdatedAt = DateTime.Now
//                     };
//                     _portionRepository.Add(newPortion);
//                     portion = newPortion;

//                 }
//                 _foodPortionRepository.Add(new FoodPortion
//                 {
//                     FoodId = carbsFood.FoodId,
//                     PortionId = portion.PortionId
//                 });

//                 // Cập nhật tổng dinh dưỡng
//                 totalCalories += foodCalories;
//                 totalProteins += foodProteins;
//                 totalCarbs += foodCarbs;
//                 totalFats += foodFats;
//                 totalFibers += foodFiber;
//                 totalSugars += foodSugar;
//                 // Loại bỏ thức ăn này khỏi danh sách
//                 foodList.Remove(carbsFood);
//             }

//             //fat food 
//             // 3. Chọn thực phẩm giàu fat
//             var fatFood = foodList
//                 .OrderByDescending(f => f.Nutrition.UnsaturatedFat)
//                 .FirstOrDefault();

//             if (fatFood != null)
//             {
//                 var nutrition = fatFood.Nutrition;
//                 double portionMultiplier = Math.Round(
//                     CalculatePortionMultiplier(targetFat, nutrition.Fat), 2);

//                 //dinh lượng của mon an cần 
//                 double foodAmount = Math.Round(portionMultiplier * 100); //số g

//                 // Tính dinh dưỡng theo khẩu phần
//                 double foodCalories = Math.Round(nutrition.Calories * portionMultiplier);
//                 double foodProteins = Math.Round(nutrition.Protein * portionMultiplier);
//                 double foodCarbs = Math.Round(nutrition.Carbs * portionMultiplier);
//                 double foodFats = Math.Round(nutrition.Fat * portionMultiplier);
//                 double foodFiber = Math.Round(nutrition.Fiber * portionMultiplier);
//                 double foodSugar = Math.Round(nutrition.Sugar * portionMultiplier);
//                 var mealFood = new MealFood
//                 {
//                     MealId = mealId,
//                     FoodId = fatFood.FoodId,
//                     Quantity = 1,
//                     CreatedAt = DateTime.Now,
//                     UpdatedAt = DateTime.Now,
//                 };

//                 _mealFoodRepository.Add(mealFood);
//                 var portion = await _portionRepository.GetPortionAsync("g", "", (float)foodAmount);
//                 if (portion == null)
//                 {
//                     var newPortion = new Portion
//                     {
//                         PortionId = new Guid(),
//                         MeasurementUnit = "g",
//                         PortionSize = "",
//                         PortionWeight = (float)foodAmount,
//                         CreatedAt = DateTime.Now,
//                         UpdatedAt = DateTime.Now
//                     };
//                     _portionRepository.Add(newPortion);
//                     portion = newPortion;

//                 }
//                 _foodPortionRepository.Add(new FoodPortion
//                 {
//                     FoodId = fatFood.FoodId,
//                     PortionId = portion.PortionId
//                 });

//                 // Cập nhật tổng dinh dưỡng
//                 totalCalories += foodCalories;
//                 totalProteins += foodProteins;
//                 totalCarbs += foodCarbs;
//                 totalFats += foodFats;
//                 totalFibers += foodFiber;
//                 totalSugars += foodSugar;
//                 // Loại bỏ thức ăn này khỏi danh sách
//                 foodList.Remove(fatFood);
//             }
//             var meal = new Meal
//             {
//                 MealId = mealId,
//                 DailyMealId = dailyMealId,
//                 UserId = userId,
//                 MealType = mealType,
//                 CreatedAt = DateTime.Now,
//                 UpdatedAt = DateTime.Now,
//             };

//             return new MealWithNutrition
//             {
//                 Meal = meal,
//                 TotalCalories = totalCalories,
//                 TotalProteins = totalProteins,
//                 TotalCarbs = totalCarbs,
//                 TotalFats = totalFats,
//                 TotalFibers = totalFibers,
//                 TotalSugars = totalSugars,
//             };

//         }
//         private List<Food> SortFoodByProtein(List<Food> foodList)
//         {
//             return foodList.OrderByDescending(f => f.Nutrition.Protein).ToList();
//         }
//         private List<Food> SortFoodByCarb(List<Food> foodList)
//         {
//             return foodList.OrderByDescending(f => f.Nutrition.Carbs).ToList();
//         }
//         private List<Food> SortFoodByFat(List<Food> foodList)
//         {
//             return foodList.OrderByDescending(f => f.Nutrition.UnsaturatedFat).ToList();
//         }
//     }
// }
