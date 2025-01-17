using MediatR;

namespace Monhealth.Application.Features.Metric.Commands.UpdateMetric
{
    public class UpdateMetricCommand : IRequest<bool>
    {
        public Guid MetricId { get; set; }
        public UpdateMetricDTO UpdateMetricDTO { get; set; }

        public UpdateMetricCommand(Guid metricId, UpdateMetricDTO updateMetricDto)
        {
            MetricId = metricId;
            UpdateMetricDTO = updateMetricDto;
        }
    }
}
