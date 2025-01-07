using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Metric.Queries.GetMetricByUserId
{
    public class GetMetricByUserIdQuery : IRequest<List<GetMetricByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}
