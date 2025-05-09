﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.User;
using Monhealth.Application.Features.User.Commands.ChangeStatus;
using Monhealth.Application.Features.User.Commands.CreateUser;
using Monhealth.Application.Features.User.Commands.UpdateAvatarForUser;
using Monhealth.Application.Features.User.Commands.UpdateUser;
using Monhealth.Application.Features.User.Queries.GetAllUser;
using Monhealth.Application.Features.User.Queries.GetUserDetail;
using Monhealth.Application.Models;
using Monhealth.Identity.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
    [Route("api/v1/users")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly UserManager<AppUser> _userManager;

        public UserController(IMediator mediator, UserManager<AppUser> userManager)
        {
            _mediator = mediator;
            _userManager = userManager;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách người dùng")]
        public async Task<ActionResult<ResultModel>> GetAllUser(int page = 1, int limit = 10, string? search = null, string? role = null,
            string? sort = null, string? order = null, bool? status = null, bool admin = false)
        {
            var result = await _mediator.Send(new GetAllUserQuery { Page = page, Limit = limit, Search = search, Role = role, Sort = sort, Order = order, Status = status, Admin = admin });

            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("{userId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin người dùng")]
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

        // [HttpGet]
        // [Route("{userId:guid}/chatbot")]
        // public async Task<ActionResult<ResultModel>> ChatBot(Guid userId , string query)
        // {
        //     var (chatBotAi, characterCount) = await _mediator.Send(new ChatBotAiListQuery { UserId = userId });

        //     return new ResultModel
        //     {
        //         Data = new
        //         {
        //             ChatBot = chatBotAi,
        //             CharacterCount = characterCount // Thêm số ký tự vào response
        //         },
        //         Status = 200,
        //         Success = true
        //     };
        // }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo người dùng")]
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
        [SwaggerOperation(Summary = "Cập nhật thông tin người dùng")]
        public async Task<ActionResult<ResultModel>> UpdateUser(Guid userId, [FromBody] UpdateUserRequest request)
        {
            var command = new UpdateUserCommand(userId, request);
            var result = await _mediator.Send(command);
            return new ResultModel
            {
                Message = "Cập nhập thông tin người dùng thành công",
                Status = 200,
                Success = true
            };
        }

        [HttpPut("{userId}/avatar")]
        [SwaggerOperation(Summary = "Cập nhật hình đại diện người dùng")]
        public async Task<ActionResult<ResultModel>> UpdateUserAvatar(Guid userId, [FromBody] UpdateAvatarRequest request)
        {
            var command = new UpdateAvatarCommand(userId, request);
            var result = await _mediator.Send(command);
            return new ResultModel
            {
                Message = "Cập nhập hình đại diện thành công",
                Status = 200,
                Success = true
            };
        }

        [HttpPut("{userId:guid}/password")]
        [SwaggerOperation(Summary = "Cập nhật mật khẩu cho người dùng")]
        public async Task<ActionResult<ResultModel>> ChangePassword(Guid userId, [FromBody] ChangePasswordRequest request)
        {
            if (string.Equals(request.OldPassword, request.NewPassword, StringComparison.OrdinalIgnoreCase))
            {
                return BadRequest(new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Mật khẩu mới không được trùng với mật khẩu cũ"
                });
            }

            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy người dùng"
                });
            }

            var result = await _userManager.ChangePasswordAsync(user, request.OldPassword, request.NewPassword);
            if (!result.Succeeded)
            {
                var errors = string.Join("<br>", result.Errors.Select(e => e.Description));
                return BadRequest(new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = errors
                });
            }

            return Ok(new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật mật khẩu thành công"
            });
        }

        // [HttpDelete("{userId}")]
        // [SwaggerOperation(Summary = "Xóa người dùng")]
        // public async Task<ActionResult<ResultModel>> Delete(Guid userId)
        // {
        //     var command = await _mediator.Send(new RemoveUserCommand(userId));
        //     return new ResultModel
        //     {
        //         Message = "Xóa người dùng thành công",
        //         Status = 204,
        //         Success = true
        //     };
        // }

        [HttpPatch]
        [Route("{userId}/status")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái người dùng")]
        public async Task<ActionResult<ResultModel>> ChangeStatus(Guid userId)
        {
            var foods = await _mediator.
            Send(new ChangeStatusUserCommand() { UserId = userId });

            if (foods == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Không tìm thấy người dùng",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Cập nhật trạng thái người dùng thành công"
            });
        }
    }
}
