using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/WithDrawalRequests")]
    [ApiController]
    public class WithDrawalRequestController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<ResultModel> Create([FromBody] CreateWithDrawalRequestDTO request)
        {
            var result = await mediator.Send(request);
            if (result)  // Check if 'result' is true
            {
                return new ResultModel
                {
                    Success = true,
                    Message = "Tạo rút tiền thành công",
                    Status = 201,
                };
            }

            return new ResultModel
            {
                Success = false,
                Message = "Tạo rút tiền thất bại",
                Status = 400,
            };
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll()
        {
            var queries = await mediator.Send(new GetWithDrawalRequestListQuery());
            return new ResultModel
            {
                Data = queries,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("{WithDrawalRequestId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetDetail(Guid WithDrawalRequestId)
        {
            var queries = await mediator.
            Send(new GetWithDrawalByIdQuery { WithDrawalRequestId = WithDrawalRequestId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Rút tiền không tồn tại",
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
        [Route("{WithDrawalRequestId:Guid}")]
        public async Task<ActionResult<ResultModel>> Update(Guid WithDrawalRequestId, [FromBody] UpdateWithDrawalDTO request)
        {
            var command = new UpdateWithDrawalRequest(request, WithDrawalRequestId);
            var result = await mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật rút tiền không thành công",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật rút tiền thành công",
                Success = true,
                Status = 204,
            });
        }
        [HttpDelete]
        [Route("{WithDrawalRequestId:Guid}")]
        public async Task<ActionResult<ResultModel>> Remove(Guid WithDrawalRequestId)
        {
            var result = await mediator.Send(new RemoveWithdrawRequest(WithDrawalRequestId));

            if (!result)
            {
                // Trả về lỗi nếu xóa không thành công
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Xóa rút tiền không thành công",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }

            // Trả về kết quả thành công
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa rút tiền thành công",
                Status = 204,
                Data = null
            });
        }
    }
}