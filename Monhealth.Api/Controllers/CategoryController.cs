using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Category.AddCategory;
using Monhealth.Application.Features.Category.DeleteCategory;
using Monhealth.Application.Features.Category.Queries.GetAllCategoriesByType;
using Monhealth.Application.Features.Category.Queries.GetCategoryDetail;
using Monhealth.Application.Features.Category.UpdateCategory;
using Monhealth.Application.Features.Metric.Queries.GetAllMetric;
using Monhealth.Application.Models;
using Monhealth.Core.Enum;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
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
        [SwaggerOperation(Summary = "Lấy danh sách danh mục")]
        public async Task<ActionResult<ResultModel>> GetAllCategories(int page = 1, int limit = 10, CategoryType? type = null, string? search = null)
        {

            var categories = await _mediator.Send(new GetCategoryListQuery(page, limit, search, type));

            return new ResultModel
            {
                Data = categories,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("{type}")]
        [SwaggerOperation(Summary = "Lấy danh sách danh mục theo loại")]
        public async Task<ActionResult<ResultModel>> GetCategoriesByType(CategoryType type)
        {
            var categories = await _mediator.Send(new GetCategoriesByTypeQuery { CategoryType = type });

            if (categories == null || !categories.Any())
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Không tìm thấy danh mục phù hợp",
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

        [HttpGet]
        [Route("{categoryId:Guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin danh mục")]
        public async Task<ActionResult<ResultModel>> GetCategoryDetail(Guid categoryId)
        {
            var categories = await _mediator.Send(new GetCategoryDetailQuery { CategoryId = categoryId });

            if (categories == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Không tìm thấy danh mục",
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
        [SwaggerOperation(Summary = "Tạo danh mục")]
        public async Task<ActionResult<ResultModel>> AddCategory([FromBody] AddCategoryRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo danh mục thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo danh mục thất bại",
                Status = 400,
            });
        }

        [HttpPut]
        [Route("{categoryId:Guid}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin danh mục")]
        public async Task<ActionResult<ResultModel>> UpdateCategory(Guid categoryId, [FromBody] UpdateCategoryRequest request)
        {
            var command = new UpdateCategoryCommand(categoryId, request);
            var result = await _mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật thông tin danh mục thất bại",
                    Success = false,
                    Data = null
                };
            return Ok(
                new ResultModel
                {
                    Message = "Cập nhật thông tin danh mục thành công",
                    Success = true,
                    Status = 204,
                }
            );
        }

        [HttpDelete]
        [Route("{categoryId:Guid}")]
        [SwaggerOperation(Summary = "Xóa danh mục")]
        public async Task<ActionResult<ResultModel>> RemoveCategory(Guid categoryId)
        {
            var result = await _mediator.Send(new DeleteCategoryRequest(categoryId));

            if (!result)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Không tìm thấy danh mục",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }

            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa danh mục thành công",
                Status = 204,
                Data = null
            });
        }
    }
}
