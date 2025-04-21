using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.ScheduleException.Commands.CreateScheduleException;
using Monhealth.Application.Features.ScheduleException.Commands.DeleteScheduleException;
using Monhealth.Application.Features.ScheduleException.Commands.UpdateApprovedStatus;
using Monhealth.Application.Features.ScheduleException.Commands.UpdateExceptionRejectedStatus;
using Monhealth.Application.Features.ScheduleException.Commands.UpdateScheduleException;
using Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException;
using Monhealth.Application.Features.ScheduleException.Queries.GetScheduleExceptionByConsultantId;
using Monhealth.Application.Features.ScheduleException.Queries.GetScheduleExceptionById;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/schedule-exceptions")]
    [ApiController]
    public class ScheduleExceptionController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách lịch nghỉ")]
        public async Task<ActionResult<ResultModel>> GetAllScheduleException(int page = 1, int limit = 10)
        {
            var scheduleList = await mediator.Send(new GetAllScheduleExceptionQueries(page, limit));

            return new ResultModel
            {
                Data = scheduleList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("consultant/{consultantId}")]
        [SwaggerOperation(Summary = "Lấy danh sách lịch nghỉ theo ID chuyên viên")]
        public async Task<ActionResult<ResultModel>> GetScheduleExceptionByConsultantId(Guid consultantId, int page = 1, int limit = 10)
        {
            var scheduleList = await mediator.Send(new GetScheduleExceptionByConsultantIdQuery(consultantId, page, limit));

            return new ResultModel
            {
                Data = scheduleList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("{scheduleExceptionId:Guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin lịch nghỉ theo ID")]
        public async Task<ActionResult<ResultModel>> GetScheduleException(Guid scheduleExceptionId)
        {
            var queries = await mediator.Send(new GetScheduleExceptionByIdQueries { ScheduleExceptionId = scheduleExceptionId });

            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo lịch nghỉ")]
        public async Task<ResultModel> CreateScheduleException([FromBody] CreateScheduleExceptionCommand request)
        {
            var create = await mediator.Send(request);

            return new ResultModel
            {
                Message = "Tạo lịch bận thành công",
                Status = (int)HttpStatusCode.OK,
                Success = true
            };
        }

        [HttpPut]
        [Route("{scheduleExceptionId:Guid}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin lịch nghỉ")]
        public async Task<ActionResult<ResultModel>> UpdateScheduleException(Guid scheduleExceptionId, [FromBody] UpdateScheduleExceptionDto request)
        {
            var command = new UpdateScheduleExceptionCommand(scheduleExceptionId, request);
            var result = await mediator.Send(command);

            return Ok(
                new ResultModel
                {
                    Message = "Cập nhật lịch bận thành công",
                    Success = true,
                    Status = 204,
                }
            );
        }

        [HttpDelete]
        [Route("{scheduleExceptionId:Guid}")]
        [SwaggerOperation(Summary = "Xóa lịch nghỉ")]
        public async Task<ActionResult<ResultModel>> DeleteScheduleException(Guid scheduleExceptionId)
        {
            var queries = await mediator.Send(new DeleteScheduleExceptionCommand { ScheduleExceptionId = scheduleExceptionId });

            return Ok(new ResultModel
            {
                Success = true,
                Status = 204,
                Data = queries
            });
        }

        [HttpPatch("{scheduleExceptionId:guid}/approved")]
        public async Task<ActionResult<ResultModel>> ChangeScheduleExceptionApproved([FromRoute] Guid scheduleExceptionId)
        {
            var result = await mediator.Send(new UpdateApprovedStatusCommand { ScheduleExceptionId = scheduleExceptionId });
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Message = "Cập nhập trạng thái lịch bận thất bại",
                    Status = 500,
                };
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Cập nhập trạng thái lịch bận thành công",
                Status = 200,
            });
        }

        [HttpPatch("{scheduleExceptionId:guid}/rejected")]
        public async Task<ActionResult<ResultModel>> ChangeScheduleExceptionRejected([FromRoute] Guid scheduleExceptionId)
        {
            var result = await mediator.Send(new UpdateExceptionRejectedStatusCommand { ScheduleExceptionId = scheduleExceptionId });
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Message = "Cập nhập trạng thái lịch bận thất bại",
                    Status = 500,
                };
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Cập nhập trạng thái lịch bận thành công",
                Status = 200,
            });
        }


    }
}
