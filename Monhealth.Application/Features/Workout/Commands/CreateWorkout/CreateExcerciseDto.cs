namespace Monhealth.Application.Features.Workout.Commands.CreateWorkout
{
    public class CreateExcerciseDto
    {
        public Guid ExerciseId { get; set; }
        public int Duration { get; set; }
        public int Reps { get; set; }
    }
}
