using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Application.Features.Metric.Commands.DeleteMetric;
using Monhealth.Application.Features.Metric.Commands.UpdateMetric;
using Monhealth.Application.Features.Metric.Queries.GetAllMetric;
using Monhealth.Application.Features.Metric.Queries.GetMetricByUserId;
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
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }

        [HttpGet("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetMetricByUserId(Guid userId)
        {
            var metric = await _mediator.Send(new GetMetricByUserIdQuery() { UserId = userId });
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = metric
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
                    Message = "Số liệu không tồn tại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = metric
            };
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> Create([FromBody] CreateMetricDTO metricRequest)
        {
            var command = new CreateMetricCommand(metricRequest);
            var createMetric = await _mediator.Send(command);
            if (createMetric == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo số liệu thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo số liệu thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut("{metricId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid metricId, [FromBody] UpdateMetricDTO metricDto)
        {
            var command = new UpdateMetricCommand(metricId, metricDto);
            var result = await _mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật số liệu thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật số liệu thành công"
            };
        }

        [HttpDelete("{metricId}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid metricId)
        {
            var metricCommand = new DeleteMetricCommand { MetricId = metricId };
            var delete = await _mediator.Send(metricCommand);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy số liệu"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa số liệu thành công"
            };
        }
    }
}
