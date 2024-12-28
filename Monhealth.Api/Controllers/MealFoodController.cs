using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.MealFood.Commands.UpdateMealFood;
using Monhealth.Application.Features.MealFood.Queries;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/mealFoods")]
    [ApiController]
    public class MealFoodController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MealFoodController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPatch]
        [Route("{mealFoodId:Guid}/{quantity:int}")]
        public async Task<ActionResult<ResultModel>> UpdateCategory(Guid mealFoodId, int quantity)
        {
            var command = new MealFoodCommand(mealFoodId, quantity);
            var result = await _mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật Số lượng thất bại.",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật số lượng thành công.",
                Success = true,
                Status = 204,
            });
        }

        [HttpGet]
        [Route("{mealId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetMealFoodByMealId(Guid mealId)
        {
            var food = await _mediator.
            Send(new GetMealFoodByMealIdQuery { MealId = mealId });

            if (food == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Bữa ăn không tồn tại.",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = food
            });
        }
    }
}