using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoodsByFoodType
{
    public class GetFoodDetailByFoodTypeQueryHandler : IRequestHandler<GetFoodDetailByFoodTypeQuery, List<FoodDetailByFoodTypeDTO>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;
        public GetFoodDetailByFoodTypeQueryHandler(IFoodRepository foodRepository
        , IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<List<FoodDetailByFoodTypeDTO>> Handle(GetFoodDetailByFoodTypeQuery request, CancellationToken cancellationToken)
        {
            var foods = await _foodRepository.GetFoodListByFoodType(request.foodType);
            return _mapper.Map<List<FoodDetailByFoodTypeDTO>>(foods);
        }
    }
}