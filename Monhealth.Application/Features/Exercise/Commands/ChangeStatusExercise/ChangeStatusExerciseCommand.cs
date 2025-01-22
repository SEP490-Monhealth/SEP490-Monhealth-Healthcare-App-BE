using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Exercise.Commands.ChangeStatusExercise
{
    public class ChangeStatusExerciseCommand : IRequest<bool>
    {
        public Guid ExerciseId { get; set; }
    }
}
