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

        public async Task<List<TimeSlot>> GetExistTimeSlotByListTimeAsync(List<TimeOnly> timeSlots)
        {
            return await _context.TimeSlots.Where(ts => timeSlots.Contains(ts.StartTime)).ToListAsync();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
