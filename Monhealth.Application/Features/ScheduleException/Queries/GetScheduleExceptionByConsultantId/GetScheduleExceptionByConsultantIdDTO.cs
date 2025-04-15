using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetScheduleExceptionByConsultantId
{
    public class GetScheduleExceptionByConsultantIdDTO : TimeEntity
    {
        public Guid ScheduleExceptionId { get; set; }
        public Guid ConsultantId { get; set; }
        public DateOnly Date { get; set; }
        public string? Reason { get; set; }
    }
}
