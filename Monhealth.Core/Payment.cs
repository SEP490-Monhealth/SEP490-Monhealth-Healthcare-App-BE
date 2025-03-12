using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
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
        public Guid UserId { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }
        [ForeignKey(nameof(SubscriptionId))]
        public Subscription Subscription { get; set; }
    }
}
