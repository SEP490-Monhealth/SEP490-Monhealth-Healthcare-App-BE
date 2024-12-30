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
    public class DailyMealRepository : GenericRepository<DailyMeal, Guid>, IDailyMealRepository
    {
        public DailyMealRepository(MonhealthDbcontext context) : base(context)
        {
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