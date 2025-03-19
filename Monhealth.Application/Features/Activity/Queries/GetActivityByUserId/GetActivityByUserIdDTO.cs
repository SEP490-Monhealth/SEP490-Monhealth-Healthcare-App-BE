using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Activity.Queries.GetActivityByUserId
{
    public class GetActivityByUserIdDTO
    {
        public Guid ActivityId { get; set; }
        public Guid? DailyActivityId { get; set; }
        public Guid? WorkoutId { get; set; }
    }
}
