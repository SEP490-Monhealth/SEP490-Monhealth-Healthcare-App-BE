using MediatR;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetMetricListQuery : IRequest<List<MetricDto>>
    {

    }
}
