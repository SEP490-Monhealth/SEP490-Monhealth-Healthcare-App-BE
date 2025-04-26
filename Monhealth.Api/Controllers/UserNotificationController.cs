// using MediatR;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using Monhealth.Application.Features.UserNotification.Queries.GetAllUserNotifications;
// using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationById;
// using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByNotificationId;
// using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByUserId;
// using Monhealth.Application.Models;
// using System.Net;

// namespace Monhealth.Api.Controllers
// {
//     [Authorize]
//     [Route("api/v1/user-notifications")]
//     [ApiController]
//     public class UserNotificationController(IMediator mediator, IHttpContextAccessor httpContextAccessor) : ControllerBase
//     {
//         [HttpGet]
//         public async Task<ActionResult<ResultModel>> GetAllUserNotifications(int page = 1, int limit = 10, Guid? userId = null, string? search = null)
//         {
//             var userNotificationList = await mediator.Send(new GetAllUserNotificationsQuery(page, limit, userId, search));

//             return new ResultModel
//             {
//                 Data = userNotificationList,
//                 Status = 200,
//                 Success = true
//             };
//         }

//         [HttpGet("{userNotificationId:guid}")]
//         public async Task<ActionResult<ResultModel>> GetUserNotificationById(Guid userNotificationId)
//         {
//             var userNotification = await mediator.Send(new GetUserNotificationByIdQuery { UserNotificationId = userNotificationId });
//             if (userNotification == null)
//             {
//                 return NotFound(new ResultModel
//                 {
//                     Success = false,
//                     Message = "Thông báo của người dùng không tồn tại",
//                     Status = (int)HttpStatusCode.NotFound,
//                     Data = null
//                 });
//             }
//             return Ok(new ResultModel
//             {
//                 Success = true,
//                 Status = 200,
//                 Data = userNotification
//             });
//         }

//         [HttpGet("notification/{notificationId:guid}")]
//         public async Task<ActionResult<ResultModel>> GetUserNotificationByNoticationId(Guid notificationId)
//         {
//             var userNotification = await mediator.Send(new GetUserNotificationByNotificationIdQuery { NotificationId = notificationId });
//             return Ok(new ResultModel
//             {
//                 Success = true,
//                 Status = 200,
//                 Data = userNotification
//             });
//         }
//         [HttpGet("user/{userId:guid}")]
//         public async Task<ActionResult<ResultModel>> GetUserNotificationByUserId(Guid userId)
//         {
//             var userNotification = await mediator.Send(new GetUserNotificationByUserIdQuery { UserId = userId });
//             return Ok(new ResultModel
//             {
//                 Success = true,
//                 Status = 200,
//                 Data = userNotification
//             });
//         }

//     }
// }
