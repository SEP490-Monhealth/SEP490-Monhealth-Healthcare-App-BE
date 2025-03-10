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


    }
}
