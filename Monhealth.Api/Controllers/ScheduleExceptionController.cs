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
    [Route("api/v1/schedule-exception")]
    [ApiController]
    public class ScheduleExceptionController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllScheduleException()
        {
            var scheduleList = await mediator.Send(new GetAllScheduleExceptionQueries());

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
        [Route("{exceptionId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetScheduleException(Guid exceptionId)
        {
            var queries = await mediator.Send(new GetScheduleExceptionByIdQueries { ExceptionId = exceptionId });

            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpPut]
        [Route("{exceptionId:Guid}")]
        public async Task<ActionResult<ResultModel>> UpdateScheduleException(Guid exceptionId, [FromBody] UpdateScheduleExceptionDto request)
        {
            var command = new UpdateScheduleExceptionCommand(exceptionId, request);
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
        [Route("{exceptionId:Guid}")]
        public async Task<ActionResult<ResultModel>> DeleteScheduleException(Guid exceptionId)
        {
            var queries = await mediator.Send(new DeleteScheduleExceptionCommand { ExceptionId = exceptionId });

            return Ok(new ResultModel
            {
                Success = true,
                Status = 204,
                Data = queries
            });
        }
    }
}
