using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Payment : BaseEntity
    {
        [Key]
        public Guid PaymentId { get; set; }
        //public Guid BookingId { get; set; }
        public Guid SubscriptionId { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; } = string.Empty;

        [ForeignKey(nameof(SubscriptionId))]
        public Subscription Subscription { get; set; }
    }
}
