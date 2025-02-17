
using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Activities : TimeEntity
    {
        [Key]
        public Guid ActivityId { get; set; }
        public Guid? DailyActivityId { get; set; }
        public Guid? WorkoutId { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(DailyActivityId))]
        public DailyActivity? DailyActivity { get; set; }

        [ForeignKey(nameof(WorkoutId))]
        public Workout? Workout { get; set; }
    }
}