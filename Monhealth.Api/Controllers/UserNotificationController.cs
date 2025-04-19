using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Notification.Commands.IsReadNotificaiton;
using Monhealth.Application.Features.UserNotification.Queries.GetAllUserNotifications;
using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationById;
using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByNotificationId;
using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByUserId;
using Monhealth.Application.Models;
using Monhealth.Application.Models.Identity;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/user-notifications")]
    [ApiController]
    public class UserNotificationController(IMediator mediator, IHttpContextAccessor httpContextAccessor) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllUserNotifications(int page = 1, int limit = 10, Guid? userId = null, string? search = null)
        {
            var userNotificationList = await mediator.Send(new GetAllUserNotificationsQuery(page, limit, userId, search));

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
        [HttpGet("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetUserNotificationByUserId(Guid userId)
        {
            var userNotification = await mediator.Send(new GetUserNotificationByUserIdQuery { UserId = userId });
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = userNotification
            });
        }
        [HttpPatch("notification/{notificationId}")]
        public async Task<ActionResult<ResultModel>> MarkAsRead(Guid notificationId)
        {
            // Lấy UserId từ JWT token hoặc từ context người dùng
            //var userId = httpContextAccessor.HttpContext.User.FindFirst(UserClaims.UserId)?.Value;
            var userId = User.FindFirst(UserClaims.UserId)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.Unauthorized,
                    Message = "Người dùng chưa được xác thực."
                };
            }

            var command = new IsReadNotificaitonCommand(Guid.Parse(userId), notificationId);
            await mediator.Send(command);

            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
            };
        }
    }
}
