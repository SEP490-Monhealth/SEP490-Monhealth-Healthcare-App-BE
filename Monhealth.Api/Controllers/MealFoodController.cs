using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.MealFood.Commands.UpdateMealFood;
using Monhealth.Application.Features.MealFood.Commands.UpdateStatusMealFood;
using Monhealth.Application.Features.MealFood.Queries;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
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
        [SwaggerOperation(Summary = "Lấy danh sách thức ăn theo ID bữa ăn")]
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

        // [HttpGet]
        // [Route("{mealId:Guid}/meal-foods")]
        // public async Task<ActionResult<ResultModel>> GetAllMealFoodByMealId(Guid mealId)
        // {
        //     var food = await _mediator.
        //     Send(new GetALLMealFoodByMealQuery { MealId = mealId });

        //     if (food == null)
        //     {
        //         return NotFound(new ResultModel
        //         {
        //             Success = false,
        //             Message = "Bữa ăn không tồn tại",
        //             Status = (int)HttpStatusCode.NotFound,
        //             Data = null
        //         });
        //     }
        //     return Ok(new ResultModel
        //     {
        //         Success = true,
        //         Status = 200,
        //         Data = food
        //     });
        // }

        [HttpPatch]
        [Route("food/{mealFoodId:Guid}/quantity")]
        [SwaggerOperation(Summary = "Cập nhật số lượng thức ăn trong bữa ăn")]
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
        [Route("food/{mealFoodId:Guid}/completed")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái thức ăn trong bữa ăn")]
        public async Task<ActionResult<ResultModel>> ChangeStatus(Guid mealFoodId)
        {
            var mealFoods = await _mediator.
            Send(new ChangeStatusMealFoodQuery() { MealFoodId = mealFoodId });

            if (mealFoods == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Thức ăn không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Cập nhật trạng thái thức ăn thành công"
            });
        }
    }
}