using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;
namespace Monhealth.Identity.Repositories
{
    public class ScheduleRepository : GenericRepository<Schedule, Guid>, IScheduleRepository
    {
        public ScheduleRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<Schedule> GetScheduleAsync(Guid consultantId, ScheduleType scheduleType, RecurringDay recurringDay)
        {
            return await _context.Schedules.Include(s => s.ScheduleTimeSlots).ThenInclude(st => st.TimeSlot)
                    .FirstOrDefaultAsync(s => s.ConsultantId == consultantId
                    && s.ScheduleType == scheduleType
                    && s.RecurringDay == recurringDay);
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