using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetMetricListQuery : IRequest<List<MetricDto>>
    {
        public Guid? UserId { get; set; }
        public GetMetricListQuery(Guid? userId)
        {
            UserId = userId;
        }
    }
}
