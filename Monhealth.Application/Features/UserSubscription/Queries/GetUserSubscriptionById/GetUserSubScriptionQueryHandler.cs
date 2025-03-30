using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetUserSubScriptionQueryHandler(IUserSubscriptionRepository userSubscriptionRepository,
    IUserRepository userRepository) : IRequestHandler<GetUserSubscriptionRequest, GetUserSubscriptionDTO>
    {
        public async Task<GetUserSubscriptionDTO> Handle(GetUserSubscriptionRequest request, CancellationToken cancellationToken)
        {
            var query = await userSubscriptionRepository.GetUserSubscriptionByIdAsync(request.UserSubScriptionId);
            if (query == null)
            {
                throw new Exception("không tìm thấy UserSubscription");
            }
            var member = await userRepository.GetByIdAsync(query.UserId);
            var getUserSubscriptionDTO = new GetUserSubscriptionDTO(
                 query.UserSubscriptionId,
                 query.SubscriptionId,
                 new Member
                 {
                     AvatarUrl = member.Avatar,
                     Email = member.Email,
                     FullName = member.FullName,
                     PhoneNumber = member.FullName,
                 },
                  query.Subscription.SubscriptionName,
                  query.StartedAt,
                  query.ExpiresAt,
                  query.RemainingBookings,
                  query.Status,
                  query.CreatedAt,
                  query.UpdatedAt,
                  member.CreatedBy,
                  member.UpdatedBy
            );
            return getUserSubscriptionDTO;
        }
    }
}