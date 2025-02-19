using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseByUserId
{
    public class GetExerciseByUserIdDTO
    {
        public Guid ExerciseId { get; set; }
        [JsonPropertyName("name")]
        public string ExerciseName { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public float CaloriesPerMinute { get; set; }
        public bool Status { get; set; }
    }
}
