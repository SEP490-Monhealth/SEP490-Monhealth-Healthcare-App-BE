using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Metric.Commands.DeleteMetric
{
    public class DeleteMetricCommand : IRequest<bool>
    {
        public Guid MetricId { get; set; }
    }
}
