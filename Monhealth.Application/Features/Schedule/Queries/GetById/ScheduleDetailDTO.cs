using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Subscription.Queries.GetById
{
    public class ScheduleDetailDTO
    {
        public Guid ScheduleId { get; set; } // PK 
        public Guid ConsultantId { get; set; } // FK 
        public DateOnly? Date { get; set; } // 
        public TimeOnly? Time { get; set; }
        public ScheduleStatus Status { get; set; }

    }
}