using System.Text.Json.Serialization;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Workout.Queries.GetWorkoutByUserIdQueries
{
    public class GetWorkoutByUserIdDTO
    {
        public Guid WorkoutId { get; set; }
        [JsonPropertyName("type")]
        public WorkoutType WorkoutType { get; set; }
        [JsonPropertyName("name")]
        public string WorkoutName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string WorkoutDescription { get; set; } = string.Empty;
        public DifficultyLevel DifficultyLevel { get; set; }
        public int Exercises { get; set; }
        public int DurationMinutes { get; set; }
        public float CaloriesBurned { get; set; }
    }
}
