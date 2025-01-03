using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Reminder.Commands.CreateReminder;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/reminders")]
    [ApiController]
    public class ReminderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ReminderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddMeal([FromBody] CreateReminderCommand request)
        {

            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo lời nhắc thành công.",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo lời nhắc thất bại.",
                Status = 400,
            });
        }
    }
}