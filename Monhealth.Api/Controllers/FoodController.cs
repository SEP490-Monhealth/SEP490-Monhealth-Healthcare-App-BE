using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Food.AddFood;
using Monhealth.Application.Features.Food.AddFoodUser;
using Monhealth.Application.Features.Food.ChangeStatus;
using Monhealth.Application.Features.Food.DeleteFood;
using Monhealth.Application.Features.Food.Queries.GetAllFoods;
using Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId;
using Monhealth.Application.Features.Food.Queries.GetFoodById;
using Monhealth.Application.Features.Food.Queries.GetRelatedFoods;
using Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForAdmin;
using Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForUser;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
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
        [SwaggerOperation(Summary = "Lấy danh sách thức ăn")]
        public async Task<ActionResult<ResultModel>> GetAllFoods(int page = 1, int limit = 10, string? category = null, string? search = null, bool? isPublic = null, bool? popular = null, bool? status = null)
        {
            var foods = await _mediator.Send(new GetFoodListQuery(page, limit, category, search, isPublic, popular, status));

            return new ResultModel
            {
                Data = foods,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("suggestions")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ResultModel>> GetAllFoodsAndFilterByFoodName(
                  [FromQuery] int page = 1,
                  [FromQuery] int limit = 10,
                  [FromQuery(Name = "search")] string? search = null,
                  [FromQuery(Name = "isPublic")] bool? isPublic = null,
                  [FromQuery(Name = "status")] bool? status = null)
        {
            var result = await _mediator.Send(new GetFoodAndFilterByFoodNameQuery(page, limit, search, status, isPublic));

            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet]
        [Route("user/{userId:Guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách thức ăn theo người dùng")]
        public async Task<ActionResult<ResultModel>> GetFoodsByUserId(Guid userId, int page = 1, int limit = 10)
        {
            var foods = await _mediator.Send(new GetFoodListByUserIdQuery(userId, page, limit));

            return new ResultModel
            {
                Data = foods,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet]
        [Route("{foodId:Guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin thức ăn")]
        public async Task<ActionResult<ResultModel>> GetFoodById(Guid foodId)
        {
            var food = await _mediator.
            Send(new GetFoodByIdQuery { FoodId = foodId });

            if (food == null)
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
                Data = food
            });
        }

        [HttpGet]
        [Route("{foodId:Guid}/related")]
        [SwaggerOperation(Summary = "Lấy danh sách thức ăn liên quan")]
        public async Task<ActionResult<ResultModel>> GetFoodsRelateByFoodId(Guid foodId, int page = 1, int limit = 10, string? search = null, bool? status = null)
        {
            var foods = await _mediator.Send(new GetRelatedFoodsQuery(foodId, page, limit, search, status));

            return new ResultModel
            {
                Data = foods,
                Status = 200,
                Success = true,
            };
        }

        // [HttpGet("categories")]
        // public async Task<ActionResult<ResultModel>> GetFoodByCategoryName([FromQuery] string categories)
        // {
        //     // Kiểm tra nếu không có giá trị categoryName
        //     if (string.IsNullOrEmpty(categories))
        //     {
        //         return BadRequest(new ResultModel
        //         {
        //             Success = false,
        //             Message = "Tên danh mục là bắt buộc",
        //             Status = (int)HttpStatusCode.BadRequest,
        //             Data = null
        //         });
        //     }

        //     // Tách chuỗi categoryName thành mảng
        //     var categoryNames = categories.Split(',').Select(c => c.Trim()).ToArray();

        //     // Gửi query qua Mediator
        //     var food = await _mediator.Send(new GetFoodByCategoryNameQuery { categoryNames = categoryNames });

        //     // Xử lý trường hợp không tìm thấy thức ăn
        //     if (food == null || !food.Any())
        //     {
        //         return NotFound(new ResultModel
        //         {
        //             Success = false,
        //             Message = "Thức ăn không tồn tại",
        //             Status = (int)HttpStatusCode.NotFound,
        //             Data = null
        //         });
        //     }

        //     // Trả về kết quả thành công
        //     return Ok(new ResultModel
        //     {
        //         Success = true,
        //         Status = (int)HttpStatusCode.OK,
        //         Message = "Lấy danh sách thức ăn thành công",
        //         Data = food
        //     });
        // }

        [HttpPost("public")]
        [ActionName("AddFoodAdmin")]
        [SwaggerOperation(Summary = "Tạo thức ăn cho admin")]
        public async Task<ActionResult<ResultModel>> AddFoodForAdmin([FromBody] AddFoodRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo thức ăn thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo thức ăn thất bại",
                Status = 400,
            });
        }

        [HttpPost]
        [ActionName("AddFoodUser")]
        [SwaggerOperation(Summary = "Tạo thức ăn cho người dùng")]
        public async Task<ActionResult<ResultModel>> AddFoodForUser([FromBody] AddFoodUserRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo thức ăn thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo thức ăn thất bại",
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
                    Message = "Cập nhật thức ăn không thành công",
                    Success = false,
                    Data = null
                });
            }

            return Ok(new ResultModel
            {
                Message = "Cập nhật thức ăn thành công",
                Success = true,
                Status = 201,
            });
        }

        [HttpPut]
        [Route("{foodId:Guid}/public")]
        public async Task<ActionResult<ResultModel>> UpdateFoodForUser(Guid foodId, [FromBody] UpdateFoodRequestUser request)
        {

            var command = new UpdateFoodRequestUserHandler(foodId, request);
            var result = await _mediator.Send(command);

            if (!result)
            {
                return BadRequest(new ResultModel
                {
                    Message = "Cập nhật thức ăn không thành công",
                    Success = false,
                });
            }

            return Ok(new ResultModel
            {
                Message = "Cập nhật thức ăn thành công",
                Success = true,
                Status = 201,
            });
        }

        [HttpDelete]
        [Route("{foodId:Guid}")]
        [SwaggerOperation(Summary = "Xóa thức ăn")]
        public async Task<ActionResult<ResultModel>> RemoveFood(Guid foodId)
        {
            var result = await _mediator.Send(new DeleteFoodRequest(foodId));

            if (!result)
            {
                // Trả về lỗi nếu xóa không thành công
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Xóa thức ăn không thành công",
                    Status = (int)HttpStatusCode.NotFound,
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa thức ăn thành công",
                Status = 204,
            });
        }

        [HttpPatch]
        [Route("{foodId:Guid}/status")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái thức ăn")]
        public async Task<ActionResult<ResultModel>> ChangeStatus(Guid foodId)
        {
            var foods = await _mediator.
            Send(new ChangeStatusByFoodIdQuery() { FoodId = foodId });

            if (foods == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Thức ăn không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
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