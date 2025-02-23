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

        public async Task<PaginatedResult<Food>> GetAllFoodAsync(int page, int limit, string? search, bool? status, string categoryName, bool? popular, bool? isPublic)
        {
            search = search?.Trim();
            IQueryable<Food> query = _context.Foods.Include(f => f.Category).
            Include(f => f.Nutrition).
            Include(f => f.FoodPortions)
            .ThenInclude(f => f.Portion)
            .Include(f => f.FoodAllergies)
            .ThenInclude(f => f.Allergy).AsQueryable();

            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.FoodName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                    s.FoodId.ToString().ToLower().Contains(search.ToLower()));
            }
            if (!string.IsNullOrEmpty(categoryName))
                query = query.Where(f => f.Category.CategoryName == categoryName);

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
            return await _context.Foods
        .Include(f => f.Category)
        .Include(f => f.FoodPortions)
        .FirstOrDefaultAsync(f => f.FoodId == foodId);
        }

        public async Task<List<Food>> GetFoodByCategoryName(string categoryName)
        {
            return await _context.Foods.Where(f => f.Category.CategoryName == categoryName)
            .ToListAsync();
        }
        public async Task<Food> GetFoodByIdAsync(Guid foodId)
        {
            // Fetch the food item along with its related data
            var food = await _context.Foods
                .Include(fc => fc.Category)
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

        public async Task<PaginatedResult<Food>> GetFoodByUserId(int page, int limit, Guid userId)
        {
            // Truy vấn dữ liệu cơ bản
            IQueryable<Food> query = _context.Foods
                .Where(f => f.UserId == userId)
                .Include(f => f.Category)
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

        public async Task<List<Food>> GetFoodsAsync(int Skip, int take)
        {
            return await _context.Foods
                .Include(f => f.Category)
                .Include(f => f.Nutrition)
                .Include(f => f.FoodPortions).ThenInclude(fp => fp.Portion)
           .Skip(Skip)
           .Take(take)
           .ToListAsync();
        }

        public async Task<List<Food>> GetFoodsByCategoryNameAsync(string[] categoryNames)
        {
            return await _context.Foods.Where(f => categoryNames.Contains(f.Category.CategoryName)).
               Include(f => f.Nutrition).Include(f => f.FoodPortions).ThenInclude(f => f.Portion).ToListAsync();

        }

        public async Task<List<Food>> GetFoodsExcludingIdsAsync(List<Guid> excludedFoodIds, int skip, int take)
        {
            return await _context.Foods
                .Where(food => !excludedFoodIds.Contains(food.FoodId))
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }

        public async Task<IEnumerable<Food>> GetFoodsFilteredByAllergiesAsync(IEnumerable<string> allergies, int skip, int take)
        {
            return await _context.Foods
                .Where(f => !allergies.Any(allergy => f.FoodDescription.Contains(allergy))) // Lọc các món không chứa dị ứng
                .OrderBy(f => f.FoodName) // Sắp xếp (tuỳ chỉnh nếu cần)
                .Skip(skip) // Bỏ qua số lượng bản ghi
                .Take(take) // Lấy số lượng bản ghi
                .ToListAsync();
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
            var query = _context.Foods.Include(f => f.Category).AsQueryable();

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

            var query = _context.Foods.Include(f => f.Category)
     .Where(f => f.CategoryId != null && categoryIds.Contains(f.CategoryId.Value));


            var totalCount = await query.CountAsync();
            var items = await query
                .OrderBy(f => f.FoodName) // Sắp xếp theo tên món ăn
                .Skip(skip)
                .Take(take)
                .ToListAsync();

            return new PaginatedResult<Food>
            {
                Items = items,
                TotalCount = totalCount
            };
        }

        public async Task<PaginatedResult<Food>> GetPaginatedFoodsByFiltersAsync(
     List<Guid> categoryIds,
     List<Guid> excludedFoodIds,
     List<string>? mealTypeFilter,
     List<string>? dishTypeFilter,
     int skip,
     int take)
        {
            var query = _context.Foods.Include(f => f.Category)
     .Where(f => !excludedFoodIds.Contains(f.FoodId) && categoryIds.Contains(f.CategoryId.Value)
     && f.IsPublic == true && f.Status == true);

            var items = await query.ToListAsync();

            if (mealTypeFilter != null && mealTypeFilter.Any())
            {
                var normalizedMealTypeFilter = mealTypeFilter.Select(mt => mt.ToLower()).ToList();
                items = items.Where(f => f.MealType.Any(mt => normalizedMealTypeFilter.Contains(mt.ToString().ToLower()))).ToList();
            }

            if (dishTypeFilter != null && dishTypeFilter.Any())
            {
                var normalizedDishTypeFilter = dishTypeFilter.Select(dt => dt.ToLower()).ToList();
                items = items.Where(f => f.DishType.Any(dt => normalizedDishTypeFilter.Contains(dt.ToString().ToLower()))).ToList();
            }

            var totalCount = items.Count;

            items = items
                .OrderBy(f => f.FoodName)
                .Skip(skip)
                .Take(take)
                .ToList();

            return new PaginatedResult<Food>
            {
                Items = items,
                TotalCount = totalCount
            };

        }





        public async Task<PaginatedResult<Food>> GetPaginatedFoodsExcludingIdsAsync(IEnumerable<Guid> excludedFoodIds, int skip, int take)
        {
            var query = _context.Foods
        .Where(f => !excludedFoodIds.Contains(f.FoodId));

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

        public Task<int> GetTotalFoodCountAsync()
        {
            return _context.Foods.CountAsync();
        }

        public async Task<int> GetTotalFoodCountExcludingIdsAsync(List<Guid> excludedFoodIds)
        {
            return await _context.Foods
           .Where(food => !excludedFoodIds.Contains(food.FoodId))
           .CountAsync();
        }

        public async Task<int> GetTotalFoodCountFilteredByAllergiesAsync(IEnumerable<string> allergies)
        {
            return await _context.Foods
                .CountAsync(f => !allergies.Any(allergy => f.FoodDescription.Contains(allergy)));
        }


        public void RemoveFoodPortions(Guid foodId)
        {
            var portionsToRemove = _context.FoodPortions.Where(fp => fp.FoodId == foodId);
            _context.FoodPortions.RemoveRange(portionsToRemove);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
