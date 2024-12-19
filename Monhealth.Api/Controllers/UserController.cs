using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.User.Commands.CreateUser;
using Monhealth.Application.Features.User.Commands.UpdateUser;
using Monhealth.Application.Features.User.Queries.GetAllUser;
using Monhealth.Application.Features.User.Queries.GetUserDetail;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllUser(int page = 1, int limit = 10, string? search = null, string? role = null, bool? status = null)
        {
            var result = await _mediator.Send(new GetAllUserQuery { Page = page, Limit = limit, Search = search, Role = role, Status = status });

            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetUserById(Guid userId)
        {
            var result = await _mediator.Send(new GetUserDetailQuery { Id = userId });
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateUser([FromBody] CreateUserCommand request)
        {
            var result = await _mediator.Send(request);
            if (result == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo người dùng thành công.",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo người dùng thất bại.",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut("{userId}")]
        public async Task<ActionResult<ResultModel>> UpdateUser(Guid userId, [FromBody] UpdateUserRequest request)
        {
            var command = new UpdateUserCommand(userId, request);
            var result = await _mediator.Send(command);
            return new ResultModel
            {
                Message = "cập nhập người dùng thành công.",
                Status = 200,
                Success = true
            };
        }
    }
}
