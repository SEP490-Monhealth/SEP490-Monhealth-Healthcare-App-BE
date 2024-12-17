using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Category.AddCategory;
using Monhealth.Application.Features.Category.DeleteCategory;
using Monhealth.Application.Features.Category.Queries.GetCategoryDetail;
using Monhealth.Application.Features.Category.UpdateCategory;
using Monhealth.Application.Features.Metric.Queries.GetAllMetric;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllCategories()
        {
            var categories = await _mediator.Send(new GetCategoryListQuery());

            return new ResultModel
            {
                Data = categories,
                Status = 200,
                Success = true
            };
        }
        [HttpGet]
        [Route("{categoryId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetCategoryDetail(Guid categoryId)
        {
            var categories = await _mediator.
            Send(new GetCategoryDetailQuery() { CategoryId = categoryId });

            if (categories == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Loại đồ ăn không tồn tại.",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = categories
            });
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddCategory([FromBody] AddCategoryRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo loại đồ ăn thành công.",
                    Status = 201,

                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo loại đồ ăn thất bại."
            });
        }
        [HttpDelete]
        [Route("{categoryId:Guid}")]
        public async Task<ActionResult<ResultModel>> RemoveCategory(Guid categoryId)
        {
            var result = await _mediator.Send(new DeleteCategoryRequest(categoryId));

            if (!result)
            {
                // Trả về lỗi nếu xóa không thành công
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Loại đồ ăn không tồn tại.",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }

            // Trả về kết quả thành công
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa loại đồ ăn thành công.",
                Status = 204,
                Data = null
            });
        }
        [HttpPut]
        [Route("{categoryId:Guid}")]
        public async Task<ActionResult<ResultModel>> UpdateCategory(Guid categoryId, [FromBody] UpdateCategoryRequest request)
        {
            var command = new UpdateCategoryCommand(categoryId, request);
            var result = await _mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật loại đồ ăn thất bại.",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật loại đồ ăn thành công.",
                Success = true,
                Status = 204,
            });
        }
    }
}
