using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class DailyWaterIntakesRepository : GenericRepository<DailyWaterIntake, Guid>, IDailyWaterIntakesRepository
    {
        public DailyWaterIntakesRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<DailyWaterIntake> GetDailyWaterIntakeByUserAndDate(DateTime createAt, Guid userId)
        {
            return await _context.DailyWaterIntakes.FirstOrDefaultAsync
            (dl => dl.CreatedAt.Value.Date== createAt
            && dl.UserId == userId);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}