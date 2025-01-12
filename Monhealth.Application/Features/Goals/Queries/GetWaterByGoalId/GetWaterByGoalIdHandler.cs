using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Goals.Queries.GetWaterByGoalId
{
    public class GetWaterByGoalIdHandler(IMapper mapper, IGoalRepository goalRepository) : IRequestHandler<GetWaterByGoalIdQuery, GetWaterByGoalIdDto>
    {
        public async Task<GetWaterByGoalIdDto> Handle(GetWaterByGoalIdQuery request, CancellationToken cancellationToken)
        {
            var goals = await goalRepository.GetGoalsByUserIdAsync(request.UserId);
            var goal = goals.FirstOrDefault();
            return mapper.Map<GetWaterByGoalIdDto>(goal);


        }
    }
}
