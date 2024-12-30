using MediatR;

namespace Monhealth.Application.Features.Metric.Commands.DeleteMetric
{
    public class DeleteMetricCommand : IRequest<bool>
    {
        public Guid MetricId { get; set; }
    }
}
