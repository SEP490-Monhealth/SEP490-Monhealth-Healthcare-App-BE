using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Meal.Commands.CreateMeal;
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
        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddMeal([FromBody] CreateMealDTO request)
        {
            var command = new CreateMealCommand(request);
            var result = await _mediator.Send(command);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo bữa ăn thành công.",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo bữa ăn thất bại.",
                Status = 400,
            });
        }
    }
}