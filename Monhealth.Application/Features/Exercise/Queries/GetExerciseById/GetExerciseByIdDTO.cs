using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseById
{
    public class GetExerciseByIdDTO
    {
        public Guid TypeId { get; set; }
        public string ExerciseName { get; set; } = string.Empty;
        public string IntensityLevel { get; set; } = string.Empty;
        public int Duration { get; set; }
        public float CaloriesBurned { get; set; }
        public string Instructions { get; set; } = string.Empty;
        public int Views { get; set; }
        public bool Status { get; set; }
    }
}
