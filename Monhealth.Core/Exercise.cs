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
    public class Exercise : BaseEntity
    {
        [Key]
        public Guid ExerciseId { get; set; }
        public Guid CategoryId { get; set; }
        public string ExerciseName { get; set; } = string.Empty;
        public string ExerciseDescription{ get; set; } = string.Empty;
        public string Image{ get; set; } = string.Empty;        
        public int Duration { get; set; }
        public float CaloriesBurned { get; set; }
        public string Instructions { get; set; } = string.Empty;
        public string IntensityLevel { get; set; } = string.Empty;
        public string DifficultyLevel { get; set; } = string.Empty;
        public int Views { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }

    }
}
