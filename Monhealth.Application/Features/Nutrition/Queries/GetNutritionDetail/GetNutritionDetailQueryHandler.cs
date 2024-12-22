using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Nutrition.Queries.GetNutritionDetail
{
    public class GetNutritionDetailQueryHandler : IRequestHandler<GetNutritionDetailQuery, NutritionDetailDto>
    {
        private readonly IMapper _mapper;
        private readonly INutritionRepository _nutritionRepository;

        public GetNutritionDetailQueryHandler(IMapper mapper, INutritionRepository nutritionRepository)
        {
            _mapper = mapper;
            _nutritionRepository = nutritionRepository;
        }

        public async Task<NutritionDetailDto> Handle(GetNutritionDetailQuery request, CancellationToken cancellationToken)
        {
            var query = await _nutritionRepository.GetByIdAsync(request.NutritionId);
            if (query == null) { throw new Exception("Not found nutrition"); }
            return _mapper.Map<NutritionDetailDto>(query);
        }
    }
}