using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Metric.Queries.GetMetricByUserId
{
    public class GetMetricByUserIdQueryHandler : IRequestHandler<GetMetricByUserIdQuery, List<GetMetricByUserIdDTO>>
    {
        private readonly IMetricRepository _metricRepository;
        private readonly IMapper _mapper;
        public GetMetricByUserIdQueryHandler(IMetricRepository metricRepository, IMapper mapper)
        {
            _metricRepository = metricRepository;
            _mapper = mapper;
        }
        public async Task<List<GetMetricByUserIdDTO>> Handle(GetMetricByUserIdQuery request, CancellationToken cancellationToken)
        {
            var listMetric = await _metricRepository.GetMetricByUserIdAsync(request.UserId);
            return _mapper.Map<List<GetMetricByUserIdDTO>>(listMetric);
        }
    }
}
