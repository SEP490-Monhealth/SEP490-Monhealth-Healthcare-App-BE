namespace Monhealth.Application.Features.TimeSlots.Commands.CreateTimeSlots
{
    public class CreateTimeSlotDTO
    {
        public Guid ScheduleId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
