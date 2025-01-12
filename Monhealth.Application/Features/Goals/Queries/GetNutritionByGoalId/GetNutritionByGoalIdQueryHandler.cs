using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Goals.Queries.GetNutritionByGoalId
{
    public class GetNutritionByGoalIdQueryHandler(IMapper mapper, IGoalRepository goalRepository) : IRequestHandler<GetNutritionByGoalIdQuery, GetNutritionByGoalIdDto>
    {
        public async Task<GetNutritionByGoalIdDto> Handle(GetNutritionByGoalIdQuery request, CancellationToken cancellationToken)
        {
            var goals = await goalRepository.GetGoalsByUserIdAsync(request.UserId);
            var goal = goals.FirstOrDefault();
            return mapper.Map<GetNutritionByGoalIdDto>(goal);
        }
    }
}
