using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Meal.Queries.GetAllMeals;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/meals")]
    [ApiController]
    public class MealController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MealController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllCategories()
        {
            var categories = await _mediator.Send(new GetMealListQuery());

            return new ResultModel
            {
                Data = categories,
                Status = 200,
                Success = true
            };
        }
    }
}