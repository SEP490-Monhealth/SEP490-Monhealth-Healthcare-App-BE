// using MediatR;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Logging;
// using Monhealth.Application.Contracts.Persistence;
// using Monhealth.Core.Enum;
// using Monhealth.Domain;
// namespace Monhealth.Application
// {
//     public class FilterFoodListQueryHandler : IRequestHandler<FilterFoodListQuery, int>
//     {
//         private readonly ILogger<FilterFoodListQuery> _logger;
//         private readonly IUserAllergyRepository _userAllergyRepository;
//         private readonly IFoodRepository _foodRepository;
//         public FilterFoodListQueryHandler(ILogger<FilterFoodListQuery> logger,
//         IUserAllergyRepository userAllergyRepository,
//         IFoodRepository foodRepository)
//         {
//             _logger = logger;
//             _userAllergyRepository = userAllergyRepository;
//             _foodRepository = foodRepository;
//         }

//         public async Task<int> Handle(FilterFoodListQuery request, CancellationToken cancellationToken)
//         {
//             var userAllergyIds = await _userAllergyRepository
//                 .GetUserAllergiesByUserId(request.UserId);
//             var allergyIds = userAllergyIds?.Select(a => a.AllergyId).ToList() ?? new List<Guid>();

//             var mealTypesToFilter = new List<MealType> { MealType.Breakfast, MealType.Lunch, MealType.Dinner };
//             var dishTypesToFilter = new List<DishType> { DishType.MainDish, DishType.SideDish };

//             // Lấy tất cả món ăn không có dị ứng
//             var allofFood = _foodRepository.GetAll()
//                 .Where(f =>
//                     (mealTypesToFilter == null || !mealTypesToFilter.Any() || f.MealType.Any(m => mealTypesToFilter.Contains(m))) &&
//                     (dishTypesToFilter == null || !dishTypesToFilter.Any() || f.DishType.Any(d => dishTypesToFilter.Contains(d)))
//                 );

//             if (!allergyIds.Any())
//             {
//                 var foodCount = await allofFood.CountAsync();
//                 _logger.LogInformation($"Người dùng không bị dị ứng với món ăn nào, trả về tất cả món ăn, số món ăn hiện có: {foodCount}");
//                 return foodCount;
//             }

//             // Lọc các món ăn không chứa dị ứng và lọc theo MealType và DishType
//             var query = _foodRepository.GetAll()
//                 .Where(f => !f.FoodAllergies.Any(fa => allergyIds.Contains(fa.AllergyId)) &&
//                             (mealTypesToFilter == null || !mealTypesToFilter.Any() || f.MealType.Any(m => mealTypesToFilter.Contains(m))) &&
//                             (dishTypesToFilter == null || !dishTypesToFilter.Any() || f.DishType.Any(d => dishTypesToFilter.Contains(d)))
//                 );

//             var foodList = await query.ToListAsync();
//             if (!foodList.Any())
//             {
//                 _logger.LogInformation("Không có món ăn nào phù hợp với yêu cầu sau khi lọc dị ứng.");
//             }
//             else
//             {
//                 _logger.LogInformation($"Danh sách thức ăn còn lại của người dùng sau khi lọc dị ứng là: {foodList.Count} món ăn");
//             }

//             // Khai báo các biến dinh dưỡng
//             float carbsRatio = 0;
//             float proteinRatio = 0;
//             float fatRatio = 0;
//             float totalCalories = 0;

//             List<Food> filteredFoodList = new List<Food>();

//             if (allofFood != null)
//             {
//                 // Lấy giá trị dinh dưỡng của tất cả món ăn
//                 foreach (var food in allofFood)
//                 {
//                     var carbs = food.Nutrition.Carbs;
//                     var protein = food.Nutrition.Protein;
//                     var fat = food.Nutrition.Fat;

//                     // Tính tổng calories
//                     totalCalories = protein * 4 + carbs * 4 + fat * 9;
//                     proteinRatio = protein * 4 / totalCalories;
//                     fatRatio = fat * 9 / totalCalories;
//                     carbsRatio = carbs * 4 / totalCalories;

//                     // Lọc món ăn dựa trên tỷ lệ dinh dưỡng và điều kiện phân loại
//                     if (carbsRatio > 0.5f) // Món ăn thuộc nhóm Carbs
//                     {
//                         filteredFoodList.Add(food);
//                     }
//                     else if (proteinRatio > 0.5f) // Món ăn thuộc nhóm Protein
//                     {
//                         filteredFoodList.Add(food);
//                     }
//                     else if (fatRatio > 0.5f) // Món ăn thuộc nhóm Fat
//                     {
//                         filteredFoodList.Add(food);
//                     }
//                     else if (carbsRatio >= 0.3f && carbsRatio <= 0.4f && proteinRatio >= 0.3f && proteinRatio <= 0.4f) // Món ăn thuộc nhóm Balanced
//                     {
//                         filteredFoodList.Add(food);
//                     }
//                     else // Món ăn thuộc nhóm Mixed
//                     {
//                         filteredFoodList.Add(food);
//                     }
//                 }
//             }
//             else if (foodList != null)
//             {
//                 // Lọc món ăn sau khi loại bỏ dị ứng
//                 foreach (var food in foodList)
//                 {
//                     var carbsOfAllergies = food.Nutrition.Carbs;
//                     var proteinOfAllergies = food.Nutrition.Protein;
//                     var fatOfAllergies = food.Nutrition.Fat;

//                     // Tính tổng calories khi lọc dị ứng
//                     totalCalories = proteinOfAllergies * 4 + carbsOfAllergies * 4 + fatOfAllergies * 9;
//                     proteinRatio = proteinOfAllergies * 4 / totalCalories;
//                     carbsOfAllergies = carbsOfAllergies * 4 / totalCalories;
//                     fatOfAllergies = fatOfAllergies * 9 / totalCalories;

//                     // Lọc theo tỷ lệ dinh dưỡng
//                     if (carbsOfAllergies > 0.5f) // Món ăn thuộc nhóm Carbs
//                     {
//                         filteredFoodList.Add(food);
//                     }
//                     else if (proteinRatio > 0.5f) // Món ăn thuộc nhóm Protein
//                     {
//                         filteredFoodList.Add(food);
//                     }
//                     else if (fatOfAllergies > 0.5f) // Món ăn thuộc nhóm Fat
//                     {
//                         filteredFoodList.Add(food);
//                     }
//                 }
//             }

//             // Trả về số lượng món ăn sau khi lọc
//             return filteredFoodList.Count;
//         }


//     }
// }