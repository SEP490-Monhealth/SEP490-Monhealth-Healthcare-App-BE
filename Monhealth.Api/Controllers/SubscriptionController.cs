using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Subscription.Commands.Create;
using Monhealth.Application.Features.Subscription.Commands.Delete;
using Monhealth.Application.Features.Subscription.Commands.Update;
using Monhealth.Application.Features.Subscription.Queries.GetAll;
using Monhealth.Application.Features.Subscription.Queries.GetByUser;
using Monhealth.Application.Features.Subscription.Queries.GetDetail;
using Monhealth.Application.Features.User.Commands.CreateUser;
using Monhealth.Application.Features.UserSubscription.Commands.Create;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/subscriptions")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SubscriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> Add([FromBody] CreateSubscriptionCommand request)
        {

            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo gói thành viên thành công. ",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo gói thành viên thất bại. ",
                Status = 400,
            });

        }
        [HttpPost("subscriptions/upgrade")]
        public async Task<ActionResult<ResultModel>> Add2([FromBody] CreateUserSubscriptionCommand request)
        {

            var result = await _mediator.Send(request);
            if (result != null)
                return ResultModel.Created(null, "Nâng cấp gói thành công. ");
            return ResultModel.CreateFailed(null ,"Nâng cấp gói thất bại");


        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll()
        {
            var metrics = await _mediator.Send(new GetAllSubscriptionQuery());

            return new ResultModel
            {
                Data = metrics,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }
        [HttpGet("{subscriptionId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReminderById(Guid subscriptionId)
        {
            var portion = await _mediator.Send(new SubscriptionDetailQuery() { SubscriptionId = subscriptionId });
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
        [HttpGet("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetByUserId(Guid userId)
        {
            var portion = await _mediator.Send(new GetSubscriptionByUserQuery() { Userid = userId });
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
        [HttpPut]
        [Route("{subscriptionId:Guid}")]
        public async Task<ActionResult<ResultModel>> Update(Guid subscriptionId, [FromBody] UpdateSubscriptionRequest request)
        {
            var command = new UpdateSubscriptionCommand(subscriptionId, request);
            var result = await _mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật chứng chỉ thất bại",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật chứng chỉ thành công",
                Success = true,
                Status = 204,
            });
        }
        [HttpDelete]
        [Route("{subscriptionId:Guid}")]
        public async Task<ActionResult<ResultModel>> Remove(Guid subscriptionId)
        {
            var command = await _mediator.Send(new DeleteSubscriptionRequest() { SubscriptionId = subscriptionId });

            if (!command)
            {
                // Trả về lỗi nếu xóa không thành công
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Xóa chứng chỉ không thành công",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa chứng chỉ thành công",
                Status = 204,
                Data = null
            });
        }

    }
}