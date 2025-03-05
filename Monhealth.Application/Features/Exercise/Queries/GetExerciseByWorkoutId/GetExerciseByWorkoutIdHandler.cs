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

            List<Domain.Exercise> exerciseWarmupList = new();
            Domain.Workout? workoutWarmup = null;

            if (workout.WorkoutType != Core.Enum.WorkoutType.Warmup)
            {
                var warmupWorkouts = await exerciseRepository.GetWorkoutByWorkoutType(workout);
                workoutWarmup = warmupWorkouts.FirstOrDefault();
            }

            if (workoutWarmup != null)
            {
                exerciseWarmupList = (List<Domain.Exercise>)await exerciseRepository.GetExercisesByWorkoutIdAsync(workoutWarmup.WorkoutId);
            }

            int totalWarmupDuration = exerciseWarmupList
                .Sum(ex => ex.WorkoutExercises?.Sum(we => (we?.DurationSeconds ?? 0) + ((we?.Reps ?? 0) * 2)) ?? 0);
            totalWarmupDuration *= 2; //warmUp x2 round
            var exercises = (List<Domain.Exercise>)await exerciseRepository.GetExercisesByWorkoutIdAsync(request.WorkoutId);

            int totalExerciseDuration = exercises
                .Sum(ex => ex.WorkoutExercises?.Sum(we => (we?.DurationSeconds ?? 0) + ((we?.Reps ?? 0) * 2)) ?? 0);
            totalExerciseDuration *= 3; // Exercise X3 round
            return new GetExerciseByWorkoutIdDto
            {
                Warmup = workoutWarmup != null ? mapper.Map<List<ExerciseDto>>(exerciseWarmupList) : new List<ExerciseDto>(),
                Workout = mapper.Map<List<ExerciseDto>>(exercises),
                WarmupDuration = totalWarmupDuration,
                WorkoutDuration = totalExerciseDuration
            };
        }
    }
}
