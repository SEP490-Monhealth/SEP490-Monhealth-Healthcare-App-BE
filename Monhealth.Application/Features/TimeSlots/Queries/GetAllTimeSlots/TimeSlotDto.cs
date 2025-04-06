using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.TimeSlots.Queries.GetAllTimSlots
{
    public class TimeSlotDto : TimeEntity
    {
        public Guid TimeSlotId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

    }
}
