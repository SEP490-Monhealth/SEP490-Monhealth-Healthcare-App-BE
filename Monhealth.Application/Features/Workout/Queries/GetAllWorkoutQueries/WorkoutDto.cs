﻿using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Workout.Queries.GetAllWorkoutQueries
{
    public class WorkoutDto : BaseEntity
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
        public float DurationMinutes { get; set; }
        public float CaloriesBurned { get; set; }
        public bool IsPublic { get; set; }
        public bool Status { get; set; }
    }
}
