using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Exercise.Commands.UpdateExercise
{
    public class UpdateExerciseDTO
    {
        public ExerciseType ExerciseType { get; set; }
        public string ExerciseName { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public float CaloriesPerMinute { get; set; }
    }
}
