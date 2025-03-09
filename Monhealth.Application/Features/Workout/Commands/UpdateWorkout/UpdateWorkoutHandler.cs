using MediatR;

namespace Monhealth.Application
{
    public class UpdateWorkoutHandler : IRequest<Unit>
    {

        public Guid WorkoutId { get; set; }
        public UpdateWorkoutRequest Request { get; set; }
        public UpdateWorkoutHandler(Guid workoutId, UpdateWorkoutRequest request)
        {
            WorkoutId = workoutId;
            Request = request;
        }
    }
}