using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Workout : BaseEntity
    {
        [Key]
        public Guid WorkoutId { get; set; }
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }
        public WorkoutType WorkoutType { get; set; }
        public string WorkoutName { get; set; } = string.Empty;
        public string WorkoutDescription { get; set; } = string.Empty;
        public DifficultyLevel DifficultyLevel { get; set; }
        public int Views { get; set; } = default!;
        public float DurationMinutes { get; set; }
        public float CaloriesBurned { get; set; }
        public bool IsPublic { get; set; }
        public bool Status { get; set; } = default!;

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
