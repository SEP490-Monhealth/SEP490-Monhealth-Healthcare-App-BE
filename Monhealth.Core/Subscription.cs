using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Domain
{
    public class Subscription : BaseEntity
    {
        [Key]
        public Guid SubscriptionId { get; set; }
        public string SubscriptionName { get; set; } = string.Empty;
        public string SubscriptionDescription { get; set; } = string.Empty;
        public int Price { get; set; }
        public int DurationDays { get; set; }
        public List<string> Features { get; set; } = [];
        public int BookingAllowance { get; set; }
        public bool Status { get; set; }

        public ICollection<UserSubscription> UserSubscriptions { get; set; }
    }
}