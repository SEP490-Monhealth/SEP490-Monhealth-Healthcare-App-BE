using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Exercise.Commands.UpdateExercise
{
    public class UpdateExerciseDTO
    {
        [JsonPropertyName("name")]
        public string ExerciseName { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public float CaloriesPerMinute { get; set; }
    }
}
