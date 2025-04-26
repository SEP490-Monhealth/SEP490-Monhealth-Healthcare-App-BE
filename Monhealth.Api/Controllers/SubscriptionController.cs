using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Subscription.Commands.ChangeStatus;
using Monhealth.Application.Features.Subscription.Commands.Create;
using Monhealth.Application.Features.Subscription.Commands.Delete;
using Monhealth.Application.Features.Subscription.Commands.Update;
using Monhealth.Application.Features.Subscription.Queries.GetAll;
using Monhealth.Application.Features.Subscription.Queries.GetDetail;
using Monhealth.Application.Features.UserSubscription.Commands.Create;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
    [Route("api/v1/subscriptions")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SubscriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách gói đăng ký")]
        public async Task<ActionResult<ResultModel>> GetAllSubscription(int page = 1, int limit = 10, string? search = null, bool? sort = null, bool? status = null)
        {
            var metrics = await _mediator.Send(new GetAllSubscriptionQuery { Page = page, Limit = limit, Search = search, Sort = sort, Status = status });

            return new ResultModel
            {
                Data = metrics,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }

        [HttpGet("{subscriptionId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin gói đăng ký")]
        public async Task<ActionResult<ResultModel>> GetReminderById(Guid subscriptionId)
        {
            var result = await _mediator.Send(new SubscriptionDetailQuery() { SubscriptionId = subscriptionId });
            if (result == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy gói đăng ký",
                };
            }
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };
        }

        // [HttpGet("user/{userId:guid}")]
        // public async Task<ActionResult<ResultModel>> GetByUserId(Guid userId)
        // {
        //     var result = await _mediator.Send(new GetSubscriptionByUserQuery() { Userid = userId });
        //     if (result == null)
        //     {
        //         return new ResultModel
        //         {
        //             Success = false,
        //             Status = (int)HttpStatusCode.NotFound,
        //         };
        //     }
        //     return new ResultModel
        //     {
        //         Data = result,
        //         Status = 200,
        //         Success = true
        //     };
        // }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo gói đăng ký")]
        public async Task<ActionResult<ResultModel>> Add([FromBody] CreateSubscriptionCommand request)
        {

            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo gói đăng ký thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo gói đăng ký thất bại",
                Status = 400,
            });
        }

        [HttpPost("upgrade")]
        [SwaggerOperation(Summary = "Nâng cấp gói đăng ký")]
        public async Task<ActionResult<ResultModel>> Upgrade([FromBody] CreateUserSubscriptionCommand request)
        {

            var result = await _mediator.Send(request);
            if (result != null)
                return ResultModel.Created(null, "Nâng cấp gói đăng ký thành công");
            return ResultModel.CreateFailed(null, "Nâng cấp gói đăng ký thất bại");
        }

        [HttpPut]
        [Route("{subscriptionId:Guid}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin gói đăng ký")]
        public async Task<ActionResult<ResultModel>> Update(Guid subscriptionId, [FromBody] UpdateSubscriptionRequest request)
        {
            var command = new UpdateSubscriptionCommand(subscriptionId, request);
            var result = await _mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật thông tin gói đăng ký thất bại",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật thông tin gói đăng ký thành công",
                Success = true,
                Status = 204,
            });
        }

        [HttpDelete]
        [Route("{subscriptionId:Guid}")]
        [SwaggerOperation(Summary = "Xóa gói đăng ký")]
        public async Task<ActionResult<ResultModel>> Remove(Guid subscriptionId)
        {
            var command = await _mediator.Send(new DeleteSubscriptionRequest() { SubscriptionId = subscriptionId });

            if (!command)
            {
                // Trả về lỗi nếu xóa không thành công
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Xóa gói đăng ký không thành công",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa gói đăng ký thành công",
                Status = 204,
                Data = null
            });
        }

        [HttpPatch("{subscriptionId}/status")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái gói đăng ký")]
        public async Task<ActionResult<ResultModel>> ChangeStatusSubscription(Guid subscriptionId)
        {
            var command = new ChangeStatusSubscriptionCommand { SubscriptionId = subscriptionId };
            var changeStatus = await _mediator.Send(command);
            if (!changeStatus)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy gói đăng ký"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật trạng thái gói đăng ký thành công"
            };
        }
    }
}