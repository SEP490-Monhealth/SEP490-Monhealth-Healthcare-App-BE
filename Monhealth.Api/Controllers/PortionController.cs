﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Portions.Commands.CreateFoodPortion;
using Monhealth.Application.Features.Portions.Commands.DeletePortion;
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
    [Authorize]
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
        [SwaggerOperation(Summary = "Lấy danh sách khẩu phần ăn")]
        public async Task<ActionResult<ResultModel>> GetAllPortions(int page = 1, int limit = 10, [FromQuery] string sort = null, string order = null)
        {
            var query = new GetAllPortionQuery(page, limit, sort, order);
            var result = await _mediator.Send(query);
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("{portionId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin khẩu phần ăn")]
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
        [SwaggerOperation(Summary = "Lấy danh sách khẩu phần ăn theo thực phẩm")]
        public async Task<ActionResult<ResultModel>> GetPortionsByFoodId(Guid foodId, int page = 1, int limit = 10, string? search = null, string? sort = null, string? order = null)
        {
            var portion = await _mediator.Send(new GetPortionsByFoodIdQuery(foodId, page, limit, search, sort, order));
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
            };
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo khẩu phần ăn")]
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
        [SwaggerOperation(Summary = "Cập nhật thông tin khẩu phần ăn")]
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
                    Message = "Cập nhật thông tin khẩu phần ăn thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật thông tin khẩu phần ăn thành công"
            };
        }

        [HttpDelete("{portionId}")]
        [SwaggerOperation(Summary = "Xóa khẩu phần ăn")]
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
                    Message = "Xóa khẩu phần ăn thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa khẩu phần ăn thành công"
            };
        }
    }
}
