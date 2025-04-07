using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Nutrition.AddNutrition;
using Monhealth.Application.Features.Nutrition.DeleteNutrition;
using Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition;
using Monhealth.Application.Features.Nutrition.Queries.GetAllNutritionByfoodId;
using Monhealth.Application.Features.Nutrition.Queries.GetNutritionDetail;
using Monhealth.Application.Features.Nutrition.UpdateNutrition;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/nutrition")]
    [ApiController]
    public class NutritionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public NutritionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // [HttpGet]
        // public async Task<ActionResult<ResultModel>> GetAllNutrition()
        // {
        //     var nutritionList = await _mediator.Send(new GetNutritionListQuery());

        //     return new ResultModel
        //     {
        //         Data = nutritionList,
        //         Status = 200,
        //         Success = true
        //     };
        // }

        // [HttpGet]
        // [Route("{nutritionId:Guid}")]
        // [SwaggerOperation(Summary = "Lấy thông tin dinh dưỡng theo ID")]
        // public async Task<ActionResult<ResultModel>> GetNutritionDetail(Guid nutritionId)
        // {
        //     var queries = await _mediator.
        //     Send(new GetNutritionDetailQuery() { NutritionId = nutritionId });

        //     if (queries == null)
        //     {
        //         return NotFound(new ResultModel
        //         {
        //             Success = false,
        //             Message = "Dinh dưỡng không tồn tại",
        //             Status = (int)HttpStatusCode.NotFound,
        //             Data = null
        //         });
        //     }
        //     return Ok(new ResultModel
        //     {
        //         Success = true,
        //         Status = 200,
        //         Data = queries
        //     });
        // }

        [HttpGet]
        [Route("food/{foodId:Guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách dinh dưỡng theo ID thực phẩm")]
        public async Task<ActionResult<ResultModel>> GetNutritionByFoodIdDetail(Guid foodId)
        {
            var queries = await _mediator.
            Send(new GetNutritionByFoodIdListQuery() { FoodId = foodId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Dinh dưỡng không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        // [HttpPost]
        // public async Task<ActionResult<ResultModel>> AddNutrition([FromBody] AddNutritionRequest request)
        // {
        //     var result = await _mediator.Send(request);
        //     if (result)
        //     {
        //         return Ok(new ResultModel
        //         {
        //             Success = true,
        //             Message = "Tạo dinh dưỡng thành công",
        //             Status = 201,
        //         });
        //     }

        //     return BadRequest(new ResultModel
        //     {
        //         Success = false,
        //         Message = "Tạo dinh dưỡng thất bại"
        //     });
        // }

        [HttpPut]
        [Route("{nutritionId:Guid}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin dinh dưỡng")]
        public async Task<ActionResult<ResultModel>> UpdateNutrition(Guid nutritionId, [FromBody] UpdateNutritionRequest request)
        {
            var command = new UpdateNutritionCommand(nutritionId, request);
            var result = await _mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật dinh dưỡng không thành công",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật dinh dưỡng thành công",
                Success = true,
                Status = 204,
            });
        }

        // [HttpDelete]
        // [Route("{nutritionId:Guid}")]
        // public async Task<ActionResult<ResultModel>> RemoveNutrition(Guid nutritionId)
        // {
        //     var result = await _mediator.Send(new DeleteNutritionRequest(nutritionId));

        //     if (!result)
        //     {
        //         // Trả về lỗi nếu xóa không thành công
        //         return NotFound(new ResultModel
        //         {
        //             Success = false,
        //             Message = "Xóa dinh dưỡng không thành công",
        //             Status = (int)HttpStatusCode.NotFound,
        //             Data = null
        //         });
        //     }

        //     // Trả về kết quả thành công
        //     return Ok(new ResultModel
        //     {
        //         Success = true,
        //         Message = "Xóa dinh dưỡng thành công",
        //         Status = 204,
        //         Data = null
        //     });
        // }
    }
}