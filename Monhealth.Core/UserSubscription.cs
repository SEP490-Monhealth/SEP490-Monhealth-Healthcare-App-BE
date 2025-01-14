using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class UserSubscription
    {
        [Key]
        public Guid UserSubscriptionId { get; set; }
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("UserId")]
        public AppUser User { get; set; }
        [ForeignKey("SubscriptionId")]
        public Subscription Subscription { get; set; }
    }
}
