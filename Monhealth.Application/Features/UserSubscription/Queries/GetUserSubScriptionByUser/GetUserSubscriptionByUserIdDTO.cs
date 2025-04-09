using Monhealth.Core.Enum;
using Monhealth.Domain.Common;

namespace Monhealth.Application
{
    public class GetUserSubscriptionByUserIdDTO : TimeEntity
    {
        public Guid UserSubscriptionId { get; set; }
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public int RemainingBookings { get; set; }
        public UserSubscriptionStatus Status { get; set; }
    }
}