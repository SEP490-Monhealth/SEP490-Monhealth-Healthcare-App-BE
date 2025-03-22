using Monhealth.Domain.Common;

namespace Monhealth.Application
{
    public class GetActivityByDTO : TimeEntity
    {
        public Guid ActivityId { get; set; }
        public Guid? DailyActivityId { get; set; }
        public Guid? WorkoutId { get; set; }
    }
}