using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Domain
{
    public class DailyWaterIntake : TimeEntity
    {
        public Guid DailyWaterIntakeId { get; set; }
        public Guid UserId { get; set; }
        public Guid GoalId { get; set; }
        public float TotalVolume { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(GoalId))]
        public Goal Goal { get; set; }
    }
}
