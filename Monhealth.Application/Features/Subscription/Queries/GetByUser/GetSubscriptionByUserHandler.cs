using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Subscription.Queries.GetByUser
{
    public class GetSubscriptionByUserHandler : IRequestHandler<GetSubscriptionByUserQuery, List<SubscriptionByUserDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;
        public GetSubscriptionByUserHandler(IMapper mapper,
        IUserSubscriptionRepository userSubscriptionRepository)
        {
            _mapper = mapper;
            _userSubscriptionRepository = userSubscriptionRepository;
        }

        public async Task<List<SubscriptionByUserDTO>> Handle(GetSubscriptionByUserQuery request, CancellationToken cancellationToken)
        {
            var query = await _userSubscriptionRepository.GetUserSubscription(request.Userid);
            return _mapper.Map<List<SubscriptionByUserDTO>>(query);
        }
    }
}