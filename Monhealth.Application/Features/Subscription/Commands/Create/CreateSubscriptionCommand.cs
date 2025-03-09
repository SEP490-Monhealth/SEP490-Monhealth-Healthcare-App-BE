using System.Text.Json.Serialization;
using MediatR;

namespace Monhealth.Application.Features.Subscription.Commands.Create
{
    public class CreateSubscriptionCommand : IRequest<Unit>
    {
        [JsonPropertyName("name")]
        public string SubscriptionName { get; set; } = string.Empty;
        public int Price { get; set; }
        [JsonPropertyName("description")]
        public string SubscriptionDescription { get; set; } = null!;
        public int DurationDays { get; set; }
        public string Features { get; set; } = null!;
        public bool Status { get; set; }
    }
}