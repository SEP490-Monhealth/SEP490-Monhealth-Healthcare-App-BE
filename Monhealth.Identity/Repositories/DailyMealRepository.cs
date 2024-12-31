using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class DailyMealRepository : GenericRepository<DailyMeal, Guid>, IDailyMealRepository
    {
        public DailyMealRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<DailyMeal>> GetAllDailyMeals()
        {
            return await _context.DailyMeals
                .Include(dl => dl.Meals)
                    .ThenInclude(m => m.MealFoods)
                        .ThenInclude(mf => mf.Food)
                            .ThenInclude(f => f.FoodPortions)
                .Include(dl => dl.Meals)
                    .ThenInclude(m => m.MealFoods)
                        .ThenInclude(mf => mf.Food)
                            .ThenInclude(f => f.Nutrition)
                .ToListAsync();
        }

        public async Task<DailyMeal> GetDailyMealByCreateAt(DateTime createAt)
        {
            return await _context.DailyMeals.Include(dl => dl.Meals)
                    .ThenInclude(m => m.MealFoods)
                        .ThenInclude(mf => mf.Food)
                            .ThenInclude(f => f.FoodPortions)
                .Include(dl => dl.Meals)
                    .ThenInclude(m => m.MealFoods)
                        .ThenInclude(mf => mf.Food)
                            .ThenInclude(f => f.Nutrition).
            FirstOrDefaultAsync(dl => dl.CreatedAt == createAt);
        }

        public async Task<DailyMeal> GetDailyMealByUserAndDate(DateTime createAt, Guid userID)
        {
            return await _context.DailyMeals.FirstOrDefaultAsync
            (d => d.CreatedAt == createAt && d.UserId == userID);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}