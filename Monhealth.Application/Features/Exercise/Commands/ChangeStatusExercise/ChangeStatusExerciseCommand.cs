﻿using MediatR;

namespace Monhealth.Application.Features.Exercise.Commands.ChangeStatusExercise
{
    public class ChangeStatusExerciseCommand : IRequest<bool>
    {
        public Guid ExerciseId { get; set; }
    }
}
