using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class ScheduleException : BaseEntity
    {
        [Key]
        public Guid ScheduleExceptionId { get; set; }
        public Guid? ScheduleId { get; set; }
        public DateOnly Date { get; set; }
        public string? Reason { get; set; }

        [ForeignKey(nameof(ScheduleId))]
        public Schedule? Schedule { get; set; }
    }
}
