namespace Monhealth.Application.Features.Schedule.Queries.GetByUser
{
    public class GetScheduleByUserDTO
    {
        public Guid ScheduleId { get; set; } // PK 
        public DateOnly? Date { get; set; } // 
        public string StartTime { get; set; }
        public string EndTime { get; set; } //
        public int MaxBookings { get; set; }
        public int BookedSlots { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}