using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Domain
{
    public class TimeSlot : TimeEntity
    {
        [Key]
        public Guid TimeSlotId { get; set; }
        public TimeOnly StartTime { get; set; }
        public ICollection<ScheduleTimeSlot>? ScheduleTimeSlots { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}
