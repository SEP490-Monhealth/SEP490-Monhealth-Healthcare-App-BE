using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.UserFood.Commands;
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
                Message = "Tạo thành công",
                Success = true,
                Status = (int)HttpStatusCode.OK,
            };
        }
    }
}
