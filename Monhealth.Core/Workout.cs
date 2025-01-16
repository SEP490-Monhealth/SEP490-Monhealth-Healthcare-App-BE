using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Domain
{
    public class Workout : BaseEntity
    {
        [Key]
        public Guid WorkoutId { get; set; }
        public Guid DailyWorkoutId { get; set; }
        public Guid UserId { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public float CaloriesBurned { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(DailyWorkoutId))]
        public DailyWorkout DailyWorkout { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
