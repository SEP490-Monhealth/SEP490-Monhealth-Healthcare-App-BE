using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Category.AddCategory;
using Monhealth.Application.Features.Category.Queries.GetCategoryDetail;
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
        public async Task<ActionResult<ResultModel>> GetAllMetrics()
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
                    Message = "Category not found.",
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
        public async Task<ActionResult<ResultModel>> AddCategory([FromBody] AddCategoryQuery request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Category added successfully",
                    Status = 201,

                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Failed to add category"
            });
        }
    }
}