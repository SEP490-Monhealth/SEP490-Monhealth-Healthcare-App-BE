using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class MealFoodRepository : GenericRepository<MealFood, Guid>, IMealFoodRepository
    {
        public MealFoodRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public Task<MealFood> GetByMealFoodIdAsync(Guid id)
        {
            return _context.MealFoods.Include(mf => mf.Food).ThenInclude(mf => mf.Nutrition)
            .Include(mf => mf.Food).ThenInclude(mf => mf.FoodPortions).ThenInclude(mf => mf.Portion)
            .FirstOrDefaultAsync(mf => mf.MealFoodId == id);
        }

        public async Task<MealFood> GetByMealIdAndFoodId(Guid mealId, Guid FoodId)
        {
            return await _context.MealFoods.FirstOrDefaultAsync(mf => mf.MealId == mealId
            && mf.FoodId == FoodId);
        }


        public async Task<List<MealFood>> GetMealFoodByFoodId(Guid foodId)
        {
            return await _context.MealFoods.Where(mf => mf.FoodId == foodId).ToListAsync();
        }

        public async Task<List<MealFood>> GetMealFoodByMealId(Guid mealId)
        {
            return await _context.MealFoods.Where(mf => mf.MealId == mealId)
            .Include(mf => mf.Food).ThenInclude(mf => mf.Nutrition).
            Include(mf => mf.Food)
            .ThenInclude(mf => mf.FoodPortions)
            .ThenInclude(mf => mf.Portion).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> SaveChangeASyncs()
        {
            return await _context.SaveChangesAsync();
        }
    }
}