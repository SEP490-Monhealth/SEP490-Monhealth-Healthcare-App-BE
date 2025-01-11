using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Goals.Commands.CreateCommand
{
    public class CreateGoalDTO
    {
        public Guid UserId { get; set; }
        public string GoalType { get; set; }
        public int WeightGoal { get; set; }
        public float CaloriesGoal { get; set; }
        public float ProteinGoal { get; set; }
        [JsonPropertyName("carbsGoal")]
        public float CarbGoal { get; set; }
        public float FatGoal { get; set; }
        public float FiberGoal { get; set; }
        public float SugarGoal { get; set; }
        public int WaterGoal { get; set; }
        public float ExerciseGoal { get; set; }
    }
}
