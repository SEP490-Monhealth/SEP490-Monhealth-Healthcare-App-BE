using Monhealth.Core;
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
        public Guid UserId { get; set; }
        public Guid UserSubscriptionId { get; set; }
        public long OrderCode { get; set; }
        public int Amount { get; set; }
        public PaymentStatus Status { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }

        [ForeignKey(nameof(UserSubscriptionId))]
        public UserSubscription UserSubscription { get; set; }
    }
}
