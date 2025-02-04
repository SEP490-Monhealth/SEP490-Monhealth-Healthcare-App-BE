using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Goals.Queries.GetAllGoalQuery
{
    public class GetAllGoalsDTO : TimeEntity
    {
        public Guid GoalId { get; set; }
        public Guid UserId { get; set; }
        public string GoalType { get; set; }
        public int WeightGoal { get; set; }
        public float CaloriesGoal { get; set; }
        public float ProteinGoal { get; set; }
        [JsonPropertyName("carbsGoal")]
        public float CarbsGoal { get; set; }
        public float FatGoal { get; set; }
        public float FiberGoal { get; set; }
        public float SugarGoal { get; set; }
        public int WaterIntakesGoal { get; set; }
        public float ExerciseGoal { get; set; }
        public string Status { get; set; }
    }
}
