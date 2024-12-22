using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Metric.Commands.CreateMetric
{
    public class CreateMetricCommandHandler : IRequestHandler<CreateMetricCommand, Unit>
    {
        private readonly IMetricRepository _metricRepository;
        private readonly IMapper _mapper;
        public CreateMetricCommandHandler(IMetricRepository metricRepository, IMapper mapper)
        {
            _metricRepository = metricRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateMetricCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var newMetric = _mapper.Map<Monhealth.Domain.Metric>(request.CreateMetricDto);

                // new metricId
                newMetric.MetricId = Guid.NewGuid();
                newMetric.CreatedAt = DateTime.Now;
                newMetric.UpdatedAt = DateTime.Now;

                _metricRepository.Add(newMetric);
                await _metricRepository.SaveChangeAsync();
                return Unit.Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi create " + ex.Message);
            }
            
        }
    }
}
