using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Booking : BaseEntity
    {
        [Key]
        public Guid BookingId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ConsultantId { get; set; }
        public Guid? ScheduleId { get; set; }
        public Guid? TimeSlotId { get; set; }
        public string? Notes { get; set; }
        public string? CancellationReason { get; set; }
        public BookingStatus Status { get; set; }

        [ForeignKey(nameof(UserId)), Column(Order = 0)]
        public AppUser? User { get; set; }
        [ForeignKey(nameof(ConsultantId)), Column(Order = 1)]
        public Consultant? Consultant { get; set; }

        [ForeignKey(nameof(ScheduleId))]
        public Schedule Schedule { get; set; }

        [ForeignKey(nameof(TimeSlotId))]
        public TimeSlot TimeSlot { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
