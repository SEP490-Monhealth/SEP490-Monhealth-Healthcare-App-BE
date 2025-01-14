using MediatR;

namespace Monhealth.Application.Features.Subscription.Queries.GetByUser
{
    public class GetSubscriptionByUserQuery : IRequest<List<SubscriptionByUserDTO>>
    {
        public Guid Userid { get; set; }
    }
}