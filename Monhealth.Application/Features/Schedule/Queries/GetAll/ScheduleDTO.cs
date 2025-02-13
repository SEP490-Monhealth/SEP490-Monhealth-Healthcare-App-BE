namespace Monhealth.Application.Features.Schedule.Queries.GetAll
{
    public class ScheduleDTO
    {
        public Guid ScheduleId { get; set; } // PK 
        public Guid ConsultantId { get; set; } // FK 
        public DateOnly? Date { get; set; } // 
        public string StartTime { get; set; }
        public string EndTime { get; set; } //
        public int MaxBookings { get; set; }
        public int BookedSlots { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}