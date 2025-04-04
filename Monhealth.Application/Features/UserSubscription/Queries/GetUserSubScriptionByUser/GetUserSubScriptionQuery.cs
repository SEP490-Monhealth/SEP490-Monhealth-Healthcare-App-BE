using MediatR;

namespace Monhealth.Application
{
    public class GetUserSubscriptionQuery : IRequest<GetUserSubscriptionByUserIdDTO>
    {
        public Guid UserId { get; set; }
    }
}