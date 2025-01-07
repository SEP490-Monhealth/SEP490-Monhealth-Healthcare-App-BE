using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.MealFood.Commands.UpdateMealFood;
using Monhealth.Application.Features.MealFood.Commands.UpdateStatusMealFood;
using Monhealth.Application.Features.MealFood.Queries;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/meal")]
    [ApiController]
    public class MealFoodController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MealFoodController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{mealId:Guid}/foods")]
        public async Task<ActionResult<ResultModel>> GetMealFoodByMealId(Guid mealId)
        {
            var food = await _mediator.
            Send(new GetMealFoodByMealIdQuery { MealId = mealId });

            if (food == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Bữa ăn không tồn tại",
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

        [HttpPatch]
        [Route("foods/{mealFoodId:Guid}/quantity")]
        public async Task<ActionResult<ResultModel>> UpdateCategory(Guid mealFoodId, int quantity)
        {
            var command = new MealFoodCommand(mealFoodId, quantity);
            var result = await _mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật Số lượng thất bại",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật số lượng thành công",
                Success = true,
                Status = 204,
            });
        }

        [HttpPatch]
        [Route("{mealFoodId:Guid}/status")]
        public async Task<ActionResult<ResultModel>> ChangeStatus(Guid mealFoodId)
        {
            var mealFoods = await _mediator.
            Send(new ChangeStatusMealFoodQuery() { MealFoodId = mealFoodId });

            if (mealFoods == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Bữa ăn không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Cập nhật trạng thái thành công"
            });
        }
    }
}