namespace Monhealth.Application.Features.Subscription.Queries.GetById
{
    public class ScheduleDetailDTO
    {
        public Guid ConsultantId { get; set; } // FK 
        public DateOnly? Date { get; set; } // 
        public TimeOnly Time { get; set; } // 
        public string Status { get; set; } = string.Empty;
    }
}