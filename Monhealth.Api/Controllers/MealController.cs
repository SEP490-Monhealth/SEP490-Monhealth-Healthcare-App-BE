using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Meal.Commands.CreateMeal;
using Monhealth.Application.Features.Meal.Queries.GetMealById;
using Monhealth.Application.Features.Meal.Queries.GetMealByUser;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
    [Route("api/v1/meals")]
    [ApiController]
    public class MealController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MealController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // [HttpGet]
        // public async Task<ActionResult<ResultModel>> GetAllCategories()
        // {
        //     var categories = await _mediator.Send(new GetMealListQuery());

        //     return new ResultModel
        //     {
        //         Data = categories,
        //         Status = 200,
        //         Success = true
        //     };
        // }

        [HttpGet]
        [Route("{mealId:Guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin bữa ăn theo ID")]
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
        [SwaggerOperation(Summary = "Lấy bữa ăn theo ID người dùng")]
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


        // [HttpGet]
        // [Route("user/{userId:Guid}/report")]
        // [SwaggerOperation(Summary = "Báo cáo Calories theo người dùng")]
        // public async Task<ActionResult<ResultModel>> GetReportMealByUser(Guid userId , DateTime date)
        // {
        //     var meal = await _mediator.
        //     Send(new GetReportMealByUserQuery() { UserId = userId , Date = date});

        //     if (meal == null)
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
        //         Data = meal
        //     });
        // }
        [HttpPost]
        [SwaggerOperation(Summary = "Tạo bữa ăn")]
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

        // [HttpPost]
        // [Route("{userId:guid}/meal-recommend")]
        // public async Task<ActionResult<ResultModel>> AddMealRecommend(Guid userId)
        // {
        //     var meal = await _mediator.
        //     Send(new CreateRecommendMealCommand() { UserId = userId });

        //     if (meal != null)
        //     {
        //         return Ok(new ResultModel
        //         {
        //             Success = true,
        //             Message = "Tạo bữa ăn thành công",
        //             Status = 201,
        //             Data = new { mealId = meal } // Trả về mealId
        //         });
        //     }

        //     return BadRequest(new ResultModel
        //     {
        //         Success = false,
        //         Message = "Tạo bữa ăn thất bại",
        //         Status = 400,
        //     });
        // }

        // [HttpDelete]
        // [Route("{mealId:Guid}")]
        // public async Task<ActionResult<ResultModel>> RemoveMeal(Guid mealId)
        // {
        //     var result = await _mediator.Send(new DeleteMealCommand(mealId));

        //     if (!result)
        //     {
        //         return NotFound(new ResultModel
        //         {
        //             Success = false,
        //             Message = "Xóa bữa ăn không thành công",
        //             Status = (int)HttpStatusCode.NotFound,
        //             Data = null
        //         });
        //     }
        //     return Ok(new ResultModel
        //     {
        //         Success = true,
        //         Message = "Xóa bữa ăn thành công",
        //         Status = 204,
        //         Data = null
        //     });
        // }
    }
}