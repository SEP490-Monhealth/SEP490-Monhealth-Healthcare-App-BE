using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Schedule.Queries.GetAll
{
    public class ScheduleDTO
    {
        public Guid ScheduleId { get; set; }
        public Guid ConsultantId { get; set; }
        public string ScheduleType { get; set; }
        public string? RecurringDay { get; set; }
        public DateOnly? SpecificDate { get; set; }
        public List<TimeSlotDto> Items { get; set; }
    }
}