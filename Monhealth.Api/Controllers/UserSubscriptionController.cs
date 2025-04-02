using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Models;
using Monhealth.Core.Enum;
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

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllUserSubscription(int page = 1, int limit = 10, string? subscription = null, string? search = null, UserSubscriptionStatus? status = null)
        {
            var result = await _mediator.Send(new GetAllUserSubscriptionQuery(page, limit, subscription, search, status));
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetUserSubscription(Guid userId)
        {
            var result = await _mediator.Send(new GetUserSubscriptionQuery() { UserId = userId });
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{userSubscriptionId:guid}")]
        public async Task<ActionResult<ResultModel>> GetUserSubscriptionById(Guid userSubscriptionId)
        {
            var result = await _mediator.Send(new GetUserSubscriptionRequest() { UserSubscriptionId = userSubscriptionId });
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{userId:guid}/remaining-booking")]
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