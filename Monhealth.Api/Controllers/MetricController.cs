using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Metric.Queries.GetAllMetric;
using Monhealth.Application.Features.Metric.Queries.GetMetricDetail;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/metrics")]
    [ApiController]
    public class MetricController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MetricController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllMetrics(int page = 1, int limit = 10)
        {
            var metrics = await _mediator.Send(new GetMetricListQuery(page, limit));

            return new ResultModel
            {
                Data = metrics,
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Lấy danh sách số liệu thành công"
            };
        }

        [HttpGet("{metricId:guid}")]
        public async Task<ActionResult<ResultModel>> GetMetricById(Guid metricId)
        {
            var metric = await _mediator.Send(new GetMetricDetailQuery() { MetricId = metricId });
            if (metric == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Số liệu không tồn tại."
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = metric
            };
        }
    }
}
