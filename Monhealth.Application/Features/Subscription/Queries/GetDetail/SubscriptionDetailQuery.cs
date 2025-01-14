using MediatR;

namespace Monhealth.Application.Features.Subscription.Queries.GetDetail
{
    public class SubscriptionDetailQuery : IRequest<SubscriptionDetailDTO>
    {
        public Guid SubscriptionId { get; set; }
    }
}