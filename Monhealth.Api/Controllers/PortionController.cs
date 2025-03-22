using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Portions.Commands.CreateFoodPortion;
using Monhealth.Application.Features.Portions.Commands.UpdateFoodPortion;
using Monhealth.Application.Features.Portions.Commands.UpdatePortion;
using Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion;
using Monhealth.Application.Features.Portions.Queries.GetPortionById;
using Monhealth.Application.Features.Portions.Queries.GetPortionsByFoodId;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
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
        public async Task<ActionResult<ResultModel>> GetAllPortions(int page = 1, int limit = 10, [FromQuery] string sort = null, string order = null)
        {
            var query = new GetAllPortionQuery(page, limit, sort, order);
            var result = await _mediator.Send(query);
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true,
                Message = "Lấy danh sách khẩu phần ăn thành công"
            };
        }

        [HttpGet("{portionId:guid}")]
        public async Task<ActionResult<ResultModel>> GetPortionById(Guid portionId)
        {
            var portion = await _mediator.Send(new GetPortionByIdQuery() { PortionId = portionId });
            if (portion == null)
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
                Status = 200,
                Success = true
            };
        }

        [HttpGet("food/{foodId}")]
        [SwaggerOperation(Summary = "Done")]
        public async Task<ActionResult<ResultModel>> GetPortionsByFoodId(Guid foodId)
        {
            var portion = await _mediator.Send(new GetPortionsByFoodIdQuery() { FoodId = foodId });
            if (portion == null)
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
                Status = 200,
                Success = true,
                Message = "Lấy khẩu phần ăn thành công"
            };
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Done")]
        public async Task<ActionResult<ResultModel>> CreateFoodPortion([FromBody] CreatePortionCommand createPortion)
        {
            var create = await _mediator.Send(createPortion);
            if (create == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo khẩu phần ăn thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo khẩu phần ăn thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut("{portionId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid portionId, [FromBody] UpdatePortionRequest updatePortion)
        {
            var command = new UpdatePortionCommand(portionId, updatePortion);
            var result = await _mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật khẩu phần ăn thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật khẩu phần ăn thành công"
            };
        }

        // [HttpDelete("{portionId}")]
        // public async Task<ActionResult<ResultModel>> Delete(Guid portionId)
        // {
        //     var command = new DeletePortionCommand { PortionId = portionId };
        //     var delete = await _mediator.Send(command);
        //     if (!delete)
        //     {
        //         return new ResultModel
        //         {
        //             Success = false,
        //             Status = (int)HttpStatusCode.NotFound,
        //             Message = "Xóa khẩu phần ăn thất bại"
        //         };
        //     }
        //     return new ResultModel
        //     {
        //         Success = true,
        //         Status = (int)HttpStatusCode.OK,
        //         Message = "Xóa khẩu phần ăn thành công"
        //     };
        // }
    }
}
