using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.User.Queries.GetAllUser;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllUser(int page, int limit, string? search, string? role, bool? status)
        {
            var result = await _mediator.Send(new GetAllUserQuery { Page = page, Limit = limit, Search = search, Role = role, Status = status });

            return new ResultModel
            {
                Data = result,
                Message = "User retrieve successfully",
                Status = 200,
                Success = true
            };

        }
    }
}
