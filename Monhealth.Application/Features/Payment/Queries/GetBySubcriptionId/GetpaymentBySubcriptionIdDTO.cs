using Monhealth.Core;
using Monhealth.Domain.Common;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Payment.Queries.GetBySubcriptionId
{
    public class GetPaymentBySubscriptionIdDTO : BaseEntity
    {
        public Guid PaymentId { get; set; }
        public Guid SubscriptionId { get; set; }
        public Member Member { get; set; } = null!;
        [JsonPropertyName("subscription")]
        public string SubscriptionName { get; set; } = string.Empty;
        public int Amount { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
