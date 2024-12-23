using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Queries.GetPortionsByFoodId
{
    public class GetPortionsByFoodIdQueryHandler : IRequestHandler<GetPortionsByFoodIdQuery, List<GetPortionsByFoodIdDto>>
    {
        private readonly IPortionRepository _portionRepository;
        private readonly IMapper _mapper;
        public GetPortionsByFoodIdQueryHandler(IPortionRepository portionRepository, IMapper mapper)
        {
            _portionRepository = portionRepository;
            _mapper = mapper;
        }
        public async Task<List<GetPortionsByFoodIdDto>> Handle(GetPortionsByFoodIdQuery request, CancellationToken cancellationToken)
        {
            var listPortions = await _portionRepository.GetPortionsByFoodIdAsync(request.FoodId);
            return _mapper.Map<List<GetPortionsByFoodIdDto>>(listPortions);
        }
    }
}
