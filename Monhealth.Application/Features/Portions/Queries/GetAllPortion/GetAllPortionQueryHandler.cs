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
            var portions = await _portionRepository.GetAllPortionAsync(request.page, request.limit);
            var result = _mapper.Map<List<PortionDto>>(portions.Data).ToList();
            return new PageResult<PortionDto>()
            {
                CurrentPage = request.page,
                TotalPages = (int)Math.Ceiling(portions.TotalItems / (double)request.limit),
                TotalItems = portions.TotalItems,
                Data = result
            };
        }
    }
}
