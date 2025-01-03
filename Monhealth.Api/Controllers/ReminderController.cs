using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Reminder.Commands.CreateReminder;
using Monhealth.Application.Features.Reminders.Commands.UpdateReminder;
using Monhealth.Application.Features.Reminders.Commands.UpdateReminderStatus;
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

        [HttpPut("{reminderId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid reminderId, [FromBody] UpdateReminderRequest request)
        {
            var command = new UpdateReminderCommand(reminderId, request);
            var result = await _mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật lời nhắc  thất bại."
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật lời nhắc thành công."
            };
        }
        [HttpPatch("{reminderId}")]
        public async Task<ActionResult<ResultModel>> UpdateStatus(Guid reminderId)
        {
            var command = await _mediator.Send(new UpdateReminderStatusCommand() { ReminderId = reminderId });

            if (command == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật trạng thái thất bại."
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật trạng thái thành công."
            };
        }
    }
}