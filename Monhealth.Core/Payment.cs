using Monhealth.Core;
using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Payment : BaseEntity
    {
        [Key]
        public Guid PaymentId { get; set; }
        public Guid? UserSubscriptionId { get; set; }
        public Guid? SubscriptionId { get; set; }
        public long OrderCode { get; set; }
        public string? Description { get; set; }
        public int Amount { get; set; }
        public PaymentStatus Status { get; set; }

        [ForeignKey(nameof(UserSubscriptionId))]
        public UserSubscription? UserSubscription { get; set; }
    }
}
