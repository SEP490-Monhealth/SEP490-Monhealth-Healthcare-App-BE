using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Goals.Queries.GetExerciseByGoalId
{
    public class GetExerciseByGoalIdQueryHandler(IMapper mapper, IGoalRepository goalRepository) : IRequestHandler<GetExerciseByGoalIdQuery, GetExerciseByGoalIdDto>
    {
        public async Task<GetExerciseByGoalIdDto> Handle(GetExerciseByGoalIdQuery request, CancellationToken cancellationToken)
        {
            var goal = await goalRepository.GetByIdAsync(request.GoalId);
            return mapper.Map<GetExerciseByGoalIdDto>(goal);
        }
    }
}
