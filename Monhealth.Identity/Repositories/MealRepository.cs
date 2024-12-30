using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<Meal> GetByUserIdAndMealType(Guid userId, string mealType)
        {
            return await _context.Meals.FirstOrDefaultAsync
            (m => m.UserId == userId && m.MealType == mealType);
        }

        public async Task<List<Meal>> GetMealByUserAndDate(DateTime createAt, Guid userId)
        {
            var targetDate = createAt.Date;

            return  _context.Meals
                .Where(m => m.UserId == userId)
                .AsEnumerable() // Chuyển sang xử lý phía client
                .Where(m => m.CreatedAt.HasValue && m.CreatedAt.Value.Date == targetDate)
                .ToList();
        }









        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}