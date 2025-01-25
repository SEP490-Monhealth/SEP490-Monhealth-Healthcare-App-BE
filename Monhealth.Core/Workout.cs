using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Core.Enum;
using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class Workout : TimeEntity
    {
        [Key]
        public Guid WorkoutId { get; set; }
        public Guid UserId { get; set; }
        public string WorkoutName { get; set; } = string.Empty;
        public string WorkoutDescription { get; set; } = string.Empty;
        public IntensityLevel Intensity { get; set; }
        public int Views { get; set; }

        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
        public ICollection<DailyActivityWorkout> DailyActivityWorkouts { get; set; }
    }
}
