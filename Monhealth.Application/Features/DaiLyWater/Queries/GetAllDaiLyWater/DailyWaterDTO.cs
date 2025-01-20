using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater
{
    public class DailyWaterDTO : TimeEntity
    {
        public Guid DailyWaterIntakeId { get; set; }
        [JsonPropertyName("volume")]
        public float TotalVolume { get; set; }
    }
}