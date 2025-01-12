using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Goals.Queries.GetWeightByGoalId
{
    public class GetWeightByGoalIdQueryHandler(IMapper mapper, IGoalRepository goalRepository) : IRequestHandler<GetWeightByGoalIdQuery, GetWeightByGoalIdDto>
    {
        public async Task<GetWeightByGoalIdDto> Handle(GetWeightByGoalIdQuery request, CancellationToken cancellationToken)
        {
            var goals = await goalRepository.GetGoalsByUserIdAsync(request.UserId);
            var goal = goals.FirstOrDefault();
            return mapper.Map<GetWeightByGoalIdDto>(goal);
        }
    }
}
