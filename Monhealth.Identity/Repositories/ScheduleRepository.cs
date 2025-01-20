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

        public async Task<List<Schedule>> GetSchedulesByUser(Guid userId)
        {
            return await _context.Schedules.
            Where(s => s.ConsultantId == userId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}