using MediatR;

namespace Monhealth.Application.Features.Subscription.Commands.Delete
{
    public class DeleteSubscriptionRequest : IRequest<bool>
    {
        public Guid SubscriptionId { get; set; }
    }
}