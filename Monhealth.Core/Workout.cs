using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Domain
{
    public class Workout : TimeEntity
    {
        [Key]
        public Guid WorkoutId { get; set; }
        public Guid DailyWorkoutId { get; set; }
        public Guid UserId { get; set; }
        public string WorkoutName { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(DailyWorkoutId))]
        public DailyWorkout DailyWorkout { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
