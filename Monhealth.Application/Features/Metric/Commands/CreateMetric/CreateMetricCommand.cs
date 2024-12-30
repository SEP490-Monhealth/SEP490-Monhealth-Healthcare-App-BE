using MediatR;

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
