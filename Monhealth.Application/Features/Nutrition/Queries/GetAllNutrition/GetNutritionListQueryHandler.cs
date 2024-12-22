using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition
{
    public class GetNutritionListQueryHandler : IRequestHandler<GetNutritionListQuery, List<NutritionDto>>
    {
        private readonly INutritionRepository _nutritionRepository;
        private readonly IMapper _mapper;
        public GetNutritionListQueryHandler(INutritionRepository nutritionRepository, IMapper mapper)
        {
            _mapper = mapper;
            _nutritionRepository = nutritionRepository;
        }

        public async Task<List<NutritionDto>> Handle(GetNutritionListQuery request, CancellationToken cancellationToken)
        {
            var queries = await _nutritionRepository.GetAllNutritionAsync();
            return _mapper.Map<List<NutritionDto>>(queries);
        }
    }
}