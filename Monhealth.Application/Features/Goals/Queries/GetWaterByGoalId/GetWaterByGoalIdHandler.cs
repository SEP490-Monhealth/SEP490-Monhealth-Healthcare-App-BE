using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Goals.Queries.GetWaterByGoalId
{
    public class GetWaterByGoalIdHandler(IMapper mapper, IGoalRepository goalRepository) : IRequestHandler<GetWaterByGoalIdQuery, GetWaterByGoalIdDTO>
    {
        public async Task<GetWaterByGoalIdDTO> Handle(GetWaterByGoalIdQuery request, CancellationToken cancellationToken)
        {
            var goals = await goalRepository.GetGoalsByUserIdAsync(request.UserId);
            var goal = goals.FirstOrDefault();
            return mapper.Map<GetWaterByGoalIdDTO>(goal);


        }
    }
}
