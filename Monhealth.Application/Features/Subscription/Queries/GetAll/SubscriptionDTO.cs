using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Subscription.Queries.GetAll
{
    public class SubscriptionDTO : BaseEntity
    {
        public Guid SubscriptionId { get; set; }
        [JsonPropertyName("name")]
        public string SubscriptionName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string SubscriptionDescription { get; set; } = string.Empty;
        public int Price { get; set; }
        public int DurationDays { get; set; }
        public string Features { get; set; } = string.Empty;
        public int MaxBookings { get; set; }
        public bool Status { get; set; }
    }
}