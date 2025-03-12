using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.TimeSlots.Commands.CreateTimeSlots;
using Monhealth.Application.Features.TimeSlots.Queries.GetAllTimSlots;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/time-slots")]
    [ApiController]
    public class TimeSlotController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllTimeSlot()
        {
            var results = await mediator.Send(new GetAllTimeSlotQueries());

            return new ResultModel
            {
                Data = results,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateTimeSlot([FromBody] CreateTimeSlotCommand command)
        {

            var result = await mediator.Send(command);
            if (result == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo bài tập thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo bài tập thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }


    }
}
