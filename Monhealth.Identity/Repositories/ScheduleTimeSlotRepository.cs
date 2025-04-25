using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ScheduleTimeSlotRepository : GenericRepository<ScheduleTimeSlot, Guid>, IScheduleTimeSlotRepository
    {
        public ScheduleTimeSlotRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<bool> ExistTimeSlot(Guid scheduleId, Guid timeSlotId)
        {
            return await _context.ScheduleTimeSlots
                     .AnyAsync(st => st.ScheduleId == scheduleId && st.TimeSlotId == timeSlotId);
        }

        public async Task<List<Guid>> GetTimslotIdsByScheduleId(Guid scheduleId)
        {
            return await _context.ScheduleTimeSlots
                .Where(st => st.ScheduleId == scheduleId)
                .Select(st => st.TimeSlotId ?? Guid.Empty)
                .ToListAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
