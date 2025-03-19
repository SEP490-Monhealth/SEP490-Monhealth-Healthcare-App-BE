using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class DailyActivity : TimeEntity
    {
        [Key]
        public Guid DailyActivityId { get; set; }
        public Guid GoalId { get; set; }
        public Guid UserId { get; set; }
        public float TotalDuration { get; set; }
        public float TotalCaloriesBurned { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(GoalId))]
        public Goal Goal { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
