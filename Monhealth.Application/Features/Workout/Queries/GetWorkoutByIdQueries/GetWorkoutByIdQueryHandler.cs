using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Workout.Queries.GetAllWorkoutQueries;

namespace Monhealth.Application.Features.Workout.Queries.GetWorkoutByIdQueries
{
    public class GetWorkoutByIdQueryHandler(IWorkoutRepository workoutRepository, IMapper mapper, IExerciseRepository exerciseRepository) : IRequestHandler<GetWorkoutByIdQuery, WorkoutDto>
    {
        public async Task<WorkoutDto> Handle(GetWorkoutByIdQuery request, CancellationToken cancellationToken)
        {
            var workout = await workoutRepository.GetWorkoutByIdAsync(request.WorkoutId);
            if (workout == null) throw new Exception("Không tìm thấy bài tập");
            List<Domain.Exercise> exerciseWramupList = null;
            Domain.Workout warmupWorkout = null;

            if (workout.WorkoutType != Core.Enum.WorkoutType.Warmup)
            {
                var warmupWorkouts = (List<Domain.Workout>)await exerciseRepository.GetWorkoutByWorkoutType(workout);
                if (warmupWorkouts.Any())
                {
                    warmupWorkout = warmupWorkouts.FirstOrDefault();
                }

            }
            if (warmupWorkout != null)
            {
                exerciseWramupList = (List<Domain.Exercise>?)await exerciseRepository.GetExercisesByWorkoutIdAsync(warmupWorkout.WorkoutId);
            }

            return new WorkoutDto
            {
                WorkoutId = workout.WorkoutId,
                WorkoutType = workout.WorkoutType,
                WorkoutName = workout.WorkoutName,
                WorkoutDescription = workout.WorkoutDescription,
                DifficultyLevel = workout.DifficultyLevel,
                IsPublic = workout.IsPublic,
                Status = workout.Status,
                CreatedAt = workout.CreatedAt,
                UpdatedAt = workout.UpdatedAt,
                CreatedBy = workout.CreatedBy,
                UpdatedBy = workout.UpdatedBy,
                Exercises = (workout.WorkoutExercises?.Count() ?? 0) + (exerciseWramupList?.Count() ?? 0), // Handle null lists
                DurationMinutes = ((workout.WorkoutExercises?.Sum(we => (we?.DurationSeconds ?? 0) + ((we?.Reps ?? 0) * 2)) ?? 0) * 3) + ((warmupWorkout?.WorkoutExercises?.Sum(we => (we?.DurationSeconds ?? 0) + ((we?.Reps ?? 0) * 2)) ?? 0) * 2), // Handle null values safely

                CaloriesBurned = (float)(((workout.WorkoutExercises?.Sum(we =>
                    (we?.Exercise?.CaloriesPerMinute ?? 0) * ((we?.DurationSeconds ?? 0) / 60.0) +
                    (we?.Exercise?.CaloriesPerMinute ?? 0) * ((we?.Reps ?? 0) * 2) / 60.0
                                            ) ?? 0) * 3)
                         +
                        ((warmupWorkout?.WorkoutExercises?.Sum(we =>
                        (we?.Exercise?.CaloriesPerMinute ?? 0) * ((we?.DurationSeconds ?? 0) / 60.0) +
                        (we?.Exercise?.CaloriesPerMinute ?? 0) * ((we?.Reps ?? 0) * 2) / 60.0
                                            ) ?? 0) * 2))
            };
        }
    }
}
