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
            var exerciseWramupList = new List<Domain.Exercise>();
            Domain.Workout workoutWarmup = null;
            if (workout.WorkoutType != Core.Enum.WorkoutType.Warmup)
            {
                var workouts = (List<Domain.Workout>)await exerciseRepository.GetWorkoutByWorkoutType(workout);
                if (workouts.Any())
                {
                    //var randomIndex = new Random().Next(workouts.Count()); // Tạo random một lần
                    //workoutWarmup = workouts[randomIndex];
                    workoutWarmup = workouts.FirstOrDefault();
                }

            }
            if (workoutWarmup != null)
            {
                exerciseWramupList = (List<Domain.Exercise>)await exerciseRepository.GetExercisesByWorkoutIdAsync(workoutWarmup.WorkoutId);


            }

            var exercises = await exerciseRepository.GetExercisesByWorkoutIdAsync(request.WorkoutId);
            var response = new GetExerciseByWorkoutIdDto
            {
                Warmup = workoutWarmup != null ? mapper.Map<List<ExerciseDto>>(exerciseWramupList) : new List<ExerciseDto>(),
                Workout = mapper.Map<List<ExerciseDto>>(exercises.ToList())
            };
            return response;
        }
    }
}
