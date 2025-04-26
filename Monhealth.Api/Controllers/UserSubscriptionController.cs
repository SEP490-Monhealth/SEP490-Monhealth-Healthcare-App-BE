using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Models;
using Monhealth.Core.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Authorize]
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
        [SwaggerOperation(Summary = "Lấy danh sách đăng ký gói")]
        public async Task<ActionResult<ResultModel>> GetAllUserSubscription(int page = 1, int limit = 10, string? subscription = null, string? search = null, string? sort = null, string? order = null, UserSubscriptionStatus? status = null)
        {
            var result = await _mediator.Send(new GetAllUserSubscriptionQuery(page, limit, subscription, search, sort, order, status));
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("user/{userId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách đăng ký gói theo người dùng")]
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
        [SwaggerOperation(Summary = "Lấy thông tin đăng ký gói")]
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

        [HttpGet("{userId:guid}/remaining-bookings")]
        [SwaggerOperation(Summary = "Lấy thông tin số lần đặt lịch còn lại của người dùng")]
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