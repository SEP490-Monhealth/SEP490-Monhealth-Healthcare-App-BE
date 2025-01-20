namespace Monhealth.Application.Features.Schedule.Queries.GetByUser
{
    public class GetScheduleByUserDTO
    {
        public Guid ConsultantId { get; set; }  
        public DateOnly? Date { get; set; }
        public TimeOnly Time { get; set; }  
        public string Status { get; set; } = string.Empty;
    }
}