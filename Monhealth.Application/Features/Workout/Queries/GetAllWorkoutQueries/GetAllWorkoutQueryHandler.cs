using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Workout.Queries.GetAllWorkoutQueries
{
    public class GetAllWorkoutQueryHandler(IWorkoutRepository workoutRepository, IMapper mapper, IExerciseRepository exerciseRepository) : IRequestHandler<GetAllWorkoutQuery, PageResult<WorkoutDto>>
    {
        public async Task<PageResult<WorkoutDto>> Handle(GetAllWorkoutQuery request, CancellationToken cancellationToken)
        {
            var paginatedWorkout = await workoutRepository.GetAllWorkWithPaging(request.Page, request.Limit, request.CategoryName, request.Search, request.difficulty, request.Popular, request.Status, cancellationToken);

            var workoutDtos = new List<WorkoutDto>();
            Domain.Workout warmupWorkout = null;
            List<Domain.Exercise> exerciseWarmupList = null;

            foreach (var workout in paginatedWorkout.Items)
            {
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
                    exerciseWarmupList = (List<Domain.Exercise>?)await exerciseRepository.GetExercisesByWorkoutIdAsync(warmupWorkout.WorkoutId);
                }
                workoutDtos.Add(new WorkoutDto
                {
                    WorkoutId = workout.WorkoutId,
                    WorkoutType = workout.WorkoutType,
                    WorkoutName = workout.WorkoutName,
                    WorkoutDescription = workout.WorkoutDescription,
                    DifficultyLevel = workout.DifficultyLevel,
                    Exercises = (workout.WorkoutExercises?.Count() ?? 0) + (exerciseWarmupList?.Count() ?? 0), // Handle null lists
                    Duration = (((workout.WorkoutExercises?.Sum(we => (we?.DurationSeconds ?? 0) + ((we?.Reps ?? 0) * 2)) ?? 0) * 3) + ((warmupWorkout?.WorkoutExercises?.Sum(we => (we?.DurationSeconds ?? 0) + ((we?.Reps ?? 0) * 2)) ?? 0) * 2)) / 60, // Handle null values safely

                    CaloriesBurned = (float)(((workout.WorkoutExercises?.Sum(we =>
                      (we?.Exercise?.CaloriesPerMinute ?? 0) * ((we?.DurationSeconds ?? 0) / 60.0) +
                      (we?.Exercise?.CaloriesPerMinute ?? 0) * ((we?.Reps ?? 0) * 2) / 60.0
                                            ) ?? 0) * 3)
                         +
                        ((warmupWorkout?.WorkoutExercises?.Sum(we =>
                        (we?.Exercise?.CaloriesPerMinute ?? 0) * ((we?.DurationSeconds ?? 0) / 60.0) +
                        (we?.Exercise?.CaloriesPerMinute ?? 0) * ((we?.Reps ?? 0) * 2) / 60.0
                                            ) ?? 0) * 2))
                });
            }

            return new PageResult<WorkoutDto>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(paginatedWorkout.TotalCount / (double)request.Limit),
                TotalItems = paginatedWorkout.TotalCount,
                Items = workoutDtos
            };
        }
    }
}
