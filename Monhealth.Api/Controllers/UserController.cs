using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.User.Commands.ChangeStatus;
using Monhealth.Application.Features.User.Commands.CreateUser;
using Monhealth.Application.Features.User.Commands.Delete;
using Monhealth.Application.Features.User.Commands.UpdateAvatarForUser;
using Monhealth.Application.Features.User.Commands.UpdateUser;
using Monhealth.Application.Features.User.Queries.GetAllUser;
using Monhealth.Application.Features.User.Queries.GetUserDetail;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
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
        [SwaggerOperation(Summary = "Done")]
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
        [HttpGet]
        [Route("{userId:guid}/chatbot")]
        public async Task<ActionResult<ResultModel>> ChatBot(Guid userId)
        {
            var (chatBotAi, characterCount) = await _mediator.Send(new ChatBotAiListQuery { UserId = userId });

            return new ResultModel
            {
                Data = new
                {
                    ChatBot = chatBotAi,
                    CharacterCount = characterCount // Thêm số ký tự vào response
                },
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
                    Message = "Tạo người dùng thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo người dùng thất bại",
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
                Message = "Cập nhập người dùng thành công",
                Status = 200,
                Success = true
            };
        }

        [HttpPut("{userId}/avatar")]
        public async Task<ActionResult<ResultModel>> UpdateUserAvatar(Guid userId, [FromBody] UpdateAvatarRequest request)
        {
            var command = new UpdateAvatarCommand(userId, request);
            var result = await _mediator.Send(command);
            return new ResultModel
            {
                Message = "Cập nhập avatar thành công",
                Status = 200,
                Success = true
            };
        }

        [HttpDelete("{userId}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid userId)
        {
            var command = await _mediator.Send(new RemoveUserCommand(userId));
            return new ResultModel
            {
                Message = "Xóa người dùng thành công",
                Status = 204,
                Success = true
            };
        }

        [HttpPatch]
        [Route("{userId}/status")]
        public async Task<ActionResult<ResultModel>> ChangeStatus(Guid userId)
        {
            var foods = await _mediator.
            Send(new ChangeStatusUserCommand() { UserId = userId });

            if (foods == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Người dùng không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Cập nhật trạng thái thành công"
            });
        }
    }
}
