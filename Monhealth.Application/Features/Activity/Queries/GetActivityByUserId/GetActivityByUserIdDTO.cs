using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Activity.Queries.GetActivityByUserId
{
    public class GetActivityByUserIdDTO : TimeEntity
    {
        public Guid ActivityId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? WorkoutId { get; set; }
        public float CaloriesBurned { get; set; }
        public float DurationMinutes { get; set; }
        public bool IsCompleted { get; set; }
    }
}
