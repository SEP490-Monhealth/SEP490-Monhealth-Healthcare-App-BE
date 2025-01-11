using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Goals.Queries.GetWaterByGoalId
{
    public class GetWaterByGoalIdHandler(IMapper mapper, IGoalRepository goalRepository) : IRequestHandler<GetWaterByGoalIdQuery, GetWaterByGoalIdDto>
    {
        public async Task<GetWaterByGoalIdDto> Handle(GetWaterByGoalIdQuery request, CancellationToken cancellationToken)
        {
            var goal = await goalRepository.GetByIdAsync(request.GoalId);
            return mapper.Map<GetWaterByGoalIdDto>(goal);


        }
    }
}
