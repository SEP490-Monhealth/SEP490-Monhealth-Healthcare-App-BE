using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Activity : TimeEntity
    {
        [Key]
        public Guid ActivityId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? DailyActivityId { get; set; }
        public Guid? WorkoutId { get; set; }
        public bool IsCompleted { get; set; } = false;

        [ForeignKey(nameof(UserId))]
        public AppUser? AppUser { get; set; }
        [ForeignKey(nameof(DailyActivityId))]
        public DailyActivity? DailyActivity { get; set; }
        [ForeignKey(nameof(WorkoutId))]
        public Workout? Workout { get; set; }
    }
}