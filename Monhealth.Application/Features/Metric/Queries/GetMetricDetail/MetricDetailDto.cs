﻿using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Metric.Queries.GetMetricDetail
{
    public class MetricDetailDTO : TimeEntity
    {
        public Guid UserId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float ActivityLevel { get; set; }
        public float Bmi { get; set; }
        public float Bmr { get; set; }
        public float Tdee { get; set; }
        public float Ibw { get; set; }
    }
}
