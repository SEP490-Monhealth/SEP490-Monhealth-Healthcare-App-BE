using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoods
{
    public class GetFoodListQueryHandler : IRequestHandler<GetFoodListQuery, List<FoodDTO>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public GetFoodListQueryHandler(IFoodRepository foodRepository, IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<List<FoodDTO>> Handle(GetFoodListQuery request, CancellationToken cancellationToken)
        {
            var foods = await _foodRepository.GetAllFoodAsync();
            return _mapper.Map<List<FoodDTO>>(foods);
        }
    }
}