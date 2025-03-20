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
                    s.FoodId.ToString().ToLower().Contains(search.ToLower()));
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
                .Include(fc => fc.CategoryFoods)
                .ThenInclude(fc => fc.Category)
                .Include(fc => fc.Nutrition)
                .Include(fc => fc.FoodPortions)
                .ThenInclude(fc => fc.Portion)
                .Include(fc => fc.FoodAllergies)
                .ThenInclude(fc => fc.Allergy)
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
            // Lấy danh sách tất cả các món ăn với các thông tin liên quan
            var foodList = await _context.Foods
                .Include(f => f.Nutrition)
                .Include(f => f.FoodPortions)
                    .ThenInclude(fp => fp.Portion)
                .Include(f => f.FoodAllergies)
                    .ThenInclude(fa => fa.Allergy)
                .ToListAsync();

            // Lấy danh sách các dị ứng của người dùng
            var userAllergies = await _context.UserAllergies
                .Where(ua => ua.UserId == userId)
                .Select(ua => ua.AllergyId)
                .ToListAsync();

            // Nếu người dùng không có dị ứng nào, trả về tất cả các món ăn
            if (userAllergies.Count == 0)
            {
                return foodList;
            }

            // Lọc ra các món ăn mà người dùng không bị dị ứng
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
                .Include(f => f.CategoryFoods)
                .ThenInclude(f => f.Category)
                .Include(f => f.Nutrition)
                .Include(f => f.FoodAllergies)
                .ThenInclude(f => f.Allergy)
                .Include(f => f.FoodPortions).ThenInclude(fp => fp.Portion);

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
            return await _context.Nutritions
          .Where(n => n.FoodId == foodId)
          .FirstOrDefaultAsync();
        }
        public async Task<List<Nutrition>> GetNutritionByFoodIdsAsync(List<Guid> foodIds)
        {
            if (foodIds == null || !foodIds.Any())
            {
                return new List<Nutrition>();
            }
            return await _context.Nutritions
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
                                        f.DishTypeFoods.Any(dt => (dt.DishType?.DishTypeName ?? "") == "MainDish") &&   // Filter by DishType
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
                           f.DishTypeFoods.Any(dt => (dt.DishType?.DishTypeName ?? "") == "MainDish") &&   // Filter by DishType
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
            f.DishTypeFoods.Any(dt => (dt.DishType?.DishTypeName ?? "") == "MainDish") &&   // Filter by DishType
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

        public Task<int> GetTotalFoodCountAsync()
        {
            return _context.Foods.CountAsync();
        }


        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
