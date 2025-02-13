namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseByWorkoutId
{
    public class GetExerciseByWorkoutIdDto
    {
        public List<ExerciseDto> Warmup { get; set; }
        public List<ExerciseDto> Workout { get; set; }
    }
}
