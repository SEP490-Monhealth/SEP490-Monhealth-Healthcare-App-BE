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
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

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
        [SwaggerOperation(Summary = "Lấy danh sách nhắc nhở")]
        public async Task<ActionResult<ResultModel>> GetAllReminder([FromQuery] int page = 1, int limit = 10, string? search = null, bool? recurring = null, bool? status = null)
        {
            var query = new GetAllReminderQuery { Page = page, Limit = limit, Search = search, Recurring = recurring, Status = status };
            var result = await _mediator.Send(query);
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true,

            };
        }

        [HttpGet("user/{userId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách nhắc nhở theo ID người dùng")]
        public async Task<ActionResult<ResultModel>> GetReminderByUser(Guid userId)
        {
            var portion = await _mediator.Send(new GetAllReminderByUserQuery() { UserId = userId });
            if (portion == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm nhắc nhở"
                };
            }
            return new ResultModel
            {
                Data = portion,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{waterReminderId:guid}")]
        [SwaggerOperation(Summary = "Lấy nhắc nhở theo ID")]
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

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo nhắc nhở")]
        public async Task<ActionResult<ResultModel>> CreateReminder([FromBody] CreateWaterReminderCommand request)
        {

            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo nhắc nhở thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo nhắc nhở thất bại",
                Status = 400,
            });
        }

        // [HttpPost("reset")]
        // public async Task<IActionResult> ResetReminders()
        // {
        //     int resetCount = await _resetService.ResetRemindersAsync();
        //     return Ok(new
        //     {
        //         Message = $"Successfully reset {resetCount} reminders",
        //         ResetCount = resetCount
        //     });
        // }

        [HttpPut("{waterReminderId}")]
        [SwaggerOperation(Summary = "Cập nhật nhắc nhở")]
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
                    Message = "Cập nhật nhắc nhở  thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật nhắc nhở thành công"
            };
        }

        [HttpDelete("{waterReminderId}")]
        [SwaggerOperation(Summary = "Xóa nhắc nhở")]
        public async Task<ActionResult<ResultModel>> DeleteReminder(Guid waterReminderId)
        {
            var command = await _mediator.Send(new DeleteReminderCommand() { RemindId = waterReminderId });

            if (command == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Xóa nhắc nhở thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa nhắc nhở thành công"
            };
        }

        [HttpPatch("{waterReminderId}/status")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái nhắc nhở")]
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
                Message = "Cập nhật trạng thái nhắc nhở thành công"
            };

        }

        [HttpPatch("{waterReminderId}/drunk")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái đã uống nước")]
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
                Message = "Cập nhật trạng thái đã uống nước thành công"
            };
        }
    }
}