using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetScheduleExceptionByConsultantId
{
    public class GetScheduleExceptionByConsultantIdDTO : TimeEntity
    {
        public Guid ScheduleExceptionId { get; set; }
        public Guid ConsultantId { get; set; }
        public DateOnly Date { get; set; }
        public string? Reason { get; set; }
        public ScheduleExceptionStatus Status { get; set; }

    }
}
