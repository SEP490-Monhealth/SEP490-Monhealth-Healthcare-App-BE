using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.UserFood.Commands;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/userFoods")]
    [ApiController]
    public class UserFoodController(IMediator mediator) : ControllerBase
    {
        [HttpPost("{userId:guid}")]
        public async Task<ActionResult<ResultModel>> CreateUserFood([FromRoute] Guid userId, [FromBody] CreateUserFoodDto userFoodDto)
        {
            var result = await mediator.Send(new CreateUserFoodCommand(userId, userFoodDto));

            return new ResultModel
            {
                Message = "Tạo thành công",
                Success = true,
                Status = (int)HttpStatusCode.OK,
            };
        }
    }
}
