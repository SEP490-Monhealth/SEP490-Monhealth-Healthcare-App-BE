using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class TimeSlotRepository : GenericRepository<TimeSlot, Guid>, ITimeSlotRepository
    {
        public TimeSlotRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<List<TimeSlot>> GetExistTimeSlotByListTimeAsync(List<(TimeOnly StartTime, TimeOnly EndTime)> timeRanges)
        {
            var timeSlots = await _context.TimeSlots.ToListAsync();

            return timeSlots
               .Where(ts => timeRanges.Any(tr => tr.StartTime == ts.StartTime && tr.EndTime == ts.EndTime))
               .ToList();
        }

        public async Task<TimeSlot> GetTimeSlotByStartAndEndTime(TimeOnly startTime, TimeOnly endTime)
        {
            return await _context.TimeSlots
                .FirstOrDefaultAsync(ts => ts.StartTime == startTime && ts.EndTime == endTime);
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
