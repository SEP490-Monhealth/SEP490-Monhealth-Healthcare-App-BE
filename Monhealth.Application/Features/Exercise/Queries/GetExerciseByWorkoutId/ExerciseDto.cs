using Monhealth.Domain.Enum;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseByWorkoutId
{
    public class ExerciseDto
    {
        public Guid ExerciseId { get; set; }
        [JsonPropertyName("type")]
        public ExerciseType ExerciseType { get; set; }
        [JsonPropertyName("name")]
        public string ExerciseName { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public int Duration { get; set; }
        public int Reps { get; set; }
        public float CaloriesPerMinute { get; set; }
    }
}
