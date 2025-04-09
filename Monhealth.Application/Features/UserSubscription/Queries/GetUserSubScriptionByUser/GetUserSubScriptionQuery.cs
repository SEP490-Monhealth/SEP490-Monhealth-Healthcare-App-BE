using MediatR;

namespace Monhealth.Application
{
    public class GetUserSubscriptionQuery : IRequest<List<GetUserSubscriptionByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}