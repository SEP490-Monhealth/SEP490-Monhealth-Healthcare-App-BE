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
        public async Task<ActionResult<ResultModel>> GetAllMetrics()
        {
            var metrics = await _mediator.Send(new GetMetricListQuery());

            return new ResultModel
            {
                Data = metrics,
                Message = "Mectric retrieve successfully",
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{metricId:guid}")]

        public async Task<ActionResult<ResultModel>> GetMetricbyId(Guid metricId)
        {
            var metric = await _mediator.Send(new GetMetricDetailQuery() { MetricId = metricId });
            if (metric == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Metric not found."
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Metric retrieved successfully.",
                Data = metric
            };
        }
    }
}
