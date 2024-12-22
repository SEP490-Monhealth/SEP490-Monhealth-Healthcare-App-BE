using Monhealth.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Metric.Commands.CreateMetric
{
    public class CreateMetricDto
    {
        public Guid UserId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float ActivityLevel { get; set; }
    }
}
