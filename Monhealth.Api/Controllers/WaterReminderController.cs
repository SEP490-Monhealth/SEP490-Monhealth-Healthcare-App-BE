using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Reminder.Commands.CreateReminder;
using Monhealth.Application.Features.Reminders.Commands.DeleteReminder;
using Monhealth.Application.Features.Reminders.Commands.UpdateReminder;
using Monhealth.Application.Features.Reminders.Commands.UpdateReminderStatus;
using Monhealth.Application.Features.Reminders.Queries.GetAllReminder;
using Monhealth.Application.Features.Reminders.Queries.GetReminderByUser;
using Monhealth.Application.Features.Reminders.Queries.GetReminderDetail;
using Monhealth.Application.Features.WaterReminders.Commands.ChangeStatusIsDrunk;
using Monhealth.Application.Models;
using Monhealth.Identity.BackGroundServiceForWaterReminder;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/water-reminders")]
    [ApiController]
    public class WaterReminderController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly WaterReminderResetService _resetService;
        public WaterReminderController(IMediator mediator,
        WaterReminderResetService resetIsDrunkService)
        {
            _mediator = mediator;
            _resetService = resetIsDrunkService;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllReminder()
        {
            var query = new GetAllReminderQuery();
            var result = await _mediator.Send(query);
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true,

            };
        }

        // [HttpPost("reset")]
        // public async Task<IActionResult> ResetReminders()
        // {
        //     int resetCount = await _resetService.ResetRemindersAsync();
        //     return Ok(new
        //     {
        //         Message = $"Successfully reset {resetCount} reminders.",
        //         ResetCount = resetCount
        //     });
        // }

        [HttpGet("{waterReminderId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReminderById(Guid waterReminderId)
        {
            var portion = await _mediator.Send(new GerReminderDetailQuery() { WaterReminderId = waterReminderId });
            if (portion == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                };
            }
            return new ResultModel
            {
                Data = portion,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReminderByUser(Guid userId)
        {
            var portion = await _mediator.Send(new GetAllReminderByUserQuery() { UserId = userId });
            if (portion == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm lời nhắc"
                };
            }
            return new ResultModel
            {
                Data = portion,
                Status = 200,
                Success = true
            };
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateReminder([FromBody] CreateWaterReminderCommand request)
        {

            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo lời nhắc thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo lời nhắc thất bại",
                Status = 400,
            });
        }

        [HttpPut("{waterReminderId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid waterReminderId, [FromBody] UpdateReminderRequest request)
        {
            var command = new UpdateReminderCommand(waterReminderId, request);
            var result = await _mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật lời nhắc  thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật lời nhắc thành công"
            };
        }

        [HttpDelete("{waterReminderId}")]
        public async Task<ActionResult<ResultModel>> DeleteReminder(Guid waterReminderId)
        {
            var command = await _mediator.Send(new DeleteReminderCommand() { RemindId = waterReminderId });

            if (command == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Xóa lời nhắc thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa lời nhắc thành công"
            };
        }


        [HttpPatch("{waterReminderId}/status")]
        public async Task<ActionResult<ResultModel>> UpdateStatus(Guid waterReminderId)
        {
            var command = await _mediator.Send(new UpdateReminderStatusCommand() { WaterReminderId = waterReminderId });

            if (command == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật trạng thái thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật trạng thái thành công"
            };

        }

        [HttpPatch("{waterReminderId}/drunk")]
        public async Task<ActionResult<ResultModel>> UpdateStatusOfIsDrunk(Guid waterReminderId)
        {
            var command = await _mediator.Send(new ChangeStatusIsDrunkCommand() { WaterReminderId = waterReminderId });

            if (command == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật trạng thái thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật trạng thái thành công"
            };

        }
    }
}