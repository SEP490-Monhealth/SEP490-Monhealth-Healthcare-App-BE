using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Goals.Queries.GetNutritionByGoalId
{
    public class GetNutritionByGoalIdDTO
    {
        public float CaloriesGoal { get; set; }
        public float ProteinGoal { get; set; }
        public float CarbsGoal { get; set; }
        public float FatGoal { get; set; }
        public float FiberGoal { get; set; }
        public float SugarGoal { get; set; }
    }
}
