using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Food.Queries.GetFoodsByCategory
{
    public class GetFoodListByCategoryHandler : IRequestHandler<GetFoodListQueryByCategoryQuery, List<GetFoodByCategoryDTO>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public GetFoodListByCategoryHandler(IFoodRepository foodRepository,
        IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<List<GetFoodByCategoryDTO>> Handle(GetFoodListQueryByCategoryQuery request, CancellationToken cancellationToken)
        {
            var queries = await _foodRepository.GetFoodByCategoryName(request.CategoryName);
            return _mapper.Map<List<GetFoodByCategoryDTO>>(queries);
        }
    }
}