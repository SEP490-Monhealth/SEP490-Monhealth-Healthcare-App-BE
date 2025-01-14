using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Subscription.Queries.GetAll
{
    public class GetAllSubscriptionQueryHandler : IRequestHandler<GetAllSubscriptionQuery, List<SubscriptionDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ISubscriptionRepository _subscriptionRepository;

        public GetAllSubscriptionQueryHandler(IMapper mapper,
        ISubscriptionRepository subscriptionRepository)
        {
            _mapper = mapper;
            _subscriptionRepository = subscriptionRepository;
        }

        public async Task<List<SubscriptionDTO>> Handle(GetAllSubscriptionQuery request, CancellationToken cancellationToken)
        {
           var queries = await _subscriptionRepository.GetAllAsync();
            return _mapper.Map<List<SubscriptionDTO>>(queries);
        }
    }
}