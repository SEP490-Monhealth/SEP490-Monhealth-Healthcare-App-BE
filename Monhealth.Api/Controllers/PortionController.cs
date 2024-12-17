using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Monhealth.Application.Features.Portions.Commands.CreateFoodPortion;
using Monhealth.Application.Features.Portions.Commands.DeletePortion;
using Monhealth.Application.Features.Portions.Commands.UpdateFoodPortion;
using Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion;
using Monhealth.Application.Features.Portions.Queries.GetPortionById;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/portions")]
    [ApiController]
    public class PortionController : Controller
    {
        private readonly IMediator _mediator;
        public PortionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllPortions([FromQuery]int page = 1, [FromQuery]int limit = 10)
        {
            var query = new GetAllPortionQuery(page, limit);
            var result = await _mediator.Send(query);
            return new ResultModel
            {
                Data = result,
                Message = "Lấy danh sách khẩu phần ăn thành công",
                Status = 200,
                Success = true
            };
        }
        [HttpGet("{portionId:guid}")]
        public async Task<ActionResult<ResultModel>> GetPortionById(Guid portionId)
        {
            var portion = await _mediator.Send(new GetPortionByIdQuery() { PortionId = portionId });
            if(portion == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy khẩu phần ăn"
                };
            }
            return new ResultModel
            {
                Data = portion,
                Message = "Lấy khẩu phần ăn thành công",
                Status = 200,
                Success = true
            };
        }
        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateFoodPortion([FromBody]CreatePortionCommand createPortion)
        {
            var create = await _mediator.Send(createPortion);
            if(create == null)
            {
                return new ResultModel
                {
                    Message = "Tạo khẩu phần ăn thất bại",
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false
                };
            }
            return new ResultModel
            {
                Message = "Tạo khẩu phần ăn thành công",
                Status = 200,
                Success = true
            };
        }
        [HttpPut("{portionId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid portionId, [FromBody] UpdatePortionCommand updatePortion)
        {
            updatePortion.PortionId = portionId;
            var update = await _mediator.Send(updatePortion);
            if(!update)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật khẩu phần ăn thất bại."
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật khẩu phần ăn thành công."
            };
        }
        [HttpDelete("{portionId}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid portionId)
        {
            var command = new DeletePortionCommand { PortionId = portionId };
            var delete = await _mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Xóa khẩu phần ăn thất bại."
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa khẩu phần ăn thành công."
            };
        }
    }
}
