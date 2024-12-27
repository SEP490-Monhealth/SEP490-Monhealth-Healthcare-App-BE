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
    }
}