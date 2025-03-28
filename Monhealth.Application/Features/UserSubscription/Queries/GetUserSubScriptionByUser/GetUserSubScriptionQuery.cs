using MediatR;

namespace Monhealth.Application
{
    public class GetUserSubScriptionQuery : IRequest<GetUserSubscriptionByUserIdDTO>
    {
        public Guid UserId { get; set; }
    
    }
}