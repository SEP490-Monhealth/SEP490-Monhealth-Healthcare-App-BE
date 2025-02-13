using MediatR;

namespace Monhealth.Application.Features.Subscription.Commands.Update
{
    public class UpdateSubscriptionRequest : IRequest<bool>
    {
        public string SubscriptionName { get; set; } = string.Empty;
        public int Price { get; set; }
    }
}