using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Transaction.Commands.CreateBookingSingle;
using Monhealth.Application.Features.Transaction.Commands.CreateTransaction;
using Monhealth.Application.Features.Transaction.Commands.CreateUpgradeSubscriptionPayment;
using Monhealth.Application.Features.Transaction.Commands.UpdateStatusForBookingSingle;
using Monhealth.Application.Features.Transaction.Commands.UpdateTransaction;
using Monhealth.Application.Features.Transaction.Queries.GetAllTransactions;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionByCreatedBy;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionById;
using Monhealth.Application.Features.Transaction.Queries.GetTransactionBySubscriptionId;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;
using Net.payOS.Types;
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

        [HttpGet("user/{userId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách giao dịch theo người dùng")]
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
        [SwaggerOperation(Summary = "Lấy danh sách giao dịch theo chuyên viên")]
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
        [SwaggerOperation(Summary = "Lấy danh sách giao dịch theo gói đăng ký")]
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

        [HttpGet("monthly/consultants/{consultantId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách giao dịch theo tháng của chuyên viên")]
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
        [SwaggerOperation(Summary = "Lấy thông tin giao dịch")]
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
        [SwaggerOperation(Summary = "Lấy mã QR giao dịch")]
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

        [HttpGet("{transactionId:guid}/status")]
        [SwaggerOperation(Summary = "Lấy trạng thái giao dịch")]
        public async Task<ActionResult<ResultModel>> GetTransactionStatusById(Guid transactionId)
        {
            var transaction = await mediator.Send(new GetTransactionStatusByTransactionQuery { TransactionId = transactionId });
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

        [HttpPost("subscription")]
        [SwaggerOperation(Summary = "Tạo giao dịch nâng cấp gói đăng ký")]
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
        [SwaggerOperation(Summary = "Tạo giao dịch thanh toán lượt đặt lịch")]
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
                Status = 400,
            });
        }

        [HttpPost("webhook")]
        [SwaggerOperation(Summary = "Webhook thanh toán")]
        public async Task<ActionResult<ResultModel>> ChangeTransactionStatusForBookingSingle([FromBody] WebhookType webhookType)
        {
            var result = await mediator.Send(new UpdateStatusBookingSingleQuery { WebhookType = webhookType });
            if (!result)
            {
                return Ok(new ResultModel
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

        [HttpPatch("{transactionId}/completed")]
        [SwaggerOperation(Summary = "Hoàn thành giao dịch")]

        public async Task<ActionResult<ResultModel>> ChangeStatusCompletedTransaction(Guid transactionId)
        {
            var command = new UpdateTransactionStatusQuery { TransactionId = transactionId };
            var changeStatus = await mediator.Send(command);
            if (!changeStatus)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Hoàn thành trạng thái giao dịch thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Hoàn thành trạng thái giao dịch thành công"
            };
        }
    }
}

