using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Metric.Queries.GetMetricDetail
{
    public class GetMetricDetailQueryHandler : IRequestHandler<GetMetricDetailQuery, MetricDetailDto>
    {
        private readonly IMapper _mapper;
        private readonly IMetricRepository _metricRepository;
        public GetMetricDetailQueryHandler(IMapper mapper, IMetricRepository metricRepository)
        {
            _mapper = mapper;
            _metricRepository = metricRepository;
        }
        public async Task<MetricDetailDto> Handle(GetMetricDetailQuery request, CancellationToken cancellationToken)
        {
            var metric = await _metricRepository.GetByIdAsync(request.MetricId);
            if (metric == null) { throw new Exception("Not found metric"); }
            return _mapper.Map<MetricDetailDto>(metric);
        }

    }
}
