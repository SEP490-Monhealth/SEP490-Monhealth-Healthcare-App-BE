using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Goals.Queries.GetWeightByGoalId
{
    public class GetWeightByGoalIdQueryHandler(IMapper mapper, IGoalRepository goalRepository) : IRequestHandler<GetWeightByGoalIdQuery, GetWeightByGoalIdDTO>
    {
        public async Task<GetWeightByGoalIdDTO> Handle(GetWeightByGoalIdQuery request, CancellationToken cancellationToken)
        {
            var goals = await goalRepository.GetGoalsByUserIdAsync(request.UserId);
            var goal = goals.FirstOrDefault();
            return mapper.Map<GetWeightByGoalIdDTO>(goal);
        }
    }
}
