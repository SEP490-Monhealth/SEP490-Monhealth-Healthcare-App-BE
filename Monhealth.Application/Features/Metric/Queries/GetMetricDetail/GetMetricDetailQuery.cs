using MediatR;

namespace Monhealth.Application.Features.Metric.Queries.GetMetricDetail
{
    public class GetMetricDetailQuery : IRequest<MetricDetailDTO>
    {
        public Guid MetricId { get; set; }
    }
}
