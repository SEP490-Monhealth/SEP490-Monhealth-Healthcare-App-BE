using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Payment.Commands.Create;
using Monhealth.Application.Features.Payment.Commands.Update;
using Monhealth.Application.Features.Payment.Queries.GetALL;
using Monhealth.Application.Features.Payment.Queries.GetById;
using Monhealth.Application.Models;

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
        [HttpPatch]
        public async Task<IActionResult> UpdatePayment([FromQuery] Guid paymentId, [FromQuery] int amount)
        {
            var command = new UpdatePaymentCommand(paymentId, amount);
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
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllReviews()
        {
            var queries = await _mediator.Send(new GetPaymentListQuery());

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
    }
}