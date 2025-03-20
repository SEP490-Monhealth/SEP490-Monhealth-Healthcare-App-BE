using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetUserSubscriptionQueryHandler : IRequestHandler<GetUserSubScriptionQuery, GetUserSubscriptionByUserIdDTO>
    {
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;
        public GetUserSubscriptionQueryHandler(IUserSubscriptionRepository userSubscriptionRepository)
        {
            _userSubscriptionRepository = userSubscriptionRepository;
        }

        public async Task<GetUserSubscriptionByUserIdDTO> Handle(GetUserSubScriptionQuery request, CancellationToken cancellationToken)
        {
            var query = await _userSubscriptionRepository.GetByUserIdAsync(request.UserId);
            if (query == null)
            {
                // Handle the case where the subscription is not found
                return null; // Or return a default DTO with status like 'NotFound'
            }
            return new GetUserSubscriptionByUserIdDTO
            {
                SubscriptionId = query.SubscriptionId,
                UserSubscriptionId = query.UserSubscriptionId,
                StartedAt = query.StartedAt,
                ExpiresAt = query.ExpiresAt,
                RemainingBookings = query.RemainingBookings,
                Status = query.Status,
            };
        }

    }

}