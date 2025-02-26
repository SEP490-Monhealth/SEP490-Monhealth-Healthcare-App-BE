using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Schedule.Commands.Create;
using Monhealth.Application.Features.Schedule.Commands.Delete;
using Monhealth.Application.Features.Schedule.Commands.Update;
using Monhealth.Application.Features.Schedule.Commands.UpdateScheduleStatus;
using Monhealth.Application.Features.Schedule.Queries.GetAll;
using Monhealth.Application.Features.Schedule.Queries.GetByUser;
using Monhealth.Application.Features.Subscription.Queries.GetById;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/schedules")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ScheduleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllMetrics()
        {
            var scheduleList = await _mediator.Send(new GetAllScheduleQuery());

            return new ResultModel
            {
                Data = scheduleList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("{scheduleId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetScheduleDetail(Guid scheduleId)
        {
            var queries = await _mediator.
            Send(new GetDetailScheduleQuery { ScheduleId = scheduleId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Lịch không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpGet]
        [Route("consultant/{consultantId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetScheduleByUser(Guid consultantId, [FromQuery] DateOnly? date = null)
        {
            var queries = await _mediator.
            Send(new GetScheduleByUserQuery { UserId = consultantId, Date = date });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Lịch không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpPost]
        public async Task<ResultModel> Create(ScheduleRequest request)
        {
            var create = await _mediator.Send(request);
            if (create == true)
            {
                return new ResultModel
                {
                    Message = "Tạo lịch thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo lịch thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut]
        [Route("{scheduleId:Guid}")]
        public async Task<ActionResult<ResultModel>> UpdateCategory(Guid scheduleId, [FromBody] UpdateScheduleRequest request)
        {
            var command = new UpdateScheduleCommand(scheduleId, request);
            var result = await _mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật lịch thất bại",
                    Success = false,
                    Data = null
                };
            return Ok(
                new ResultModel
                {
                    Message = "Cập nhật lịch thành công",
                    Success = true,
                    Status = 204,
                }
            );
        }

        [HttpDelete]
        [Route("{scheduleId:Guid}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid scheduleId)
        {
            var queries = await _mediator.
            Send(new DeleteScheduleRequest(scheduleId));

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Lịch không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 204,
                Data = queries
            });
        }

        [HttpPatch("{scheduleId:guid}/status")]
        public async Task<ActionResult<ResultModel>> UpdateScheduleStatus([FromRoute] Guid scheduleId)
        {
            var result = await _mediator.Send(new UpdateScheduleStatusCommand { ScheduleId = scheduleId });
            if (!result)
            {
                return new ResultModel
                {
                    Message = "Cập nhật lịch thất bại",
                    Success = false,
                    Data = null
                };
            }
            return new ResultModel
            {
                Message = "Cập nhập trạng thái thành công",
                Status = (int)HttpStatusCode.OK,
                Success = true
            };
        }
    }
}