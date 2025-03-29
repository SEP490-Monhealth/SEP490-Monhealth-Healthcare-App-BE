using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion
{
    public class GetAllPortionQueryHandler : IRequestHandler<GetAllPortionQuery, PageResult<PortionDto>>
    {
        private readonly IMapper _mapper;
        private readonly IPortionRepository _portionRepository;
        public GetAllPortionQueryHandler(IMapper mapper, IPortionRepository portionRepository)
        {
            _mapper = mapper;
            _portionRepository = portionRepository;
        }
        public async Task<PageResult<PortionDto>> Handle(GetAllPortionQuery request, CancellationToken cancellationToken)
        {
            var pagingPortions = await _portionRepository.GetAllPortionAsync(request.Page, request.Limit, request.sort, request.order);
            return new PageResult<PortionDto>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(pagingPortions.TotalCount / (double)request.Limit),
                TotalItems = pagingPortions.TotalCount,
                Items = _mapper.Map<List<PortionDto>>(pagingPortions.Items)
            };
        }
    }
}
