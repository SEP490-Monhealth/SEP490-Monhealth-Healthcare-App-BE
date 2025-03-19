using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Goals.Queries.GetAllGoalQuery
{
    public class GetAllGoalsDTO : TimeEntity
    {
        public Guid GoalId { get; set; }
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public GoalType GoalType { get; set; }
        public float CaloriesRatio { get; set; }
        public int WeightGoal { get; set; }
        public float CaloriesGoal { get; set; }
        public float ProteinGoal { get; set; }
        public float CarbsGoal { get; set; }
        public float FatGoal { get; set; }
        public float FiberGoal { get; set; }
        public float SugarGoal { get; set; }
        public int WaterIntakesGoal { get; set; }
        public float DurationGoal { get; set; }
        public float CaloriesBurnedGoal { get; set; }
        public GoalStatus Status { get; set; }
    }
}
