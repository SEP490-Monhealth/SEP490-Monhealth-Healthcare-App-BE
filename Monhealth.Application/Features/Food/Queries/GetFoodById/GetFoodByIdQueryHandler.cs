using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Food.Queries.GetFoodById
{
    public class GetFoodByIdQueryHandler : IRequestHandler<GetFoodByIdQuery, GetFoodByIdDTO>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public GetFoodByIdQueryHandler(IFoodRepository foodRepository,
        IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<GetFoodByIdDTO> Handle(GetFoodByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await _foodRepository.GetFoodByIdAsync(request.FoodId);
            return _mapper.Map<GetFoodByIdDTO>(query);
        }
    }
}