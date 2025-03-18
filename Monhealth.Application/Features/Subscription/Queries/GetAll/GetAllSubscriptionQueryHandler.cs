using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Subscription.Queries.GetAll
{
    public class GetAllSubscriptionQueryHandler : IRequestHandler<GetAllSubscriptionQuery, PageResult<SubscriptionDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ISubscriptionRepository _subscriptionRepository;

        public GetAllSubscriptionQueryHandler(IMapper mapper,
        ISubscriptionRepository subscriptionRepository)
        {
            _mapper = mapper;
            _subscriptionRepository = subscriptionRepository;
        }


        async Task<PageResult<SubscriptionDTO>> IRequestHandler<GetAllSubscriptionQuery, PageResult<SubscriptionDTO>>.Handle(GetAllSubscriptionQuery request, CancellationToken cancellationToken)
        {
            var pagingSubcription = await _subscriptionRepository.GetAllSubcriptionAsync(request.Page, request.Limit, request.Search, request.Sort, request.Status);

            return new PageResult<SubscriptionDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(pagingSubcription.TotalCount / (double)request.Limit),
                TotalItems = pagingSubcription.TotalCount,
                Items = _mapper.Map<List<SubscriptionDTO>>(pagingSubcription.Items)
            };
        }
    }
}