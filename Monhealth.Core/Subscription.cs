using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Domain
{
    public class Subscription : BaseEntity
    {
        [Key]
        public Guid SubscriptionId { get; set; }
        public string SubscriptionName { get; set; } = string.Empty;
        public int Price { get; set; }
        public ICollection<UserSubscription> UserSubscriptions { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}