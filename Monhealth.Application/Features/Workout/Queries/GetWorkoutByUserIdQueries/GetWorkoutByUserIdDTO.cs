﻿using System.Text.Json.Serialization;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Workout.Queries.GetWorkoutByUserIdQueries
{
    public class GetWorkoutByUserIdDTO
    {
        public Guid WorkoutId { get; set; }
        public Guid UserId { get; set; }
        [JsonPropertyName("category")]
        public string CategoryName { get; set; }
        [JsonPropertyName("type")]
        public WorkoutType WorkoutType { get; set; }
        [JsonPropertyName("name")]
        public string WorkoutName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string WorkoutDescription { get; set; } = string.Empty;
        public DifficultyLevel DifficultyLevel { get; set; }
        public int Exercises { get; set; }
        public int DurationMinutes { get; set; }
        public float CaloriesBurned { get; set; }
        public bool IsPublic { get; set; }
        public bool Status { get; set; }
    }
}
