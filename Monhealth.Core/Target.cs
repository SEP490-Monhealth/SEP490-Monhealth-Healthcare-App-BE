using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Target : BaseEntity
    {
        [Key]
        public Guid TargetId { get; set; }
        public Guid GoalId { get; set; }
        public float Weight { get; set; }
        public float DailyCalories { get; set; }
        public float DailyWater { get; set; }
        public int ExerciseMinutes { get; set; }
        public int DailySteps { get; set; }
        [ForeignKey(nameof(GoalId))]
        public Goal Goal { get; set; }
    }
}
