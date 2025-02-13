namespace Monhealth.Application.Features.Subscription.Queries.GetById
{
    public class ScheduleDetailDTO
    {
        public Guid ConsultantId { get; set; } // FK 
        public DateOnly? Date { get; set; } // 
        public string StartTime { get; set; }
        public string EndTime { get; set; } //
        public int MaxBookings { get; set; }
        public int BookedSlots { get; set; }
    }
}