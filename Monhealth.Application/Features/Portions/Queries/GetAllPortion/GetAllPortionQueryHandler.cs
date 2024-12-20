using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion
{
    public class GetAllPortionQueryHandler : IRequestHandler<GetAllPortionQuery, List<PortionDto>>
    {
        private readonly IMapper _mapper;
        private readonly IPortionRepository _portionRepository;
        public GetAllPortionQueryHandler(IMapper mapper, IPortionRepository portionRepository)
        {
            _mapper = mapper;
            _portionRepository = portionRepository;
        }
        public async Task<List<PortionDto>> Handle(GetAllPortionQuery request, CancellationToken cancellationToken)
        {
            var portions = await _portionRepository.GetAllPortionAsync(request.sort, request.order);
            var result = _mapper.Map<List<PortionDto>>(portions);
            return result;
        }
    }
}
