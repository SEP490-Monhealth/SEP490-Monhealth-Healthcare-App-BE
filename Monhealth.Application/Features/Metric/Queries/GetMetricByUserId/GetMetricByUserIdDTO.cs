using Monhealth.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Metric.Queries.GetMetricByUserId
{
    public class GetMetricByUserIdDTO : BaseEntity
    {
        public Guid MetricId { get; set; }
        public string GoalType { get; set; }
        public int WeightGoal { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float ActivityLevel { get; set; }
        public float Bmi { get; set; }
        public float Bmr { get; set; }
        public float Tdee { get; set; }
        public float Ibw { get; set; }
    }
}
