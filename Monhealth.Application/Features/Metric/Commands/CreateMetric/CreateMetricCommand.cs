using MediatR;
using Monhealth.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Metric.Commands.CreateMetric
{
    public class CreateMetricCommand : IRequest<Unit>
    {
        public CreateMetricDto CreateMetricDto { get; set; }
        public CreateMetricCommand(CreateMetricDto createMetricDto)
        {
            CreateMetricDto = createMetricDto;
        }
    }
}
