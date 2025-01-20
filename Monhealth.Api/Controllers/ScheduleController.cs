using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Schedule.Commands.Create;
using Monhealth.Application.Models;
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
    }
}