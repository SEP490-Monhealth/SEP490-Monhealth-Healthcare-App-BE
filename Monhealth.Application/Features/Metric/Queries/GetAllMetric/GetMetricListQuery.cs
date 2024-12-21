using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetMetricListQuery : IRequest<PageResult<MetricDto>>
    {
        public Guid? UserId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetMetricListQuery(Guid? userId, int pageIndex, int limit)
        {
            UserId = userId;
            Page = pageIndex;
            Limit = limit;
        }
    }
}
