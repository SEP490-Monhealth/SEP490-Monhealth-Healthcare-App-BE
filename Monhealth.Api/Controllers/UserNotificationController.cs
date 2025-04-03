using MediatR;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.ConsultantBank.Queries.GetAllConsultantBanks;
using Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankByConsultantId;
using Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankById;
using Monhealth.Application.Models;
using Monhealth.Application.Features.UserNotification.Queries.GetAllUserNotifications;
using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationById;
using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByNotificationId;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/usernotifications")]
    [ApiController]
    public class UserNotificationController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllUserNotifications(int page = 1, int limit = 10, string? search = null)
        {
            var userNotificationList = await mediator.Send(new GetAllUserNotificationsQuery(page, limit, search));

            return new ResultModel
            {
                Data = userNotificationList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{userNotificationId:guid}")]
        public async Task<ActionResult<ResultModel>> GetUserNotificationById(Guid userNotificationId)
        {
            var userNotification = await mediator.Send(new GetUserNotificationByIdQuery { UserNotificationId = userNotificationId });
            if (userNotification == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Thông báo của người dùng không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = userNotification
            });
        }

        [HttpGet("notification/{notificationId:guid}")]
        public async Task<ActionResult<ResultModel>> GetUserNotificationByNoticationId(Guid notificationId)
        {
            var userNotification = await mediator.Send(new GetUserNotificationByNotificationIdQuery { NotificationId = notificationId });
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = userNotification
            });
        }
    }
}
