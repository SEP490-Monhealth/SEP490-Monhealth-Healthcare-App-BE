using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain.Common;


namespace Monhealth.Domain
{
    public class WorkoutExercise : TimeEntity
    {
        [Key]
        public Guid WorkoutExerciseId { get; set; }
        public Guid WorkoutId { get; set; }
        public Guid ExerciseId { get; set; }
        public int Duration { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(WorkoutId))]
        public Workout Workout { get; set; }
        [ForeignKey(nameof(ExerciseId))]
        public Exercise Exercise { get; set; }
    }
}
