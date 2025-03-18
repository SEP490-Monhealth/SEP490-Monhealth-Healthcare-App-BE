using Monhealth.Domain.Common;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Subscription.Queries.GetByUser
{
    public class SubscriptionByUserDTO : BaseEntity
    {
        public Guid SubscriptionId { get; set; }
        [JsonPropertyName("name")]
        public string SubscriptionName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string SubscriptionDescription { get; set; } = string.Empty;
        public int Price { get; set; }
        public int DurationDays { get; set; }
        public List<string> Features { get; set; } = [];
        public int BookingAllowance { get; set; }
        public bool Status { get; set; }
    }
}