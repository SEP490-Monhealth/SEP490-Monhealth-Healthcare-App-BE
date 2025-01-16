using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class WorkoutExercise 
    {
        [Key]
        public Guid WorkoutExerciseId { get; set; }
        public Guid WorkoutId { get; set; }
        public Guid ExerciseId { get; set; }

        [ForeignKey(nameof(WorkoutId))]
        public Workout Workout { get; set; }
        [ForeignKey(nameof(ExerciseId))]
        public Exercise Exercise { get; set; }
    }
}
