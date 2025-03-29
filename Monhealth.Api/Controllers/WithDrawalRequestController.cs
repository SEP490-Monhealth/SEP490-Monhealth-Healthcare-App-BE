using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/withdrawal-requests")]
    [ApiController]
    public class WithdrawalRequestController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
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

        [HttpGet]
        [Route("{WithdrawalRequestId:Guid}/generate-qr")]
        public async Task<ResultModel> CreateWithdrawalRequest(Guid WithdrawalRequestId)
        {
            var command = new GenerateWithdrawalQRCode(WithdrawalRequestId);

            var result = await mediator.Send(command); // result là Response chứa QR code

            return new ResultModel
            {
                Success = true,
                Message = "Tạo rút tiền thành công",
                Status = 201,
                Data = result
            };
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll()
        {
            var queries = await mediator.Send(new GetWithdrawalRequestListQuery());
            return new ResultModel
            {
                Data = queries,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("{withdrawalRequestId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetDetail(Guid WithdrawalRequestId)
        {
            var queries = await mediator.
            Send(new GetWithdrawalByIdQuery { WithdrawalRequestId = WithdrawalRequestId });

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

        [HttpPut]
        [Route("{withdrawalRequestId:Guid}")]
        public async Task<ActionResult<ResultModel>> Update(Guid WithdrawalRequestId, [FromBody] UpdateWithdrawalDTO request)
        {
            var command = new UpdateWithdrawalRequest(request, WithdrawalRequestId);
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
        public async Task<ActionResult<ResultModel>> Remove(Guid WithdrawalRequestId)
        {
            var result = await mediator.Send(new RemoveWithdrawRequest(WithdrawalRequestId));

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
        [Route("{WithdrawalRequestId:Guid}")]
        public async Task<ActionResult<ResultModel>> UpdateStatus(Guid WithdrawalRequestId)
        {
            try
            {
                var command = new UpdateStatusWithdrawalCommand(WithdrawalRequestId);
                await mediator.Send(command); // trả về Unit, không cần kiểm tra

                return Ok(new ResultModel
                {
                    Message = "Cập nhật trạng thái rút tiền thành công",
                    Success = true,
                    Status = 204
                });
            }
            catch (Exception ex)
            {
                return Ok(new ResultModel
                {
                    Message = $"Cập nhật trạng thái rút tiền không thành công: {ex.Message}",
                    Success = false,
                    Data = null
                });
            }
        }

        [HttpPatch]
        [Route("{WithdrawalRequestId:Guid}/reject")]
        public async Task<ActionResult<ResultModel>> Reject(Guid WithdrawalRequestId)
        {
            try
            {
                var command = new CancelWithdrawalStatusCommand(WithdrawalRequestId);
                await mediator.Send(command); // trả về Unit, không cần kiểm tra

                return Ok(new ResultModel
                {
                    Message = "Cập nhật trạng thái rút tiền thành công",
                    Success = true,
                    Status = 204
                });
            }
            catch (Exception ex)
            {
                return Ok(new ResultModel
                {
                    Message = $"Cập nhật trạng thái rút tiền không thành công: {ex.Message}",
                    Success = false,
                    Data = null
                });
            }
        }

    }
}