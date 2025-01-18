using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Goals.Queries.GetWaterByGoalId
{
    public class GetWaterByGoalIdDTO
    {
        [JsonPropertyName("waterIntakesGoal")]
        public int WaterGoal { get; set; }
    }
}
