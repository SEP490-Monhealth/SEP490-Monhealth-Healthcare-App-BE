﻿namespace Monhealth.Application.Features.Activity.Queries.GetActivityByUserId
{
    public class GetActivityByUserIdDTO
    {
        public Guid ActivityId { get; set; }
        public Guid? DailyActivityId { get; set; }
        public Guid? WorkoutId { get; set; }
    }
}
