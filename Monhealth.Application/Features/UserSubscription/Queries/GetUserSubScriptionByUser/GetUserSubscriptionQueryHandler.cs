using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetUserSubscriptionQueryHandler : IRequestHandler<GetUserSubscriptionQuery, List<GetUserSubscriptionByUserIdDTO>>
    {
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;
        public GetUserSubscriptionQueryHandler(IUserSubscriptionRepository userSubscriptionRepository)
        {
            _userSubscriptionRepository = userSubscriptionRepository;
        }

        public async Task<List<GetUserSubscriptionByUserIdDTO>> Handle(GetUserSubscriptionQuery request, CancellationToken cancellationToken)
        {
            var query = await _userSubscriptionRepository.GetUserSubcriptionByUserIdAsync(request.UserId);
            if (query == null)
            {
                // Handle the case where the subscription is not found
                return null; // Or return a default DTO with status like 'NotFound'
            }
            //return new GetUserSubscriptionByUserIdDTO
            //{
            //    SubscriptionId = query.SubscriptionId,
            //    UserSubscriptionId = query.UserSubscriptionId,
            //    StartedAt = query.StartedAt,
            //    ExpiresAt = query.ExpiresAt,
            //    RemainingBookings = query.RemainingBookings,
            //    Status = query.Status,
            //};
            var result = query.Select(s => new GetUserSubscriptionByUserIdDTO
            {
                SubscriptionId = s.SubscriptionId,
                UserId = s.UserId,
                UserSubscriptionId = s.UserSubscriptionId,
                StartedAt = s.StartedAt,
                ExpiresAt = s.ExpiresAt,
                RemainingBookings = s.RemainingBookings,
                Status = s.Status,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt,
            }).ToList();

            return result;
        }

    }

}