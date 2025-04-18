﻿using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Workout.Commands.CreateWorkout
{
    public class CreateWorkoutCommandHandler(IMapper mapper, IWorkoutRepository workoutRepository,
        IWorkoutExcerciseRepository workoutExcerciseRepository,
        ICategoryRepository categoryRepository,
        IUserRepository userRepository

        )
        : IRequestHandler<CreateWorkoutCommand, Guid>
    {

        public async Task<Guid> Handle(CreateWorkoutCommand request, CancellationToken cancellationToken)
        {
            var category = await categoryRepository.GetCategoryByCategoryName(request.CategoryName);
            if (category == null) throw new Exception("CategoryName không tìm thấy");
            var user = await userRepository.GetByIdAsync(request.UserId);
            if (user == null) throw new Exception("UserId không tìm thấy");

            var existWorkout = await workoutRepository.ExistWorkoutName(request.WorkoutName, request.UserId);
            if (existWorkout) throw new Exception("Tên Bài tập này đã tồn tại");

            var workout = mapper.Map<Domain.Workout>(request);
            //int durationTotal = 0;
            //int caloriesBurnedTotoal = 0;
            workout.WorkoutId = Guid.NewGuid();
            workout.CategoryId = category.CategoryId;
            workoutRepository.Add(workout);

            var workoutExcercises = mapper.Map<List<WorkoutExercise>>(request.Items);

            foreach (var exercise in workoutExcercises)
            {
                exercise.WorkoutId = workout.WorkoutId;
                exercise.Order++;
                // durationTotal = exercise.DurationSeconds + exercise.Reps * 2;

            }
            workoutExcerciseRepository.AddRange(workoutExcercises);

            await workoutRepository.SaveChangeAsync(cancellationToken);
            return workout.WorkoutId;
        }
    }
}
