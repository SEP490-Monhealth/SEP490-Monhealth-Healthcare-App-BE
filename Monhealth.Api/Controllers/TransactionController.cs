using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Transaction.Commands.CreateTransaction;
using Monhealth.Application.Features.Transaction.Commands.DeleteTransaction;
using Monhealth.Application.Features.Transaction.Commands.UpdateTransaction;
using Monhealth.Application.Features.Transaction.Queries.GetAllTransactions;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionById;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/transactions")]
    [ApiController]
    public class TransactionController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllTransactions(int page = 1, int limit = 10, TransactionType? transactionType = null, StatusTransaction? status = null)
        {
            var transactionsList = await mediator.Send(new GetAllTransactionsQuery(page, limit, transactionType, status));

            return new ResultModel
            {
                Data = transactionsList,
                Status = 200,
                Success = true
            };
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

        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateTransaction([FromBody] CreateTransactionDTO createTransactionDTO)
        {
            var command = new CreateTransactionCommand(createTransactionDTO);
            var createTransaction = await mediator.Send(command);
            if (createTransaction == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo giao dịch thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo giao dịch thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut ("{TransactionId}")]
        public async Task<ActionResult<ResultModel>> UpdateTransaction(Guid TransactionId ,[FromBody] UpdateTransactionDTO updateTransactionDTO)
        {
            var command = new UpdateTransactionCommand(TransactionId ,updateTransactionDTO);
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
