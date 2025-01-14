using MediatR;

namespace Monhealth.Application.Features.Subscription.Commands.Create
{
    public class CreateSubscriptionCommand : IRequest<Unit>
    {
        public string SubscriptionName { get; set; } = string.Empty;
        public int Price { get; set; }

    }
}