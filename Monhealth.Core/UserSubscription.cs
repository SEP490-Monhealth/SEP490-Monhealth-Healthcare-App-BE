using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class UserSubscription : TimeEntity
    {
        [Key]
        public Guid UserSubscriptionId { get; set; }
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public string StartAt { get; set; } = string.Empty; // StartedAt
        public DateTime ExpiresAt { get; set; }
        public UserSubscriptionStatus Status { get; set; }

        [ForeignKey("UserId")]
        public AppUser User { get; set; }
        [ForeignKey("SubscriptionId")]
        public Subscription Subscription { get; set; }
    }
}
