using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException
{
    public class ScheduleExceptionDto : TimeEntity
    {
        public Guid ScheduleExceptionId { get; set; }
        public Guid? ScheduleId { get; set; }
        public DateOnly Date { get; set; }
        public string? Reason { get; set; }
    }
}
