using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Monhealth.Domain
{
    public class WorkoutExercise : TimeEntity
    {
        [Key]
        public Guid WorkoutExerciseId { get; set; }
        public Guid WorkoutId { get; set; }
        public Guid ExerciseId { get; set; }
        public int Order { get; set; } = default!;
        public int DurationSeconds { get; set; } = default!;
        public int Reps { get; set; } = default!;
        public bool? IsCompleted { get; set; }

        [ForeignKey(nameof(WorkoutId))]
        public Workout Workout { get; set; }
        [ForeignKey(nameof(ExerciseId))]
        public Exercise Exercise { get; set; }
    }
}
