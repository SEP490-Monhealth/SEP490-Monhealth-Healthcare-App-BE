using Monhealth.Core.Enum;

namespace Monhealth.Application
{
    public class GetUserSubscriptionByUserIdDTO
    {
        public Guid UserSubscriptionId { get; set; }
        public Guid SubscriptionId { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public int RemainingBookings { get; set; }
        public UserSubscriptionStatus Status { get; set; }
    }
}