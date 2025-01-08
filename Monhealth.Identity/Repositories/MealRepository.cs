using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class MealRepository : GenericRepository<Meal, Guid>, IMealRepository
    {
        public MealRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<Meal>> GetAllMealFoodForMeal(Guid MealId)
        {
            return await _context.Meals.Where(m => m.MealId == MealId)
            .Include(m => m.MealFoods)
           .ThenInclude(mf => mf.Food)
               .ThenInclude(f => f.Nutrition)
       .Include(m => m.MealFoods)
           .ThenInclude(mf => mf.Food)
               .ThenInclude(f => f.FoodPortions)
                   .ThenInclude(fp => fp.Portion)
       .ToListAsync();
        }

        public async Task<List<Meal>> GetAllMeals()
        {
            return await _context.Meals
       .Include(m => m.MealFoods)
           .ThenInclude(mf => mf.Food)
               .ThenInclude(f => f.Nutrition)
       .Include(m => m.MealFoods)
           .ThenInclude(mf => mf.Food)
               .ThenInclude(f => f.FoodPortions)
                   .ThenInclude(fp => fp.Portion)
       .ToListAsync();

        }

        public async Task<List<string>> GetAllMealTypesAsync()
        {
            // Truy vấn tất cả MealType từ bảng MealFood
            return await _context.Meals
                .Select(mf => mf.MealType) // Lấy trường MealType
                .Distinct()                // Loại bỏ trùng lặp
                .ToListAsync();            // Trả về danh sách bất đồng bộ
        }


        public async Task<Meal> GetByUserIdAndMealType(Guid userId, string mealType , int date)
        {
            return await _context.Meals.FirstOrDefaultAsync
            (m => m.UserId == userId && m.MealType == mealType
            && m.CreatedAt.Value.Date.Day == date);
        }



        public async Task<Meal> GetMealByMealId(Guid mealId)
        {
            return await _context.Meals
      .Include(m => m.MealFoods)
          .ThenInclude(mf => mf.Food)
              .ThenInclude(f => f.Nutrition)
      .Include(m => m.MealFoods)
          .ThenInclude(mf => mf.Food)
              .ThenInclude(f => f.FoodPortions)
                  .ThenInclude(fp => fp.Portion)
      .FirstOrDefaultAsync(m => m.MealId == mealId);
        }

        public async Task<List<Meal>> GetMealByUser(Guid userId)
        {
            return await _context.Meals
      .Include(m => m.MealFoods)
          .ThenInclude(mf => mf.Food)
              .ThenInclude(f => f.Nutrition)
      .Include(m => m.MealFoods)
          .ThenInclude(mf => mf.Food)
              .ThenInclude(f => f.FoodPortions)
                  .ThenInclude(fp => fp.Portion)
      .Where(m => m.UserId == userId).ToListAsync();
        }

        public async Task<List<Meal>> GetMealByUserAndDate(DateTime createAt, Guid userId)
        {
            var targetDate = createAt.Date;

            return _context.Meals
                .Where(m => m.UserId == userId)
                .AsEnumerable() // Chuyển sang xử lý phía client
                .Where(m => m.CreatedAt.HasValue && m.CreatedAt.Value.Date == targetDate)
                .ToList();
        }

        public async Task<IEnumerable<Meal>> GetMealsByDailyMealId(Guid dailyMealId)
        {
            return await _context.Meals
           .Where(m => m.DailyMealId == dailyMealId)
           .ToListAsync();
        }



        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}