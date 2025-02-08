using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Workout : TimeEntity
    {
        [Key]
        public Guid WorkoutId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid UserId { get; set; }
        public string WorkoutName { get; set; } = string.Empty;
        public string WorkoutDescription { get; set; } = string.Empty;
        public DifficultyLevel DifficultyLevel { get; set; }
        public int Views { get; set; }
        public int Rounds { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
        public ICollection<DailyActivityWorkout> DailyActivityWorkouts { get; set; }
    }
}
