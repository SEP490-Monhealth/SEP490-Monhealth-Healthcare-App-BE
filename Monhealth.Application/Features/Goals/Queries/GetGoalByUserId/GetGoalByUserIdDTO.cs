﻿using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Goals.Queries.GetGoalByUserId
{
    public class GetGoalByUserIdDTO : TimeEntity
    {
        public Guid GoalId { get; set; }
        public string GoalType { get; set; }
        public int WeightGoal { get; set; }
        public float CaloriesGoal { get; set; }
        public float ProteinGoal { get; set; }
        [JsonPropertyName("carbsGoal")]
        public float CarbGoal { get; set; }
        public float FatGoal { get; set; }
        public float FiberGoal { get; set; }
        public float SugarGoal { get; set; }
        public int WaterGoal { get; set; }
        public float ExerciseGoal { get; set; }
        public string Status { get; set; }
    }
}
