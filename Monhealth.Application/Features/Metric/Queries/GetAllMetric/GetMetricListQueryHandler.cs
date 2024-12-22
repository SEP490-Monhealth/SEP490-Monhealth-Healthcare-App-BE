using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;
using System.Collections.Generic;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetMetricListQueryHandler : IRequestHandler<GetMetricListQuery, PageResult<MetricDto>>
    {
        private readonly IMapper _mapper;
        private readonly IMetricRepository _metricRepository;
        public GetMetricListQueryHandler(IMapper mapper, IMetricRepository metricRepository)
        {
            _mapper = mapper;
            _metricRepository = metricRepository;
        }
        public async Task<PageResult<MetricDto>> Handle(GetMetricListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var metrics = await _metricRepository.GetAllMetricAsync(request.UserId, request.Page, request.Limit);
                var metricsResponse = _mapper.Map<List<MetricDto>>(metrics.Data).ToList();
                return new PageResult<MetricDto>
                {
                    CurrentPage = request.Page,
                    TotalItems = metrics.TotalItems,
                    TotalPages = (int)Math.Ceiling(metrics.TotalItems / (double)request.Limit),
                    Data = metricsResponse
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }          
        }
    }
}
