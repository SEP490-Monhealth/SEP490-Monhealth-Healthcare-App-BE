using Monhealth.Core;
using Monhealth.Domain.Common;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Payment.Queries.GetALL
{
    public class PaymentDTO : BaseEntity
    {
        public Guid PaymentId { get; set; }
        public Guid SubscriptionId { get; set; }
        public Member Member { get; set; } = null!;
        [JsonPropertyName("subscription")]
        public string SubscriptionName { get; set; } = string.Empty;
        public int Amount { get; set; }
        public PaymentStatus Status { get; set; }
    }
    public class Member
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
    }
}