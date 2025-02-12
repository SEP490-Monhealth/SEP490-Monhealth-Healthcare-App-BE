namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseByWorkoutId
{
    public class GetExerciseByWorkoutIdDto
    {
        public List<ExerciseDto> WarmUp { get; set; }
        public List<ExerciseDto> Exercise { get; set; }
    }
}
