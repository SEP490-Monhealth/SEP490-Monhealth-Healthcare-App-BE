using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Schedule.Queries.GetAll
{
    public class ScheduleDTO
    {
        public Guid ScheduleId { get; set; }
        public Guid ConsultantId { get; set; }
        public ScheduleType ScheduleType { get; set; }
        public RecurringDay? RecurringDay { get; set; }
        public DateOnly? SpecificDate { get; set; }
        public List<TimeSlotDto> TimeSlots { get; set; }
    }
}