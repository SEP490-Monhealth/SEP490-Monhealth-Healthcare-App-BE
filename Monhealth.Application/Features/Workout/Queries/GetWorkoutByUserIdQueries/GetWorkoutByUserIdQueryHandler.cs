using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Workout.Queries.GetWorkoutByUserIdQueries
{
    public class GetWorkoutByUserIdQueryHandler(IWorkoutRepository workoutRepository, IMapper mapper) : IRequestHandler<GetWorkoutByUserIdQuery, List<GetWorkoutByUserIdDTO>>
    {
        public async Task<List<GetWorkoutByUserIdDTO>> Handle(GetWorkoutByUserIdQuery request, CancellationToken cancellationToken)
        {
            var listWorkout = await workoutRepository.GetWorkoutsByUser(request.UserId);
            return mapper.Map<List<GetWorkoutByUserIdDTO>>(listWorkout);
        }
    }
}
