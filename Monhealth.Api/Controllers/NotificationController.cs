using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Notificacation.Commands;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/notifications")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public NotificationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CreateNotifications()
        {
            // Gửi Command để xử lý thông báo
            var response = await _mediator.Send(new CreateNotificationCommand());
            return Ok(response);
        }
    }
}