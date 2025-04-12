using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.TimeSlots.Commands.ChangeCompletedTransaction;
using Monhealth.Application.Features.Transaction.Commands.CreateBookingSingle;
using Monhealth.Application.Features.Transaction.Commands.CreateTransaction;
using Monhealth.Application.Features.Transaction.Commands.DeleteTransaction;
using Monhealth.Application.Features.Transaction.Commands.UpdateStatusForBookingSingle;
using Monhealth.Application.Features.Transaction.Commands.UpdateTransaction;
using Monhealth.Application.Features.Transaction.Queries.GetAllTransactions;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionById;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/transactions")]
    [ApiController]
    public class TransactionController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách giao dịch")]
        public async Task<ActionResult<ResultModel>> GetAllTransactions(int page = 1, int limit = 10, TransactionType? type = null, string? search = null, StatusTransaction? status = null)
        {
            var transactionsList = await mediator.Send(new GetAllTransactionsQuery(page, limit, type, search, status));

            return new ResultModel
            {
                Data = transactionsList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("consultant/{consultantId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách giao dịch theo ID chuyên viên")]
        public async Task<ActionResult<ResultModel>> GetTransactionByConsultantId(Guid consultantId, int page = 1, int limit = 10, StatusTransaction? status = null)
        {
            var transaction = await mediator.Send(new GetTransactionByConsultantIdQuery(consultantId, page, limit, status));
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = transaction
            });
        }
        [HttpGet]
        [Route("{transactionId:Guid}/qr-code")]
        [SwaggerOperation(Summary = "Tạo QR code cho yêu cầu rút tiền")]
        public async Task<ResultModel> CreateWithdrawalRequest(Guid transactionId)
        {
            var command = new GenerateTransactionQRCode(transactionId);

            var result = await mediator.Send(command); // result là Response chứa QR code

            return new ResultModel
            {
                Success = true,
                Message = "Tạo QR rút tiền thành công",
                Status = 200,
                Data = result
            };
        }

        [HttpGet("{transactionId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin thông tin giao dịch")]
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
        [SwaggerOperation(Summary = "Tạo giao dịch")]
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

        [HttpPost("buy-booking")]
        [SwaggerOperation(Summary = "Tạo thanh toán cho đặt lịch đơn")]
        public async Task<ActionResult<ResultModel>> CreateBookingSingle([FromBody] BookingSingleRequest request)
        {
            var result = await mediator.Send(request);
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

        [HttpPatch("{orderCode:long}/completed")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái thanh toán cho đặt lịch đơn")]
        public async Task<ActionResult<ResultModel>> ChangeTransactionStatusForBookingSingle([FromRoute] long orderCode)
        {
            var result = await mediator.Send(new UpdateStatusBookingSingleQuery { OrderCode = orderCode });
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

        [HttpPut("{TransactionId}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin giao dịch")]
        public async Task<ActionResult<ResultModel>> UpdateTransaction(Guid TransactionId, [FromBody] UpdateTransactionDTO updateTransactionDTO)
        {
            var command = new UpdateTransactionCommand(TransactionId, updateTransactionDTO);
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
        [SwaggerOperation(Summary = "Xóa giao dịch")]
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
        [HttpPatch("{transactionId}/completed")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái giao dịch")]
        public async Task<ActionResult<ResultModel>> ChangeStatusCompletedTransaction(Guid transactionId)
        {
            var command = new ChangeCompletedTransactionCommand { transactionId = transactionId };
            var changeStatus = await mediator.Send(command);
            if (!changeStatus)
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
                Message = "Cập nhật trạng thái giao dịch thành công"
            };
        }
    }
}

