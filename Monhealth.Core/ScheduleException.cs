using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class ScheduleException : BaseEntity
    {
        [Key]
        public Guid ScheduleExceptionId { get; set; }
        public Guid ConsultantId { get; set; }
        public DateOnly Date { get; set; }
        public string? Reason { get; set; }
        public ScheduleExceptionStatus Status { get; set; } = ScheduleExceptionStatus.Pending;

        [ForeignKey(nameof(ConsultantId))]
        public Consultant Consultant { get; set; }

    }
}
