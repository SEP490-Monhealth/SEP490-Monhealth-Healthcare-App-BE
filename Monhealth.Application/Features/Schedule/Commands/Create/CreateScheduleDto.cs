using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Schedule.Commands.Create
{
    public class CreateScheduleDto
    {
        public RecurringDay? RecurringDay { get; set; }
        public DateOnly? SpecificDate { get; set; }
        public List<TimeOnly> TimeSlots { get; set; }
    }
}
