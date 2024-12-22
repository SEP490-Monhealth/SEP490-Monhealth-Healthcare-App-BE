using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition;

namespace Monhealth.Application.Features.Nutrition.Queries.GetAllNutritionByfoodId
{
    public class GetNutritionByFoodIdHandler : IRequestHandler<GetNutritionByFoodIdListQuery, List<NutritionByFoodIdDto>>
    {
        private readonly INutritionRepository _nutritionRepository;
        private readonly IMapper _mapper;
        public GetNutritionByFoodIdHandler(INutritionRepository nutritionRepository, IMapper mapper)
        {
            _mapper = mapper;
            _nutritionRepository = nutritionRepository;
        }

        public async Task<List<NutritionByFoodIdDto>> Handle(GetNutritionByFoodIdListQuery request, CancellationToken cancellationToken)
        {
            var query = await _nutritionRepository.GetAllNutritionByFoodIdAsync(request.FoodId);
            if (query == null) throw new Exception("Not found food.");
            return _mapper.Map<List<NutritionByFoodIdDto>>(query);
        }
    }
}