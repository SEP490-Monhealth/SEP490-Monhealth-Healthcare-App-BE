using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Payment : BaseEntity
    {
        [Key]
        public Guid PaymentId { get; set; } // PK
        public Guid BookingId { get; set; } // FK
        public Guid SubscriptionId { get; set; } // FK
        public int Amount { get; set; }
        public string Status { get; set; } = string.Empty;
        [ForeignKey(nameof(BookingId))]
        public Booking Booking { get; set; }
    }
}
