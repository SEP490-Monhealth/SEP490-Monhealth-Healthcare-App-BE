using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Payment.Commands.Create;
using Monhealth.Application.Features.Payment.Commands.Update;
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
    }
}