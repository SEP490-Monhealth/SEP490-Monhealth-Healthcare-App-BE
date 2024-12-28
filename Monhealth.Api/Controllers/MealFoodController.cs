
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Meal.Queries.GetAllMeals;
using Monhealth.Application.Features.MealFood.Commands.UpdateMealFood;
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
    }
}