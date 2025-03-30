using System.Text.Json.Serialization;
using Monhealth.Core;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Payment.Queries.GetBySubcriptionId
{
    public class GetPaymentBySubscriptionIdDTO : BaseEntity
    {
        public Guid PaymentId { get; set; }
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public Member Member { get; set; } = null!;
        [JsonPropertyName("subscription")]
        public string SubscriptionName { get; set; } = string.Empty;
        public int Amount { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
