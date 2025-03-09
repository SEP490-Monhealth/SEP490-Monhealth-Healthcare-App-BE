using System.Text.Json.Serialization;
using MediatR;

namespace Monhealth.Application.Features.Subscription.Commands.Update
{
    public class UpdateSubscriptionRequest : IRequest<bool>
    {
        [JsonPropertyName("name")]
        public string SubscriptionName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string SubscriptionDescription { get; set; } = null!;
        public int Price { get; set; }
        public int DurationDays { get; set; }
        public string Features { get; set; } = null!;
        public int MaxBookings { get; set; }
    }
}