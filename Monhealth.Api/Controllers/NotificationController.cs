using MediatR;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.ConsultantBank.Commands.CreateConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Commands.DeleteConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Commands.UpdateConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Queries.GetAllConsultantBanks;
using Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankByConsultantId;
using Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankById;
using Monhealth.Application.Models;
using Monhealth.Application.Features.Notification.Queries.GetAllNotifications;
using Monhealth.Application.Features.Notification.Queries.GetNotificationById;
using Monhealth.Domain;
using Monhealth.Application.Features.Notification.Commands.CreateNotification;
using Monhealth.Application.Features.Notification.Commands.UpdateNotification;
using Monhealth.Application.Features.Notification.Commands.DeleteNotification;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/notifications")]
    [ApiController]
    public class NotificationController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllNotifications(int page = 1, int limit = 10, string? search = null)
        {
            var notificationList = await mediator.Send(new GetAllNotificationsQuery(page, limit, search));

            return new ResultModel
            {
                Data = notificationList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{notificationId:guid}")]
        public async Task<ActionResult<ResultModel>> GetNotificationById(Guid notificationId)
        {
            var notification = await mediator.Send(new GetNotificationByIdQuery { NotificationId = notificationId });
            if (notification == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Thông báo không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = notification
            });
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateNotification([FromBody] CreateNotificationDTO createNotificationDTO)
        {
            var command = new CreateNotificationCommand(createNotificationDTO);
            var create = await mediator.Send(command);
            if (create == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo thông báo thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo thông báo thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut("{notificationId}")]
        public async Task<ActionResult<ResultModel>> UpdateNotification(Guid notificationId, [FromBody] UpdateNotificationDTO updateNotificationDTO)
        {
            var command = new UpdateNotificationCommand(notificationId, updateNotificationDTO);
            var result = await mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật thông báo thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật thông báo thành công"
            };
        }

        [HttpDelete("{notificationId}")]
        public async Task<ActionResult<ResultModel>> DeleteNotification(Guid notificationId)
        {
            var command = new DeleteNotificationCommand { NotificationId = notificationId };
            var delete = await mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Xóa thông báo thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa thông báo thành công"
            };
        }
    }
}
