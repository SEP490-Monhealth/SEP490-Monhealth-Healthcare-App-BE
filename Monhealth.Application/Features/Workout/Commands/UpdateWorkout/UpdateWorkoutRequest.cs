using System.Text.Json.Serialization;
using MediatR;
using Monhealth.Application.Features.Workout.Commands.CreateWorkout;
using Monhealth.Core.Enum;

namespace Monhealth.Application
{
    public class UpdateWorkoutRequest : IRequest<Unit>
    {
        public Guid CategoryId { get; set; }
        [JsonPropertyName("name")]
        public string WorkoutName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string WorkoutDescription { get; set; } = string.Empty;
        public DifficultyLevel DifficultyLevel { get; set; }
        public List<CreateExcerciseDto> Items { get; set; }

    }
}