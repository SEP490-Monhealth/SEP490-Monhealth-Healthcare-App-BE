using System.Net;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Consultant.Commands.CreateConsultant;
using Monhealth.Application.Features.Consultant.Commands.DeleteConsultant;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;
using Monhealth.Application.Features.Consultant.Queries.GetConsultantById;
using Monhealth.Application.Features.Exercise.Commands.UpdateExercise;
using Monhealth.Application.Features.Transaction.Commands.CreateTransaction;
using Monhealth.Application.Features.Transaction.Commands.DeleteTransaction;
using Monhealth.Application.Features.Transaction.Commands.UpdateTransaction;
using Monhealth.Application.Features.Transaction.Queries.GetAllTransactions;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionById;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/transactions")]
    [ApiController]
    public class TransactionController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllTransactions(int page = 1, int limit = 10)
        {
            var transactionsList = await mediator.Send(new GetAllTransactionsQuery(page, limit));

            return new ResultModel
            {
                Data = transactionsList,
                Status = 200,
                Success = true
            };
        }
        [HttpGet("{transactionId:guid}")]
        public async Task<ActionResult<ResultModel>> GetTransactionById(Guid transactionId)
        {
            var transaction = await mediator.Send(new GetTransactionByIdQuery { TransactionId = transactionId });
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = transaction
            });
        }
        [HttpGet("consultant/{consultantId:guid}")]
        public async Task<ActionResult<ResultModel>> GetTransactionByConsultantId(Guid consultantId)
        {
            var transaction = await mediator.Send(new GetTransactionByConsultantIdQuery { ConsultantId = consultantId });
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = transaction
            });
        }
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
        [HttpPut("{transactionId}")]
        public async Task<ActionResult<ResultModel>> UpdateTransaction(Guid transactionId, [FromBody] UpdateTransactionDTO updateTransactionDTO)
        {
            var command = new UpdateTransactionCommand(transactionId, updateTransactionDTO);
            var result = await mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật giao dịch thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật giao dịch thành công"
            };
        }
        [HttpDelete("{transactionId}")]
        public async Task<ActionResult<ResultModel>> DeleteTransaction(Guid transactionId)
        {
            var command = new DeleteTransactionCommand { TransactionId = transactionId };
            var delete = await mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy giao dịch"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa giao dịch thành công"
            };
        }
    }
}
