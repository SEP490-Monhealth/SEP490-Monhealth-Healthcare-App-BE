using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Category.Queries.GetCategoryDetail;
using Monhealth.Application.Features.Nutrition.AddNutrition;
using Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition;
using Monhealth.Application.Features.Nutrition.Queries.GetAllNutritionByfoodId;
using Monhealth.Application.Features.Nutrition.Queries.GetNutritionDetail;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/nutritions")]
    [ApiController]
    public class NutritionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public NutritionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllMetrics()
        {
            var nutritionList = await _mediator.Send(new GetNutritionListQuery());

            return new ResultModel
            {
                Data = nutritionList,
                Status = 200,
                Success = true
            };
        }
        [HttpGet]
        [Route("{nutritionId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetNutritionDetail(Guid nutritionId)
        {
            var queries = await _mediator.
            Send(new GetNutritionDetailQuery() { NutritionId = nutritionId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "nutrition not found.",
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
        [Route("food/{foodId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetNutritionByFoodIdDetail(Guid foodId)
        {
            var queries = await _mediator.
            Send(new GetNutritionByFoodIdListQuery() { FoodId = foodId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "nutrition not found.",
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
        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddNutrition([FromBody] AddNutritionRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "nutrition added successfully.",
                    Status = 201,

                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Failed to add nutrition."
            });
        }
    }
}