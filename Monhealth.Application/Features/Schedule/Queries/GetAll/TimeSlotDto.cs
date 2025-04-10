using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Schedule.Queries.GetAll
{
    public class TimeSlotDto
    {
        public Guid TimeSlotId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public ScheduleTimeSlotStatus Status { get; set; }
    }
}