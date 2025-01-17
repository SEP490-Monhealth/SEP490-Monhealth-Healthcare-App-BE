using MediatR;

namespace Monhealth.Application.Features.Metric.Commands.CreateMetric
{
    public class CreateMetricCommand : IRequest<Unit>
    {
        public CreateMetricDTO CreateMetricDTO { get; set; }
        public CreateMetricCommand(CreateMetricDTO createMetricDto)
        {
            CreateMetricDTO = createMetricDto;
        }
    }
}
