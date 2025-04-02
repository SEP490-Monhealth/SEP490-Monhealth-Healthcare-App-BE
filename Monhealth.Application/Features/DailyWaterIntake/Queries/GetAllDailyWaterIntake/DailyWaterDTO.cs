using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater
{
    public class DailyWaterDTO : TimeEntity
    {
        public Guid DailyWaterIntakeId { get; set; }
        public GoalType GoalType { get; set; }
        public float TotalVolume { get; set; }
    }
}