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

    }
}
