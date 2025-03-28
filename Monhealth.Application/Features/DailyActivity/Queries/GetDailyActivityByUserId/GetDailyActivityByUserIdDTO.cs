﻿using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.DailyActivity.Queries.GetDailyActivityByUserId
{
    public class GetDailyActivityByUserIdDTO : TimeEntity
    {
        public Guid DailyActivityId { get; set; }
        public Guid GoalId { get; set; }
        public float TotalDuration { get; set; }
        public float TotalCaloriesBurned { get; set; }
    }
}
