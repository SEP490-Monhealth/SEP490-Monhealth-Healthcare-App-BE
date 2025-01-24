using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class Workout : TimeEntity
    {
        [Key]
        public Guid WorkoutId { get; set; }
        public Guid DailyActivityId { get; set; }
        public Guid UserId { get; set; }
        public string WorkoutName { get; set; } = string.Empty;
        [ForeignKey(nameof(DailyActivityId))]
        public DailyActivity DailyActivity { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
