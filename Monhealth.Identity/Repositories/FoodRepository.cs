using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;


namespace Monhealth.Identity.Repositories
{

    public class FoodRepository : GenericRepository<Food, Guid>, IFoodRepository
    {
        public FoodRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public IQueryable<Food> GetAll()
        {

            return _context.Foods.AsQueryable();
        }

        public async Task<PaginatedResult<Food>> GetAllFoodAsync(int page, int limit, string? search, bool? status, string categoryName, bool? popular, bool? isPublic)
        {
            search = search?.Trim();
            IQueryable<Food> query = _context.Foods.Include(f => f.CategoryFoods).
            ThenInclude(f => f.Category).
            Include(f => f.Nutrition).
            Include(f => f.FoodPortions)
            .ThenInclude(f => f.Portion)
            .Include(f => f.FoodAllergies)
            .ThenInclude(f => f.Allergy).AsQueryable()
            .Include(f => f.DishTypeFoods).ThenInclude(f => f.DishType);

            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.FoodName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                    s.FoodId.ToString().ToLower().Contains(search.ToLower()) ||
                    s.UserId.ToString().ToLower().Contains(search.ToLower()) ||
                    s.AppUser.PhoneNumber.ToString().ToLower().Contains(search.ToLower()) ||
                    s.AppUser.Email.ToString().ToLower().Contains(search.ToLower()) ||
                    EF.Functions.Collate(s.AppUser.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()));
            }
            if (!string.IsNullOrEmpty(categoryName))
                query = query.Where(f => f.CategoryFoods.
                Any(x => x.Category.CategoryName == categoryName));

            if (isPublic.HasValue)
            {
                query = query.Where(s => s.IsPublic == isPublic.Value);
            }
            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }

            query = query.OrderByDescending(f => f.CreatedAt);         
            int totalItems = await query.CountAsync();

            if (popular.HasValue && popular.Value)
            {
                query = query.OrderByDescending(s => s.Views);
            }
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Food>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<Food>> GetByIdsAsync(IEnumerable<Guid> foodIds)
        {
            return await _context.Foods
                         .Include(f => f.FoodPortions)
                         .Where(f => foodIds.Contains(f.FoodId))
                         .ToListAsync();
        }

        public async Task<Food> GetByIdWithCategoriesAsync(Guid foodId)
        {
            return await _context.Foods.Include(f => f.CategoryFoods)
        .ThenInclude(f => f.Category)
        .Include(f => f.FoodPortions)
        .FirstOrDefaultAsync(f => f.FoodId == foodId) ?? null!;
        }

        public async Task<List<Food>> GetFoodByCategoryName(string categoryName)
        {
            return await _context.Foods.Where(f => f.CategoryFoods.Any(x => x.Category.CategoryName == categoryName))
            .ToListAsync();
        }
        public async Task<Food> GetFoodByIdAsync(Guid foodId)
        {
            // Fetch the food item along with its related data
            var food = await _context.Foods
             .Include(f => f.DishTypeFoods)
                .ThenInclude(fd => fd.DishType)
                .Include(fc => fc.CategoryFoods)
                    .ThenInclude(fc => fc.Category)
                .Include(fc => fc.Nutrition)
                .Include(fc => fc.FoodPortions)
                    .ThenInclude(fc => fc.Portion)
                .Include(fc => fc.FoodAllergies)
                    .ThenInclude(fc => fc.Allergy)
                .Include(fc => fc.DishTypeFoods)
                    .ThenInclude(dtf => dtf.DishType)
                .FirstOrDefaultAsync(f => f.FoodId == foodId);

            // If the food item exists, increment its Views count
            if (food != null)
            {
                await _context.Database.ExecuteSqlRawAsync(
       "UPDATE Foods SET Views = Views + 1 WHERE FoodId = {0}", foodId);
            }

            return food;
        }

        public async Task<Food> GetFoodByNameAsync(string foodName)
        {
            return await _context.Foods.FirstOrDefaultAsync(f => f.FoodName == foodName);
        }

        public async Task<List<Food>> GetFoodByUserHasNoAllergiesAsync(Guid userId)
        {
            // Lấy danh sách tất cả các thức ăn với các thông tin liên quan
            var foodList = await _context.Foods
                 .Include(fc => fc.CategoryFoods)
                    .ThenInclude(fc => fc.Category)
                .Include(fc => fc.Nutrition)
                .Include(fc => fc.FoodPortions)
                    .ThenInclude(fc => fc.Portion)
                .Include(fc => fc.FoodAllergies)
                    .ThenInclude(fc => fc.Allergy)
                .Include(fc => fc.DishTypeFoods)
                    .ThenInclude(dtf => dtf.DishType)
                .ToListAsync();

            // Lấy danh sách các dị ứng của người dùng
            var userAllergies = await _context.UserAllergies
                .Where(ua => ua.UserId == userId)
                .Select(ua => ua.AllergyId)
                .ToListAsync();

            // Nếu người dùng không có dị ứng nào, trả về tất cả các thức ăn
            if (userAllergies.Count == 0)
            {
                return foodList;
            }

            // Lọc ra các thức ăn mà người dùng không bị dị ứng
            var safeFoods = foodList
                .Where(f => !f.FoodAllergies.Any(fa => userAllergies.Contains(fa.AllergyId)))
                .ToList();

            return safeFoods;
        }

        public async Task<PaginatedResult<Food>> GetFoodByUserId(int page, int limit, Guid userId)
        {
            // Truy vấn dữ liệu cơ bản
            IQueryable<Food> query = _context.Foods
                .Where(f => f.UserId == userId)
                .Include(fc => fc.CategoryFoods)
                    .ThenInclude(fc => fc.Category)
                .Include(fc => fc.Nutrition)
                .Include(fc => fc.FoodPortions)
                    .ThenInclude(fc => fc.Portion)
                .Include(fc => fc.FoodAllergies)
                    .ThenInclude(fc => fc.Allergy)
                .Include(fc => fc.DishTypeFoods)
                    .ThenInclude(dtf => dtf.DishType);

            // Tính tổng số lượng bản ghi
            int totalItems = await query.CountAsync();

            // Áp dụng phân trang
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            // Trả về kết quả phân trang
            return new PaginatedResult<Food>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<Food>> GetFoodsByCategoryNameAsync(string[] categoryNames)
        {
            return await _context.Foods.Where(f => f.CategoryFoods.All(x => categoryNames.Contains(x.Category.CategoryName))).
               Include(f => f.Nutrition).Include(f => f.FoodPortions).ThenInclude(f => f.Portion).ToListAsync();
        }


        public async Task<Nutrition?> GetNutritionByFoodIdAsync(Guid foodId)
        {
            return await _context.Nutrition
          .Where(n => n.FoodId == foodId)
          .FirstOrDefaultAsync();
        }
        public async Task<List<Nutrition>> GetNutritionByFoodIdsAsync(List<Guid> foodIds)
        {
            if (foodIds == null || !foodIds.Any())
            {
                return new List<Nutrition>();
            }
            return await _context.Nutrition
                .Where(n => n.FoodId.HasValue && foodIds.Contains(n.FoodId.Value))
                .ToListAsync();

        }

        public async Task<PaginatedResult<Food>> GetPaginatedFoodsAsync(int skip, int take)
        {
            var query = _context.Foods.Include(f => f.CategoryFoods)
            .ThenInclude(fc => fc.Category).AsQueryable();

            var totalCount = await query.CountAsync();
            var items = await query
                .OrderBy(f => f.FoodName)
                .Skip(skip)
                .Take(take)
                .ToListAsync();



            return new PaginatedResult<Food>
            {
                Items = items,
                TotalCount = totalCount
            };
        }

        public async Task<PaginatedResult<Food>> GetPaginatedFoodsByCategoryIdsAsync(IEnumerable<Guid> categoryIds, int skip, int take)
        {
            var query = _context.Foods
                .Include(f => f.CategoryFoods)
                    .ThenInclude(cf => cf.Category)
                .Where(f => f.CategoryFoods.Any(cf => categoryIds.Contains(cf.CategoryId))); // Filter using CategoryFoods

            var totalCount = await query.CountAsync();
            var items = await query
                .OrderBy(f => f.FoodName) // Order by food name
                .Skip(skip)
                .Take(take)
                .ToListAsync();

            return new PaginatedResult<Food>
            {
                Items = items,
                TotalCount = totalCount
            };
        }

        public async Task<(Food?, Food?, Food?, Food?)> GetRandomProteinAndCarbFood(List<Guid> allergiesIds)
        {
            Random random = new Random();
            int foodNumberOfMeal = random.Next(2);
            Food? proteinFood = null!;
            Food? carbFood = null!;
            Food? balanceFood = null!;
            // Lấy tất cả dữ liệu từ cơ sở dữ liệu
            var allFoods = await _context.Foods
                .AsNoTracking()
                .AsSplitQuery()
                .Include(f => f.Nutrition)
                .Include(f => f.DishTypeFoods).ThenInclude(f => f.DishType)
                .ToListAsync();

            switch (foodNumberOfMeal)
            {
                case 0:
                    {
                        // Filter for Protein food
                        proteinFood = allFoods
                        .Where(f =>
                            f.MealType != null &&
                                     // f.DishType != null &&
                                     f.MealType.Select(mt => mt.ToString()).Any(mt => new[] { "Breakfast", "Lunch", "Dinner" }.Contains(mt.Trim())) && // Filter by MealType
                                                                                                                                                       // f.DishType.Select(dt => dt.ToString()).Any(dt => new[] { "MainDish", "SideDish" }.Contains(dt.Trim())) && // Filter by DishType
                                        f.DishTypeFoods.Any(dt => dt.DishType != null && dt.DishType.DishTypeName == "MainDish") &&   // Filter by DishType
                            f.Nutrition != null &&  // Ensure Nutrition is not null
                            f.Nutrition.Protein * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) > 0.2 &&
                            f.Nutrition.Carbs * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) < 0.5 && // Protein criteria
                            f.FoodAllergies != null &&  // Ensure FoodAllergies is not null
                            !allergiesIds.Any(al => f.FoodAllergies.Any(fa => fa.AllergyId == al))  // Ensure no allergies match
                        )
                        .OrderBy(f => Guid.NewGuid()) // Randomize order
                        .FirstOrDefault();

                        // Filter for Carb food
                        carbFood = allFoods
                            .Where(f =>
                                f.MealType != null &&
                          //             f.DishType != null &&
                          f.MealType.Select(mt => mt.ToString()).Any(mt => new[] { "Breakfast", "Lunch", "Dinner" }.Contains(mt.Trim())) && // Filter by MealType
                        f.DishTypeFoods.Any(dt => dt.DishType != null && dt.DishType.DishTypeName == "MainDish") &&   // Filter by DishType
                                f.Nutrition != null &&
                                f.Nutrition.Carbs * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) > 0.5 &&
                                f.Nutrition.Protein * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) < 0.2 &&
                                f.FoodAllergies != null &&
                                !allergiesIds.Any(al => f.FoodAllergies.Any(fa => fa.AllergyId == al))
                            )
                            .OrderBy(f => Guid.NewGuid())
                            .FirstOrDefault();

                        break;
                    }
                case 1:
                    {
                        // Filter for Balanced food
                        balanceFood = allFoods
                            .Where(f =>
                                f.MealType != null &&
             // f.DishType != null &&
             f.MealType.Select(mt => mt.ToString()).Any(mt => new[] { "Breakfast", "Lunch", "Dinner" }.Contains(mt.Trim())) && // Filter by MealType
            f.DishTypeFoods.Any(dt => (dt.DishType == null ? "" : dt.DishType.DishTypeName) == "MainDish") &&   // Filter by DishType
                                f.Nutrition != null &&
                             f.Nutrition.Protein * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) >= 0.15 &&
                             f.Nutrition.Protein * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) <= 0.2 && // Protein from 20% to 30%
                             f.Nutrition.Carbs * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) >= 0.4 &&
                             f.Nutrition.Carbs * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) <= 0.6 && // Carbs from 40% to 60%
                             f.FoodAllergies != null &&
                                !allergiesIds.Any(al => f.FoodAllergies.Any(fa => fa.AllergyId == al))
                            )
                            .OrderBy(f => Guid.NewGuid())
                            .FirstOrDefault();
                        break;
                    }
            }
            // Filter for vegetable food
            var vegetableFood = allFoods
      .Where(f =>
          f.MealType != null &&
          f.MealType.Select(mt => mt.ToString()).Any(mt => new[] { "Breakfast", "Lunch", "Dinner" }.Contains(mt.Trim())) && // Filter by MealType
          f.DishTypeFoods.Any(dt => (dt.DishType?.DishTypeName ?? "") == "SideDish") &&   // Filter by DishType
          f.Nutrition != null &&
          f.Nutrition.Calories < 50f && // Low calories
          f.Nutrition.Fat <= 1.5f && // Low fat
          f.Nutrition.Fiber >= 1.5f && // High fiber
          f.FoodAllergies != null &&
          !allergiesIds.Any(al => f.FoodAllergies.Any(fa => fa.AllergyId == al))  // Ensure no allergies match
      )
      .OrderBy(f => Guid.NewGuid())  // Randomize order
      .FirstOrDefault();


            return (proteinFood, carbFood, balanceFood, vegetableFood);
        }

        public async Task<PaginatedResult<Food>> GetRelatedFoodBasedOnType(Guid foodId, string? search, bool? status, int? page, int? limit)
        {
            // Lấy thông tin thức ăn mục tiêu
            var food = await _context.Foods
                .Include(f => f.CategoryFoods).ThenInclude(f => f.Category)
                .Include(f => f.FoodPortions).ThenInclude(f => f.Portion)
                .Include(f => f.Nutrition)
                .Include(f => f.DishTypeFoods).ThenInclude(f => f.DishType)
                .AsNoTracking()
                .AsSplitQuery()
                .FirstOrDefaultAsync(f => f.FoodId == foodId);

            if (food == null)
            {
                return new PaginatedResult<Food>
                {
                    Items = new List<Food>(),
                    TotalCount = 0
                };
            }


            // Xác định loại dinh dưỡng
            var foodType = GetFoodType(food);
            if (foodType == "Unknown")
            {
                return new PaginatedResult<Food>
                {
                    Items = new List<Food>(),
                    TotalCount = 0
                };
            }

            // Xây dựng truy vấn cơ bản
            var query = _context.Foods
                .Include(f => f.CategoryFoods).ThenInclude(f => f.Category)
                .Include(f => f.FoodPortions).ThenInclude(f => f.Portion)
                .Include(f => f.Nutrition)
                .Include(f => f.DishTypeFoods).ThenInclude(f => f.DishType)
                .AsNoTracking()
                .AsSplitQuery()
                .Where(f =>
                    f.FoodId != foodId && // Loại trừ thức ăn hiện tại
                    f.MealType != null &&
                    f.DishTypeFoods.Any(dt => dt.DishType.DishTypeName == "MainDish") &&
                    f.Nutrition != null);

            // Lọc theo loại dinh dưỡng ngay trong truy vấn
            query = foodType switch
            {
                "Protein" => query.Where(f =>
                    (f.Nutrition.Protein * 4.0 + f.Nutrition.Carbs * 4.0 + f.Nutrition.Fat * 9.0) != 0 &&
                    (f.Nutrition.Protein * 4.0) / (f.Nutrition.Protein * 4.0 + f.Nutrition.Carbs * 4.0 + f.Nutrition.Fat * 9.0) > 0.2 &&
                    (f.Nutrition.Protein * 4.0) / (f.Nutrition.Protein * 4.0 + f.Nutrition.Carbs * 4.0 + f.Nutrition.Fat * 9.0) < 0.5),

                "Carbs" => query.Where(f =>
                    (f.Nutrition.Protein * 4.0 + f.Nutrition.Carbs * 4.0 + f.Nutrition.Fat * 9.0) != 0 &&
                    (f.Nutrition.Carbs * 4.0) / (f.Nutrition.Protein * 4.0 + f.Nutrition.Carbs * 4.0 + f.Nutrition.Fat * 9.0) > 0.5),

                "Balanced" => query.Where(f =>
                    (f.Nutrition.Protein * 4.0 + f.Nutrition.Carbs * 4.0 + f.Nutrition.Fat * 9.0) != 0 &&
                    (f.Nutrition.Protein * 4.0) / (f.Nutrition.Protein * 4.0 + f.Nutrition.Carbs * 4.0 + f.Nutrition.Fat * 9.0) >= 0.15 &&
                    (f.Nutrition.Protein * 4.0) / (f.Nutrition.Protein * 4.0 + f.Nutrition.Carbs * 4.0 + f.Nutrition.Fat * 9.0) <= 0.2 &&
                    (f.Nutrition.Carbs * 4.0) / (f.Nutrition.Protein * 4.0 + f.Nutrition.Carbs * 4.0 + f.Nutrition.Fat * 9.0) >= 0.4 &&
                    (f.Nutrition.Carbs * 4.0) / (f.Nutrition.Protein * 4.0 + f.Nutrition.Carbs * 4.0 + f.Nutrition.Fat * 9.0) <= 0.6),

                _ => query.Where(f => false) // Trường hợp không xác định
            };
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.FoodName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                    s.FoodId.ToString().ToLower().Contains(search.ToLower()) ||
                    s.UserId.ToString().ToLower().Contains(search.ToLower()) ||
                    s.AppUser.PhoneNumber.ToString().ToLower().Contains(search.ToLower()) ||
                    s.AppUser.Email.ToString().ToLower().Contains(search.ToLower()) ||
                    EF.Functions.Collate(s.AppUser.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()));
            }
            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }
            // Thực hiện phân trang
            var totalItems = await query.CountAsync();

            if (page.HasValue && limit.HasValue && page.Value > 0 && limit.Value > 0)
            {
                query = query.OrderBy(f => f.FoodName).Skip((page.Value - 1) * limit.Value).Take(limit.Value);
            }

            var items = await query.ToListAsync();

            return new PaginatedResult<Food>
            {
                Items = items,
                TotalCount = totalItems
            };
        }

        private string GetFoodType(Food food)
        {
            if (food.Nutrition == null) return "Unknown";

            double protein = food.Nutrition.Protein;
            double carbs = food.Nutrition.Carbs;
            double fat = food.Nutrition.Fat;

            double totalCalories = protein * 4 + carbs * 4 + fat * 9;
            if (totalCalories == 0) return "Unknown";

            double proteinPercentage = protein * 4 / totalCalories;
            double carbPercentage = carbs * 4 / totalCalories;

            if (proteinPercentage > 0.2 && proteinPercentage < 0.5)
            {
                return "Protein";
            }
            else if (carbPercentage > 0.5)
            {
                return "Carbs";
            }
            else if (proteinPercentage >= 0.15 && proteinPercentage <= 0.2 &&
                     carbPercentage >= 0.4 && carbPercentage <= 0.6)
            {
                return "Balanced";
            }
            else
            {
                return "Unknown";
            }
        }


        public Task<int> GetTotalFoodCountAsync()
        {
            return _context.Foods.CountAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<PaginatedResult<Food>> GetAllFoodsAndFilterByFoodNameAsync(
    int page,
    int limit,
    string search,
    bool? status,
    bool? isPublic)
        {
            // 1. Tách chuỗi thành List<string>
            var terms = new List<string>();
            if (!string.IsNullOrWhiteSpace(search))
            {
                terms = search
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .Where(s => !string.IsNullOrEmpty(s))
                    .ToList();
            }


            // 2. Xây dựng query gốc
            var query = _context.Foods
                        .Include(f => f.DishTypeFoods).ThenInclude(fd => fd.DishType)
                            .Include(f => f.CategoryFoods).ThenInclude(cf => cf.Category)
                            .Include(f => f.Nutrition)
                            .Include(f => f.FoodPortions).ThenInclude(fp => fp.Portion)
                            .AsQueryable();
            if (isPublic.HasValue)
            {
                query = query.Where(s => s.IsPublic == isPublic.Value);
            }
            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }
            // 3. Áp dụng filter nếu có terms
            if (terms.Any())
            {
                query = query.Where(f =>
                    terms.Any(term =>
                    EF.Functions.Like(f.FoodName, "%" + term + "%")

                    )
                );
            }

            // 4. Lấy tổng và phân trang (nếu cần)
            var totalCount = await query.CountAsync();
            var items = await query
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToListAsync();

            // 5. Trả kết quả
            return new PaginatedResult<Food>
            {
                Items = items,
                TotalCount = totalCount
            };
        }

    }
}
