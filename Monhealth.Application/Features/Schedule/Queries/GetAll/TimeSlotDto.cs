using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Schedule.Queries.GetAll
{
    public class TimeSlotDto
    {
        public TimeOnly StartTime { get; set; }
        public ScheduleTimeSlotStatus Status { get; set; }
    }
}