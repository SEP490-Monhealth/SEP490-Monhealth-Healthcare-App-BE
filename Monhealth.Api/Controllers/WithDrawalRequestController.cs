using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Withdrawal.Commands.ChangeToApproveStatus;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/withdrawal-requests")]
    [ApiController]
    public class WithdrawalRequestController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách yêu cầu rút tiền")]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, string? search = null, WithdrawalStatus? status = null)
        {
            var queries = await mediator.Send(new GetWithdrawalRequestListQuery(page, limit, search, status));
            return new ResultModel
            {
                Data = queries,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("consultant/{consultantId:Guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách yêu cầu rút tiền theo ID chuyên viên")]
        public async Task<ActionResult<ResultModel>> GetByConsultant(Guid consultantId, int page = 1, int limit = 10)
        {
            var queries = await mediator.
            Send(new GetByConsultantRequest(consultantId, page, limit));

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Yêu cầu rút tiền không tồn tại",
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
        [Route("{withdrawalRequestId:Guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin yêu cầu rút tiền theo ID")]
        public async Task<ActionResult<ResultModel>> GetDetail(Guid withdrawalRequestId)
        {
            var queries = await mediator.
            Send(new GetWithdrawalByIdQuery { WithdrawalRequestId = withdrawalRequestId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Yêu cầu rút tiền không tồn tại",
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
        [Route("{withdrawalRequestId:Guid}/generate-qr")]
        [SwaggerOperation(Summary = "Tạo QR code cho yêu cầu rút tiền")]
        public async Task<ResultModel> CreateWithdrawalRequest(Guid withdrawalRequestId)
        {
            var command = new GenerateWithdrawalQRCode(withdrawalRequestId);

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
        [SwaggerOperation(Summary = "Tạo yêu cầu rút tiền")]
        public async Task<ResultModel> Create([FromBody] CreateWithdrawalRequestDTO request)
        {
            var result = await mediator.Send(request);
            if (result)  // Check if 'result' is true
            {
                return new ResultModel
                {
                    Success = true,
                    Message = "Tạo yêu cầu rút tiền thành công",
                    Status = 201,
                };
            }

            return new ResultModel
            {
                Success = false,
                Message = "Tạo yêu cầu rút tiền thất bại",
                Status = 400,
            };
        }

        [HttpPut]
        [Route("{withdrawalRequestId:Guid}")]
        [SwaggerOperation(Summary = "Cập nhật yêu cầu rút tiền")]
        public async Task<ActionResult<ResultModel>> Update(Guid withdrawalRequestId, [FromBody] UpdateWithdrawalDTO request)
        {
            var command = new UpdateWithdrawalRequest(request, withdrawalRequestId);
            var result = await mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật yêu cầu rút tiền không thành công",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật yêu cầu rút tiền thành công",
                Success = true,
                Status = 204,
            });
        }

        [HttpDelete]
        [Route("{withdrawalRequestId:Guid}")]
        [SwaggerOperation(Summary = "Xóa yêu cầu rút tiền")]
        public async Task<ActionResult<ResultModel>> Remove(Guid withdrawalRequestId)
        {
            var result = await mediator.Send(new RemoveWithdrawRequest(withdrawalRequestId));

            if (!result)
            {
                // Trả về lỗi nếu xóa không thành công
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Xóa yêu cầu rút tiền không thành công",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }

            // Trả về kết quả thành công
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa yêu cầu rút tiền thành công",
                Status = 204,
                Data = null
            });
        }

        [HttpPatch]
        [Route("{withdrawalRequestId:Guid}/approve")]
        [SwaggerOperation(Summary = "Chấp nhận yêu cầu rút tiền")]
        public async Task<ActionResult<ResultModel>> Approve(Guid withdrawalRequestId)
        {
            var command = new ChangeToApproveStatusCommand
            {
                WithdrawalRequestId = withdrawalRequestId
            };
            await mediator.Send(command);

            return Ok(
                new ResultModel
                {
                    Message = "Chấp nhận trạng thái rút tiền thành công",
                    Success = true,
                    Status = 204
                }
            );
        }

        [HttpPatch]
        [Route("{withdrawalRequestId:Guid}/reject")]
        [SwaggerOperation(Summary = "Từ chối yêu cầu rút tiền")]
        public async Task<ActionResult<ResultModel>> Reject(Guid withdrawalRequestId)
        {
            var command = new CancelWithdrawalStatusCommand(withdrawalRequestId);
            await mediator.Send(command);

            return Ok(
                new ResultModel
                {
                    Message = "Từ chối trạng thái rút tiền thành công",
                    Success = true,
                    Status = 204
                }
            );
        }

        [HttpPatch]
        [Route("{withdrawalRequestId:Guid}/status")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái yêu cầu rút tiền")]
        public async Task<ActionResult<ResultModel>> UpdateStatus(Guid withdrawalRequestId)
        {
            var command = new UpdateStatusWithdrawalCommand(withdrawalRequestId);
            await mediator.Send(command);

            return Ok(
                new ResultModel
                {
                    Message = "Cập nhật trạng thái rút tiền thành công",
                    Success = true,
                    Status = 204
                }
            );
        }
    }
}