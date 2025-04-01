using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application
{
    public class GetAllUserSubscriptionQueryHandler : IRequestHandler<GetAllUserSubscriptionQuery, PageResult<GetAllUserSubscriptionDTO>>
    {
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;
        private readonly IUserRepository _userRepository;
        public GetAllUserSubscriptionQueryHandler(IUserSubscriptionRepository userSubscriptionRepository,
        IUserRepository userRepository)
        {
            _userSubscriptionRepository = userSubscriptionRepository;
            _userRepository = userRepository;
        }
        public async Task<PageResult<GetAllUserSubscriptionDTO>> Handle(GetAllUserSubscriptionQuery request, CancellationToken cancellationToken)
        {
            var userSubscriptions =
            await _userSubscriptionRepository.GetPagedUserSubscriptionAsync(request.Page, request.Limit, request.Name, request.Search, request.Status);
            var userSubscriptionsList = new List<GetAllUserSubscriptionDTO>();
            foreach (var us in userSubscriptions.Items)
            {
                var user = await _userRepository.GetByIdAsync(us.UserId);
                var userSubscriptionDTO = new GetAllUserSubscriptionDTO
                {

                    UserSubscriptionId = us.UserSubscriptionId,
                    SubscriptionId = us.SubscriptionId,
                    SubscriptionName = us.Subscription.SubscriptionName,
                    StartedAt = us.StartedAt,
                    ExpiresAt = us.ExpiresAt,
                    RemainingBookings = us.RemainingBookings,
                    Status = us.Status,
                    CreatedAt = us.CreatedAt,
                    UpdatedAt = us.UpdatedAt,
                };
                if (user != null)
                {
                    userSubscriptionDTO.Member = new Member
                    {
                        AvatarUrl = user.Avatar,
                        Email = user.Email,
                        FullName = user.Email,
                        PhoneNumber = user.PhoneNumber
                    };
                }
                userSubscriptionsList.Add(userSubscriptionDTO);
            }
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