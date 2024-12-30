using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.DailyMeal.Queries.GetAllDailyMeal;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/dailyMeals")]
    [ApiController]
    public class DailyMealController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DailyMealController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllDailyMeals()
        {
            var dailyMeals = await _mediator.Send(new GetDailyMealQuery());

            return new ResultModel
            {
                Data = dailyMeals,
                Status = 200,
                Success = true
            };
        }
    }
}