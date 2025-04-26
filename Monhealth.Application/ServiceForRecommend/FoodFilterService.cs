// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Logging;
// using Monhealth.Application.Contracts.Persistence;
// using Monhealth.Application.Models.Paging;
// using Monhealth.Core.Enum;
// using Monhealth.Domain;
// using Monteith.Application.Contracts.Persistence;

// namespace Monhealth.Application.ServiceForRecommend
// {
//     public class FoodFilterService
//     {
//         private readonly IFoodRepository _foodRepository;
//         private readonly IAllergyRepository _allergyRepository;
//         private readonly IFoodAllergyRepository _foodAllergyRepository;
//         private readonly ILogger<FoodFilterService> _logger;
//         private readonly IUserAllergyRepository _userAllergyRepository;
//         private readonly IUserCategoryRepository _userCategoryRepository;

//         public FoodFilterService(
//             IFoodRepository foodRepository,
//             IFoodAllergyRepository foodAllergyRepository,
//             IAllergyRepository allergyRepository,
//             ILogger<FoodFilterService> logger,
//             IUserAllergyRepository userAllergyRepository,
//             IUserCategoryRepository userCategoryRepository)
//         {
//             _foodRepository = foodRepository;
//             _allergyRepository = allergyRepository;
//             _foodAllergyRepository = foodAllergyRepository;
//             _logger = logger;
//             _userAllergyRepository = userAllergyRepository;
//             _userCategoryRepository = userCategoryRepository;
//         }

//         public async Task<PageResult<FoodFilterDTO>> GetFilterFoodAsync(
//             Guid userId,
//             int pageNumber,
//             int pageSize,
//             List<string>? mealTypeFilter = null,
//             List<string>? dishTypeFilter = null)
//         {
//             if (pageNumber <= 0) pageNumber = 1;
//             if (pageSize <= 0) pageSize = 10;

//             // 🟢 Lấy danh sách dị ứng của User
//             var userAllergyIds = await _userAllergyRepository
//                 .GetUserAllergiesByUserId(userId);
//             var allergyIds = userAllergyIds?.Select(a => a.AllergyId).ToList() ?? new List<Guid>();

//             // 🟢 Lấy danh mục mà User đã chọn
//             // var userCategories = await _userCategoryRepository
//             //     .GetUserCategoryByUserId(userId);
//             // var categoryIds = userCategories?.Select(c => c.CategoryId).ToList() ?? new List<Guid>();

//             // if (!categoryIds.Any())
//             // {
//             //     _logger.LogInformation("User {UserId} did not select any categories. Returning empty result.", userId);
//             //     return new PageResult<FoodFilterDTO>
//             //     {
//             //         CurrentPage = pageNumber,
//             //         TotalPages = 0,
//             //         TotalItems = 0,
//             //         Items = new List<FoodFilterDTO>()
//             //     };
//             // }

//             // 🟢 Lọc danh sách thức ăn
//             var query = _foodRepository.GetAll()
//                 .Where(f => !f.FoodAllergies.Any(fa => allergyIds.Contains(fa.AllergyId))); // Loại bỏ món có dị ứng


//             // 🟢 Lọc theo MealType
//             // 🟢 Lọc theo MealType (Vì Food.MealType là List<MealType>)
//             var mealTypeEnums = mealTypeFilter?
//       .Select(m => Enum.TryParse<MealType>(m, true, out var result) ? result : (MealType?)null)
//       .Where(m => m.HasValue)
//       .Select(m => m!.Value)
//       .ToList();

//             var dishTypeEnums = dishTypeFilter?
//                 .Select(d => Enum.TryParse<DishType>(d, true, out var result) ? result : (DishType?)null)
//                 .Where(d => d.HasValue)
//                 .Select(d => d!.Value)
//                 .ToList();



//             // 🟢 Phân trang dữ liệu
//             var totalItems = await query.CountAsync();
//             var foods = await query
//                 .Skip((pageNumber - 1) * pageSize)
//                 .Take(pageSize)
//                 .ToListAsync();

//             _logger.LogInformation("User {UserId} has {TotalItems} foods after filtering.", userId, totalItems);

//             return BuildPageResult(foods, totalItems, pageNumber, pageSize);
//         }

//         private PageResult<FoodFilterDTO> BuildPageResult(List<Food> foods, int totalItems, int pageNumber, int pageSize)
//         {
//             if (foods == null || !foods.Any())
//             {
//                 _logger.LogWarning("Food list is empty.");
//                 return new PageResult<FoodFilterDTO>
//                 {
//                     CurrentPage = pageNumber,
//                     TotalPages = 0,
//                     TotalItems = 0,
//                     Items = new List<FoodFilterDTO>()
//                 };
//             }

//             var foodDTOs = foods.Select(food => new FoodFilterDTO
//             {
//                 FoodId = food.FoodId,
//                 FoodName = food.FoodName ?? string.Empty,
//                 Category = food.CategoryFoods.Select(fc => fc.Category.CategoryName).ToList(),
//                 MealType = food.MealType,
//                 DishType = food.DishType,
//             }).ToList();

//             return new PageResult<FoodFilterDTO>
//             {
//                 CurrentPage = pageNumber,
//                 TotalPages = (int)Math.Ceiling((double)totalItems / pageSize),
//                 TotalItems = totalItems,
//                 Items = foodDTOs
//             };
//         }
//     }
// }
