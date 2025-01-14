using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Subscription.Queries.GetDetail
{
    public class SubscriptionDetailQueryHandler : IRequestHandler<SubscriptionDetailQuery, SubscriptionDetailDTO>
    {
        private readonly ISubscriptionRepository _subscriptionRepository;
        private readonly IMapper _mapper;
        public SubscriptionDetailQueryHandler(ISubscriptionRepository subscriptionRepository,
        IMapper mapper)
        {
            _mapper = mapper;
            _subscriptionRepository = subscriptionRepository;
        }

        public async Task<SubscriptionDetailDTO> Handle(SubscriptionDetailQuery request, CancellationToken cancellationToken)
        {
            var subscriptionId = await _subscriptionRepository.GetByIdAsync(request.SubscriptionId);
            return _mapper.Map<SubscriptionDetailDTO>(subscriptionId);
        }
    }
}