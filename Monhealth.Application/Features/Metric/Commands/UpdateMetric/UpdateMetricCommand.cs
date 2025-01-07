using MediatR;

namespace Monhealth.Application.Features.Metric.Commands.UpdateMetric
{
    public class UpdateMetricCommand : IRequest<bool>
    {
        public Guid MetricId { get; set; }
        public UpdateMetricDto UpdateMetricDto { get; set; }

        public UpdateMetricCommand(Guid metricId, UpdateMetricDto updateMetricDto)
        {
            MetricId = metricId;
            UpdateMetricDto = updateMetricDto;
        }
    }
}
