using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Exercise.Commands.DeleteExercise
{
    public class DeleteExerciseCommand : IRequest<bool>
    {
        public Guid ExerciseId { get; set; }
    }
}
