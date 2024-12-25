using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Food.AddFood;
using Monhealth.Application.Features.Food.AddFoodUser;
using Monhealth.Application.Features.Food.DeleteFood;
using Monhealth.Application.Features.Food.Queries.GetAllFoods;
using Monhealth.Application.Features.Food.Queries.GetAllFoodsByFoodType;
using Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId;
using Monhealth.Application.Features.Food.Queries.GetFoodById;
using Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForAdmin;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/foods")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FoodController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllFoods(int page = 1, int limit = 10, string? search = null, string? category = null, bool? status = null)
        {
            var foods = await _mediator.Send(new GetFoodListQuery(page, limit, search, category, status));

            return new ResultModel
            {
                Data = foods,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet]
        [Route("{foodType}")]
        public async Task<ActionResult<ResultModel>> GetFoodsByFoodType(string foodType)
        {
            var foods = await _mediator.
            Send(new GetFoodDetailByFoodTypeQuery() { foodType = foodType });

            if (foods == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Món ăn không tồn tại.",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = foods
            });
        }
        [HttpGet]
        [Route("user/{userId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetFoodsByUserId(Guid userId)
        {
            var foods = await _mediator.
            Send(new GetFoodListByUserIdQuery() { UserId = userId });

            if (foods == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Món ăn không tồn tại.",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = foods
            });
        }

        [HttpGet]
        [Route("{foodId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetFoodById(Guid foodId)
        {
            var food = await _mediator.
            Send(new GetFoodByIdQuery { FoodId = foodId });

            if (food == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Món ăn không tồn tại.",
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

        [HttpPost("public")]
        [ActionName("AddFoodAdmin")]
        public async Task<ActionResult<ResultModel>> AddFoodForAdmin([FromBody] AddFoodRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo món ăn thành công.",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo món ăn thất bại.",
                Status = 400,
            });
        }

        [HttpPost]
        [ActionName("AddFoodUser")]
        public async Task<ActionResult<ResultModel>> AddFoodForUser([FromBody] AddFoodUserRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo món ăn thành công.",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo món ăn thất bại.",
                Status = 400,
            });
        }

        [HttpPut]
        [Route("{foodId:Guid}")]
        public async Task<ActionResult<ResultModel>> UpdateFood(Guid foodId, [FromBody] UpdateFoodRequestAdmin request)
        {

            var command = new UpdateFoodRequestAdminHandler(foodId, request);
            var result = await _mediator.Send(command);

            if (!result)
            {
                return BadRequest(new ResultModel
                {
                    Message = "Cập nhật món ăn không thành công.",
                    Success = false,
                    Data = null
                });
            }

            return Ok(new ResultModel
            {
                Message = "Cập nhật món ăn thành công.",
                Success = true,
                Status = 204,
            });
        }

        [HttpDelete]
        [Route("{foodId:Guid}")]
        public async Task<ActionResult<ResultModel>> RemoveFood(Guid foodId)
        {
            var result = await _mediator.Send(new DeleteFoodRequest(foodId));

            if (!result)
            {
                // Trả về lỗi nếu xóa không thành công
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Xóa món ăn không thành công.",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa món ăn thành công.",
                Status = 204,
                Data = null
            });
        }
    }
}