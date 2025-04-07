using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Payment.Commands.Create;
using Monhealth.Application.Features.Payment.Commands.Update;
using Monhealth.Application.Features.Payment.Commands.UpdateStatusPayments;
using Monhealth.Application.Features.Payment.Queries.GetALL;
using Monhealth.Application.Features.Payment.Queries.GetById;
using Monhealth.Application.Features.Payment.Queries.GetBySubcriptionId;
using Monhealth.Application.Models;
using Monhealth.Core;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/payments")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PaymentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách thanh toán")]
        public async Task<ActionResult<ResultModel>> GetAllPayment(int page = 1, int limit = 10, string search = "", PaymentStatus? status = null)
        {
            var queries = await _mediator.Send(new GetPaymentListQuery(page, limit, search, status));

            return new ResultModel
            {
                Data = queries,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("subscription/{subscriptionId}")]
        [SwaggerOperation(Summary = "Lấy danh sách thanh toán theo ID gói đăng ký")]
        public async Task<ActionResult<ResultModel>> GetPaymentBySubscriptionId(Guid subscriptionId)
        {
            var queries = await _mediator.Send(new GetpaymentBySubcriptionIdQuery { SubscriptionId = subscriptionId });

            return new ResultModel
            {
                Data = queries,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("{paymentId:Guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin thanh toán theo ID")]
        public async Task<ActionResult<ResultModel>> GetReviewDetail(Guid paymentId)
        {
            var queries = await _mediator.
            Send(new GetPaymentByIdQuery { PaymentId = paymentId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Thanh toán không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpGet]
        [Route("user/{userId:Guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin thanh toán theo ID người dùng")]
        public async Task<ActionResult<ResultModel>> GetReviewByUser(Guid userId)
        {
            var queries = await _mediator.
            Send(new GetUserListQuery { UserId = userId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Thanh toán không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo thanh toán")]
        public async Task<ActionResult<ResultModel>> Create([FromBody] AddPaymentRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo thanh toán thành công",
                    Status = 201,
                    Data = result
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo thanh toán thất bại",
            });
        }

        [HttpPut("{paymentId:guid}")]
        [SwaggerOperation(Summary = "Cập nhật thanh toán")]
        public async Task<IActionResult> UpdatePayment([FromRoute] Guid paymentId, [FromBody] UpdatePaymentDto updatePaymentDto)
        {
            var command = new UpdatePaymentCommand(paymentId, updatePaymentDto);
            var result = await _mediator.Send(command);

            if (!result)
                return NotFound("Không tìm thấy thanh toán nào.");

            return Ok(new ResultModel
            {
                Success = true,
                Message = "Cập nhật thanh toán thành công",
                Status = 204,
            });
        }

        [HttpDelete]
        [Route("{paymentId:Guid}")]
        [SwaggerOperation(Summary = "Xóa thanh toán")]
        public async Task<ActionResult<ResultModel>> Remove(Guid paymentId)
        {
            var result = await _mediator.Send(new DeletePaymentCommand(paymentId));

            if (!result)
            {
                // Trả về lỗi nếu xóa không thành công
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Xóa thanh toán không thành công",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }

            // Trả về kết quả thành công
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa thanh toán thành công",
                Status = 204,
                Data = null
            });
        }

        [HttpPatch("{paymentId:guid}/completed")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái thanh toán")]
        public async Task<ActionResult<ResultModel>> ChangePaymentStatus([FromRoute] Guid paymentId)
        {
            var result = await _mediator.Send(new UpdateStatusPaymentQueries { PaymentId = paymentId });
            if (!result)
            {
                return BadRequest(new ResultModel
                {
                    Success = false,
                    Message = "Cập nhập trạng thái thanh toán thất bại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }

            // Trả về kết quả thành công
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Cập nhập trạng thái thanh toán thành công",
                Status = 204,
                Data = null
            });
        }
    }
}