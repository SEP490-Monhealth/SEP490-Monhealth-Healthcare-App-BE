﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseByUserId
{
    public class GetExerciseByUserIdDTO
    {
        public Guid ExerciseId { get; set; }
        [JsonPropertyName("category")]
        public string CategoryName { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string ExerciseName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string ExerciseDescription { get; set; } = string.Empty;
        public int Duration { get; set; }
        public float CaloriesBurned { get; set; }
        public string Instructions { get; set; } = string.Empty;
        public string IntensityLevel { get; set; } = string.Empty;
        public string DifficultyLevel { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
