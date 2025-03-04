namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseByWorkoutId
{
    public class GetExerciseByWorkoutIdDto
    {
        public int WarmupDuration { get; set; }
        public int WorkoutDuration { get; set; }
        public List<ExerciseDto> Warmup { get; set; }
        public List<ExerciseDto> Workout { get; set; }
    }
}
