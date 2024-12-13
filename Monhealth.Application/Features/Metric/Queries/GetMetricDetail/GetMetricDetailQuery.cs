using MediatR;

namespace Monhealth.Application.Features.Metric.Queries.GetMetricDetail
{
    public class GetMetricDetailQuery : IRequest<MetricDetailDto>
    {
        public Guid MetricId { get; set; }
    }
}
