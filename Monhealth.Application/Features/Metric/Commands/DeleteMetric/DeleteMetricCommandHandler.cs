using MediatR;
using Monhealth.Application.Contracts.Persistence;
namespace Monhealth.Application.Features.Metric.Commands.DeleteMetric
{
    public class DeleteMetricCommandHandler : IRequestHandler<DeleteMetricCommand, bool>
    {
        private readonly IMetricRepository _metricRepository;
        public DeleteMetricCommandHandler(IMetricRepository metricRepository)
        {
            _metricRepository = metricRepository;
        }
        public async Task<bool> Handle(DeleteMetricCommand request, CancellationToken cancellationToken)
        {
            var metricToDelete = await _metricRepository.GetByIdAsync(request.MetricId);
            if (metricToDelete == null)
            {
                return false;
            }
            _metricRepository.Remove(metricToDelete);
            await _metricRepository.SaveChangeAsync();
            return true;
        }
    }
}
