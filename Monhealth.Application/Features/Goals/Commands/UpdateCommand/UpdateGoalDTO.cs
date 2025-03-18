using System.Text.Json.Serialization;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Goals.Commands.UpdateCommand
{
    public class UpdateGoalDTO
    {
        [JsonPropertyName("type")]
        public GoalType GoalType { get; set; }
        public int WeightGoal { get; set; }
    }
}
