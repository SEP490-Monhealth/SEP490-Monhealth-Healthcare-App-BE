using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Schedule.Queries.GetByUser
{
    public class GetScheduleByUserDTO
    {
        public Guid ScheduleId { get; set; } // PK 
        public Guid ConsultantId { get; set; } // FK 
        public DateOnly? Date { get; set; } // 
        public TimeOnly? Time { get; set; }
        public ScheduleStatus Status { get; set; }
    }
}