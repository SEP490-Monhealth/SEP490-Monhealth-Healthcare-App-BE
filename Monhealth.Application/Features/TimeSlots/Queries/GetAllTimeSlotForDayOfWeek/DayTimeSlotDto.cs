namespace Monhealth.Application.Features.TimeSlots.Queries.GetAllTimeSlotForDayOfWeek
{
    public class DayTimeSlotDto
    {
        public int DayOfWeek { get; set; }
        public List<string> TimeSlots { get; set; }
    }
}
