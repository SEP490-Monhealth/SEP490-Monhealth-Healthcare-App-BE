using MediatR;

namespace Monhealth.Application.Features.Subscription.Queries.GetAll
{
    public class GetAllSubscriptionQuery : IRequest<List<SubscriptionDTO>>
    {

    }
}