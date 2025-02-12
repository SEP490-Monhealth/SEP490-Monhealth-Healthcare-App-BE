using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseByWorkoutId
{
    public class GetExerciseByWorkoutIdHandler(IWorkoutRepository workoutRepository, IMapper mapper,
                IExerciseRepository exerciseRepository
        ) : IRequestHandler<GetExerciseByWorkoutIdQuery, GetExerciseByWorkoutIdDto>
    {
        public async Task<GetExerciseByWorkoutIdDto> Handle(GetExerciseByWorkoutIdQuery request, CancellationToken cancellationToken)
        {
            var workout = await workoutRepository.GetWorkoutByIdAsync(request.WorkoutId);
            if (workout == null) throw new Exception("Không tìm thấy bài tập");

            var exercises = await exerciseRepository.GetExercisesByWorkoutIdAsync(request.WorkoutId);
            var response = new GetExerciseByWorkoutIdDto
            {
                WarmUp = null,
                Exercise = mapper.Map<List<ExerciseDto>>(exercises)
            };
            return response;
        }
    }
}
