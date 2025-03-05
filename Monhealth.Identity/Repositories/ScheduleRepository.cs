using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
namespace Monhealth.Identity.Repositories
{
    public class ScheduleRepository : GenericRepository<Schedule, Guid>, IScheduleRepository
    {
        public ScheduleRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<Schedule>> GetSchedulesByUser(Guid userId, DateOnly? Date)
        {
            var query = _context.Schedules.Where(s => s.ConsultantId == userId);
            if (Date.HasValue)
            {
                // query = query.Where(s => s.Date == Date.Value);
            }
            return await query.ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}