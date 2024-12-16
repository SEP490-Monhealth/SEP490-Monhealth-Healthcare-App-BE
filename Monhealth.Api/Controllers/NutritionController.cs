using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition;
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
    }
}