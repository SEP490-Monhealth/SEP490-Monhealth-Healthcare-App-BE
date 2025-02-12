using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Workout.Queries.GetAllWorkoutQueries;

namespace Monhealth.Application.Features.Workout.Queries.GetWorkoutByIdQueries
{
    public class GetWorkoutByIdQueryHandler(IWorkoutRepository workoutRepository, IMapper mapper) : IRequestHandler<GetWorkoutByIdQuery, WorkoutDto>
    {
        public async Task<WorkoutDto> Handle(GetWorkoutByIdQuery request, CancellationToken cancellationToken)
        {
            var workout = await workoutRepository.GetWorkoutByIdAsync(request.WorkoutId);
            if (workout == null) throw new Exception("Không tìm thấy bài tập");
            return mapper.Map<WorkoutDto>(workout);
        }
    }
}
