using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Payment.Commands.Create;
using Monhealth.Application.Features.Payment.Commands.Update;
using Monhealth.Application.Features.Payment.Queries.GetALL;
using Monhealth.Application.Features.Payment.Queries.GetById;
using Monhealth.Application.Models;
using Monhealth.Core;
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

        [HttpGet]
        [Route("{paymentId:Guid}")]
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
        [Route("{userId:Guid}/user")]
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
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo thanh toán thất bại"
            });
        }

        [HttpPut("{paymentId:guid}")]
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

        // [HttpDelete]
        // [Route("{paymentId:Guid}")]
        // public async Task<ActionResult<ResultModel>> Remove(Guid paymentId)
        // {
        //     var result = await _mediator.Send(new DeletePaymentCommand(paymentId));

        //     if (!result)
        //     {
        //         // Trả về lỗi nếu xóa không thành công
        //         return NotFound(new ResultModel
        //         {
        //             Success = false,
        //             Message = "Xóa thanh toán không thành công",
        //             Status = (int)HttpStatusCode.NotFound,
        //             Data = null
        //         });
        //     }

        //     // Trả về kết quả thành công
        //     return Ok(new ResultModel
        //     {
        //         Success = true,
        //         Message = "Xóa thanh toán thành công",
        //         Status = 204,
        //         Data = null
        //     });
        // }
    }
}