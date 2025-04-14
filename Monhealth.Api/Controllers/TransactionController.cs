using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.TimeSlots.Commands.ChangeCompletedTransaction;
using Monhealth.Application.Features.Transaction.Commands.CreateBookingSingle;
using Monhealth.Application.Features.Transaction.Commands.CreateTransaction;
using Monhealth.Application.Features.Transaction.Commands.CreateUpgradeSubscriptionPayment;
using Monhealth.Application.Features.Transaction.Commands.DeleteTransaction;
using Monhealth.Application.Features.Transaction.Commands.UpdateStatusForBookingSingle;
using Monhealth.Application.Features.Transaction.Commands.UpdateTransaction;
using Monhealth.Application.Features.Transaction.Queries.GetAllTransactions;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionByCreatedBy;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionById;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionBySubscriptionId;
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

        [HttpGet("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetTransactionByCreatedBy([FromRoute] Guid userId, int page = 1, int limit = 10)
        {
            var transaction = await mediator.Send(new GetTransactionByCreatedByQuery
            {
                UserId = userId,
                Page = page,
                Limit = limit
            });
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = transaction
            });
        }

        [HttpGet("consultant/{consultantId:guid}")]
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


        [HttpGet("subscription/{subscriptionId:guid}")]
        public async Task<ActionResult<ResultModel>> GetTransactionBySubscriptionId([FromRoute] Guid subscriptionId)
        {
            var transaction = await mediator.Send(new GetTransactionBySubscriptionIdQuery { SubscriptionId = subscriptionId });

            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = transaction
            });
        }

        [HttpGet("monthly/consultants/{consultant:guid}")]
        public async Task<ActionResult<ResultModel>> GetTransactionByCreatedBy(Guid consultant, int page = 1, int limit = 10, string? month = null)
        {
            var transaction = await mediator.Send(new GetTransactionByConsultantQuery(page, limit, month, consultant));
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

        [HttpGet]
        [Route("{transactionId:Guid}/qr-code")]
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

        [HttpPost("subscription")]
        public async Task<ActionResult<ResultModel>> Create([FromBody] CreateUpgradeRequest request)
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

        [HttpPost("booking")]
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

        [HttpPut("{transactionId}")]
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

        // [HttpDelete("{transactionId}")]
        // [SwaggerOperation(Summary = "")]
        // public async Task<ActionResult<ResultModel>> DeleteTransaction(Guid transactionId)
        // {
        //     var command = new DeleteTransactionCommand { TransactionId = transactionId };
        //     var delete = await mediator.Send(command);
        //     if (!delete)
        //     {
        //         return new ResultModel
        //         {
        //             Success = false,
        //             Status = (int)HttpStatusCode.NotFound,
        //             Message = "Không tìm thấy giao dịch"
        //         };
        //     }
        //     return new ResultModel
        //     {
        //         Success = true,
        //         Status = (int)HttpStatusCode.OK,
        //         Message = "Xóa giao dịch thành công"
        //     };
        // }

        [HttpPatch("{orderCode:long}/completed")]
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

        //[HttpPatch("subscription/{orderCode:long}/completed")]
        //public async Task<ActionResult<ResultModel>> ChangePaymentStatus([FromRoute] long orderCode)
        //{
        //    var result = await mediator.Send(new UpdateUpgradeStatusQuery { OrderCode = orderCode });
        //    if (!result)
        //    {
        //        return BadRequest(new ResultModel
        //        {
        //            Success = false,
        //            Message = "Cập nhập trạng thái thanh toán thất bại",
        //            Status = (int)HttpStatusCode.NotFound,
        //            Data = null
        //        });
        //    }

        //    // Trả về kết quả thành công
        //    return Ok(new ResultModel
        //    {
        //        Success = true,
        //        Message = "Cập nhập trạng thái thanh toán thành công",
        //        Status = 204,
        //        Data = null
        //    });
        //}

        [HttpPatch("{transactionId}/completed")]
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

