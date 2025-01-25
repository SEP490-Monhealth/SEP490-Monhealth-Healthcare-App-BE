using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.UserFood.Commands;
using Monhealth.Application.Features.UserFood.Commands.Update;
using Monhealth.Application.Features.UserFood.Queries;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/user-foods")]
    [ApiController]
    public class UserFoodController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll()
        {
            var result = await mediator.Send(new UserFoodQuery());
            return new ResultModel
            {
                Data = result,
                Success = true,
                Status = (int)HttpStatusCode.OK,
            };
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateUserFood(CreateUserFoodDto request)
        {
            var result = await mediator.Send(new CreateUserFoodCommand(request));

            return new ResultModel
            {
                Message = "Tạo thức ăn người dùng thành công",
                Success = true,
                Status = (int)HttpStatusCode.OK,
            };
        }

        [HttpPut]
        [Route("{userId:Guid}")]
        public async Task<ActionResult<ResultModel>> Update(Guid userId, [FromBody] UpdateUserFoodRequest request)
        {

            var command = new UpdateUserFoodCommand(userId, request);
            var result = await mediator.Send(command);

            if (result != Unit.Value)
            {
                return BadRequest(new ResultModel
                {
                    Message = "Cập nhật món ăn cho người dùng không thành công",
                    Success = false,
                    Data = null
                });
            }

            return Ok(new ResultModel
            {
                Message = "Cập nhật món ăn cho người dùng thành công",
                Success = true,
                Status = 204,
            });
        }
    }
}
