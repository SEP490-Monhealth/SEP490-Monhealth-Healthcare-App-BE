using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Workout.Commands.DeleteWorkout
{
    public class DeleteWorkoutCommand : IRequest<bool>
    {
        public Guid WorkoutId { get; set; }
    }
}
