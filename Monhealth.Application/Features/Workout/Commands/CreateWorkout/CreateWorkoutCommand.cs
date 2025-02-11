﻿using MediatR;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Workout.Commands.CreateWorkout
{
    public class CreateWorkoutCommand : IRequest<Guid>
    {
        public Guid CategoryId { get; set; }
        public Guid UserId { get; set; }
        public string WorkoutName { get; set; } = string.Empty;
        public string WorkoutDescription { get; set; } = string.Empty;
        public DifficultyLevel DifficultyLevel { get; set; }
        public List<CreateExcerciseDto> Items { get; set; }
    }
}
