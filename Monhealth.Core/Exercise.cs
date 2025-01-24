using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Domain
{
    public class Exercise : BaseEntity
    {
        [Key]
        public Guid ExerciseId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid UserId { get; set; }
        public string ExerciseName { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public int Duration { get; set; }
        public float CaloriesBurned { get; set; }
        public Difficulty Difficulty { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
