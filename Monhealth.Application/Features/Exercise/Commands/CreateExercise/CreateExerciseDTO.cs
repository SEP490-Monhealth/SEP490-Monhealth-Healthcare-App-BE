using System.Text.Json.Serialization;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Exercise.Commands.CreateExercise
{
    public class CreateExerciseDTO
    {
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public ExerciseType ExerciseType { get; set; }
        [JsonPropertyName("name")]
        public string ExerciseName { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public float CaloriesPerMinute { get; set; }
    }
}
