using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetMetricListQueryHandler : IRequestHandler<GetMetricListQuery, List<MetricDto>>
    {
        private readonly IMapper _mapper;
        private readonly IMetricRepository _metricRepository;
        public GetMetricListQueryHandler(IMapper mapper, IMetricRepository metricRepository)
        {
            _mapper = mapper;
            _metricRepository = metricRepository;
        }
        public async Task<List<MetricDto>> Handle(GetMetricListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var metrics = await _metricRepository.GetAllMetricAsync(request.UserId);
                var metricsResponse = _mapper.Map<List<MetricDto>>(metrics);
                return metricsResponse;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
