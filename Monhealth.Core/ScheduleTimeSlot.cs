using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class ScheduleTimeSlot : TimeEntity
    {
        [Key]
        public Guid ScheduleTimeSlotId { get; set; }
        public Guid? ScheduleId { get; set; }
        public Guid? TimeSlotId { get; set; }
        public ScheduleTimeSlot Status { get; set; }
        [ForeignKey(nameof(ScheduleId))]
        public Schedule? Schedule { get; set; }
        [ForeignKey(nameof(TimeSlotId))]
        public TimeSlot? TimeSlot { get; set; }
    }
}
