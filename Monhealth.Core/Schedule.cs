using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Schedule : TimeEntity
    {
        [Key]
        public Guid ScheduleId { get; set; }
        public Guid ConsultantId { get; set; }
        public DateOnly? Date { get; set; }
        public TimeOnly? Time { get; set; }
        public ScheduleStatus Status { get; set; }

        [ForeignKey(nameof(ConsultantId))]
        public Consultant Consultant { get; set; }
    }
}
