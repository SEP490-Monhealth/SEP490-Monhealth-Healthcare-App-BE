using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application
{
    public class GetAllUserSubscriptionQueryHandler : IRequestHandler<GetAllUserSubscriptionQuery, PageResult<GetAllUserSubscriptionDTO>>
    {
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;
        public GetAllUserSubscriptionQueryHandler(IUserSubscriptionRepository userSubscriptionRepository)
        {
            _userSubscriptionRepository = userSubscriptionRepository;
        }
        public async Task<PageResult<GetAllUserSubscriptionDTO>> Handle(GetAllUserSubscriptionQuery request, CancellationToken cancellationToken)
        {
            var userSubscriptions =
            await _userSubscriptionRepository.GetPagedUserSubscriptionAsync(request.Page, request.Limit);
            var userSubscriptionsList =
            userSubscriptions.Items.Select(us => new GetAllUserSubscriptionDTO
            {
                UserSubscriptionId = us.UserSubscriptionId,
                FullName = us.User.FullName,
                Email = us.User.Email,
                PhoneNumber = us.User.PhoneNumber,
                AvatarUrl = us.User.Avatar,
                SubscriptionName = us.Subscription.SubscriptionName,
                StartedAt = us.StartedAt,
                ExpiresAt = us.ExpiresAt,
                RemainingBookings = us.RemainingBookings,
                Status = us.Status,
                CreatedAt = us.CreatedAt,
                UpdatedAt = us.UpdatedAt
            }).ToList();
            return new PageResult<GetAllUserSubscriptionDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(userSubscriptions.TotalCount / (double)request.Limit),
                TotalItems = userSubscriptions.TotalCount,
                Items = userSubscriptionsList
            };
            
        }
    }

}