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

            var exerciseLists = new List<string>();


            List<Guid> exerciseList = exerciseLists.Select(Guid.Parse).ToList();
            var exerciseWramupList = await exerciseRepository.GetExercisesByListId(exerciseList);
            var exercises = await exerciseRepository.GetExercisesByWorkoutIdAsync(request.WorkoutId);
            var response = new GetExerciseByWorkoutIdDto
            {
                Warmup = mapper.Map<List<ExerciseDto>>(exerciseWramupList.ToList()),
                Workout = mapper.Map<List<ExerciseDto>>(exercises.ToList())
            };
            return response;
        }
    }
}
