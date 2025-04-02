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
            return await _context.DailyWaterIntakes
                .Where(dl => dl.UserId == userId && dl.CreatedAt.Value.Date == createAt.Date)
                .FirstOrDefaultAsync();
        }

        public async Task<DailyWaterIntake> GetDailyWaterIntakesByUser(Guid userId, DateTime date)
        {
            return await _context.DailyWaterIntakes.Include(g => g.Goal)
                .Where(dl => dl.UserId == userId && dl.CreatedAt.Value.Date == date.Date)
                .FirstOrDefaultAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
