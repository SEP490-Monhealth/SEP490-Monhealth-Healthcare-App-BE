using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater
{
    public class DailyWaterDTO : TimeEntity
    {
        public Guid DailyWaterIntakeId { get; set; }
        public float TotalVolume { get; set; }
    }
}