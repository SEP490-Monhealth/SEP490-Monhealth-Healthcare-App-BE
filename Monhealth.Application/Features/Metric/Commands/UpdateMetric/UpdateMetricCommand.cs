using MediatR;
using Monhealth.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Metric.Commands.UpdateMetric
{
    public class UpdateMetricCommand : IRequest<bool>
    {
        public Guid MetricId { get; set; }
        public UpdateMetricDto MetricDto { get; set; }

        public UpdateMetricCommand(Guid metricId, UpdateMetricDto metricDto)
        {
            MetricId = metricId;
            MetricDto = metricDto;
        }
    }
}
