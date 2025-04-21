using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class DailyActivityRepository : GenericRepository<DailyActivity, Guid>, IDailyActivityRepository
    {
        public DailyActivityRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<DailyActivity> GetDailyActivityByUserIdAndCreateAt(Guid userId)
        {
            return await _context.DailyActivities.Include(d => d.Activities)
            .ThenInclude(da => da.Workout)
            .Where(u => u.UserId == userId).FirstOrDefaultAsync();
        }

        public async Task<DailyActivity> GetDailyActivityByUserIdAndCreateAt(Guid userId, DateTime today)
        {
            var dateToDay = today.Date;
            var dailyActivity = await _context.DailyActivities.Include(g => g.Goal)
                .FirstOrDefaultAsync(u => u.UserId == userId
                                            && u.CreatedAt.HasValue
                                            && u.CreatedAt.Value.Date == dateToDay);
            return dailyActivity;
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
