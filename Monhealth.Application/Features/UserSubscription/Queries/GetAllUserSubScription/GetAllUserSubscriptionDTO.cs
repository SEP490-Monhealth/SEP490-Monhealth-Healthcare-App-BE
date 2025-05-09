using System.Text.Json.Serialization;
using Monhealth.Core.Enum;
using Monhealth.Domain.Common;

namespace Monhealth.Application
{
    public class GetAllUserSubscriptionDTO : TimeEntity
    {
        public Guid UserSubscriptionId { get; set; }
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public Member Member { get; set; }
        [JsonPropertyName("subscription")]
        public string SubscriptionName { get; set; } = string.Empty;
        public DateTime StartedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public int RemainingBookings { get; set; }
        public UserSubscriptionStatus Status { get; set; }
    }
    public class Member
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
    }

}