using System.Text.Json.Serialization;
using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseById
{
    public class GetExerciseByIdDTO : BaseEntity
    {
        public Guid UserId { get; set; }
        [JsonPropertyName("category")]
        public ExerciseType ExerciseType { get; set; }
        [JsonPropertyName("name")]
        public string ExerciseName { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public float CaloriesPerMinute { get; set; }
        public bool Status { get; set; }
    }
}
