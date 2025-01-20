namespace Monhealth.Application.Features.Schedule.Queries.GetAll
{
    public class ScheduleDTO
    {
        public Guid ScheduleId { get; set; } // PK 
        public Guid ConsultantId { get; set; } // FK 
        public DateOnly? Date { get; set; } // 
        public TimeOnly Time { get; set; } // 
        public string Status { get; set; } = string.Empty;
    }
}