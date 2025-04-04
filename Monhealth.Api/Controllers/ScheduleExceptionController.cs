using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.ScheduleException.Commands.CreateScheduleException;
using Monhealth.Application.Features.ScheduleException.Commands.DeleteScheduleException;
using Monhealth.Application.Features.ScheduleException.Commands.UpdateScheduleException;
using Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException;
using Monhealth.Application.Features.ScheduleException.Queries.GetScheduleExceptionById;
using Monhealth.Application.Models;
using System.Net;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/schedule-exceptions")]
    [ApiController]
    public class ScheduleExceptionController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
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

        [HttpPost]
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

        [HttpGet]
        [Route("{scheduleExceptionId:Guid}")]
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

        [HttpPut]
        [Route("{scheduleExceptionId:Guid}")]
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
    }
}
