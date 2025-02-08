using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Exercise : BaseEntity
    {
        [Key]
        public Guid ExerciseId { get; set; }
        public Guid UserId { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public string ExerciseName { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public float CalriesPerMinute { get; set; }
        public bool Status { get; set; }


        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
