using System.Net;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Consultant.Commands.CreateConsultant;
using Monhealth.Application.Features.Transaction.Commands.CreateTransaction;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/transactions")]
    [ApiController]
    public class TransactionController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateTransaction([FromBody] CreateTransactionDTO createTransactionDTO)
        {
            var command = new CreateTransactionCommand(createTransactionDTO);
            var createTransaction = await mediator.Send(command);
            if (createTransaction == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo thanh toán thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo thanh toán thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }
    }
}
