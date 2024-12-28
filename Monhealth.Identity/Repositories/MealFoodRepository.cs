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
    public class MealFoodRepository : GenericRepository<MealFood, Guid>, IMealFoodRepository
    {
        public MealFoodRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<MealFood> GetByMealIdAndFoodId(Guid mealId, Guid FoodId)
        {
            return await _context.MealFoods.FirstOrDefaultAsync(mf => mf.MealId == mealId
            && mf.FoodId == FoodId);
        }
    }
}