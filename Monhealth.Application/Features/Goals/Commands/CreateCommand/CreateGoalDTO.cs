using System.Text.Json.Serialization;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Goals.Commands.CreateCommand
{
    public class CreateGoalDTO
    {
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public GoalType GoalType { get; set; }
        public int WeightGoal { get; set; }
        public float CaloriesGoal { get; set; }
        public float ProteinGoal { get; set; }
        public float CarbsGoal { get; set; }
        public float FatGoal { get; set; }
        public float FiberGoal { get; set; }
        public float SugarGoal { get; set; }
        public int WaterIntakesGoal { get; set; }
        public float ExerciseGoal { get; set; }
    }
}
