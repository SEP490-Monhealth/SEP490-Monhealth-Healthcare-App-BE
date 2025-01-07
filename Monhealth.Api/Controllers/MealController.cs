using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Meal.Commands.CreateMeal;
using Monhealth.Application.Features.Meal.Commands.DeleteMeal;
using Monhealth.Application.Features.Meal.Queries.GetAllMeals;
using Monhealth.Application.Features.Meal.Queries.GetMealById;
using Monhealth.Application.Features.Meal.Queries.GetMealByUser;
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

        [HttpGet]
        [Route("{mealId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetMealDetail(Guid mealId)
        {
            var meal = await _mediator.
            Send(new GetMealDetailQuery() { MealId = mealId });

            if (meal == null)
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
                Data = meal
            });
        }
        [HttpGet]
        [Route("user/{userId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetMealByUser(Guid userId)
        {
            var meal = await _mediator.
            Send(new GetMealByUserQuery() { UserId = userId });

            if (meal == null)
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
                Data = meal
            });
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
                    Message = "Tạo bữa ăn thành công",
                    Status = 201,
                    Data = new { mealId = result } // Trả về mealId
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo bữa ăn thất bại",
                Status = 400,
            });
        }

        [HttpDelete]
        [Route("{mealId:Guid}")]
        public async Task<ActionResult<ResultModel>> RemoveMeal(Guid mealId)
        {
            var result = await _mediator.Send(new DeleteMealCommand(mealId));

            if (!result)
            {
                // Trả về lỗi nếu xóa không thành công
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Xóa bữa ăn không thành công",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa bữa ăn thành công",
                Status = 204,
                Data = null
            });
        }
    }
}