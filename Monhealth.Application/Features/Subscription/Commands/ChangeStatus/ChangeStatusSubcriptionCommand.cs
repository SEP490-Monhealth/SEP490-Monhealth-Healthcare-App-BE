using MediatR;

namespace Monhealth.Application.Features.Subscription.Commands.ChangeStatus
{
    public class ChangeStatusSubscriptionCommand : IRequest<bool>
    {
        public Guid SubscriptionId { get; set; }
    }
}
