using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetMetricListQuery : IRequest<PageResult<MetricDto>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetMetricListQuery(int pageIndex, int limit)
        {
            Page = pageIndex;
            Limit = limit;
        }
    }
}
