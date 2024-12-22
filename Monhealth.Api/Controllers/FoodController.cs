using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Food.AddFood;
using Monhealth.Application.Features.Food.Queries.GetAllFoods;
using Monhealth.Application.Features.Food.Queries.GetAllFoodsByFoodType;
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
        public async Task<ActionResult<ResultModel>> GetAllFoods()
        {
            var foods = await _mediator.Send(new GetFoodListQuery());

            return new ResultModel
            {
                Data = foods,
                Status = 200,
                Success = true
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
                    Message = "thức ăn không tồn tại.",
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
        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddFood([FromBody] AddFoodRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo thức ăn thành công.",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo thức ăn thất bại."
            });
        }
    }
}