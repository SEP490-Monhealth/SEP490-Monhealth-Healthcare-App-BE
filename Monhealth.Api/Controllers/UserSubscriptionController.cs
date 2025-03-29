using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/user-subscriptions")]
    [ApiController]
    public class UserSubscriptionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserSubscriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetUserSubscription(Guid userId)
        {
            var result = await _mediator.Send(new GetUserSubScriptionQuery() { UserId = userId });
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllUserSubscription(int page = 1, int limit = 10, string? SubScription = null, UserSubscriptionStatus? status = null)
        {
            var result = await _mediator.Send(new GetAllUserSubscriptionQuery(page, limit , SubScription , status));
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{userId:guid}/remaining-booking")]
        [SwaggerOperation(Summary = "Done")]
        public async Task<ActionResult<ResultModel>> GetReminderBookingByUserId([FromRoute] Guid userId)
        {
            var booking = await _mediator.Send(new GetReminderBookingQuery { UserId = userId });
            return new ResultModel
            {
                Data = booking,
                Status = 200,
                Success = true,
            };
        }
    }
}