using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Exercise.Commands.UpdateExercise
{
    public class UpdateExerciseDTO
    {
        public string Category { get; set; } = string.Empty;
        public string ExerciseName { get; set; } = string.Empty;
        public string ExerciseDescription { get; set; } = string.Empty;
        public int Duration { get; set; }
        public float CaloriesBurned { get; set; }
        public string Instructions { get; set; } = string.Empty;
        public string IntensityLevel { get; set; } = string.Empty;
        public string DifficultyLevel { get; set; } = string.Empty;
    }
}
