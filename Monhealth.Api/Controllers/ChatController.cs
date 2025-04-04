﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Monhealth.Application;
using Monhealth.Application.Features.Chat.Commands.CreateChat;
using Monhealth.Application.Features.Chat.Queries.GetUserChatByUserId;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/chats")]
    [ApiController]
    public class ChatController(IMediator mediator, IHubContext<SignalRHub> _hubContext) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateChat([FromBody] CreateChatCommand command)
        {
            var chatId = await mediator.Send(command);
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Tạo cuộc trò chuyện thành công",
                Status = 201,
            });
        }

        [HttpPost("mon-ai")]
        public async Task<ActionResult<ResultModel>> GenerateContent([FromBody] GenerateRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Query) || request.UserId == Guid.Empty)
                return BadRequest("Thiếu thông tin người dùng hoặc câu hỏi.");

            var query = new ChatBotAiListQuery(request.UserId, request.Query);

            var (chatBotAi, aiResult) = await mediator.Send(query);

            var message = new
            {
                messageId = Guid.NewGuid().ToString(),
                sender = "MonAI",
                content = aiResult,
            };

            await _hubContext.Clients.All.SendAsync("ReceiveMessage", message);

            return Ok(new ResultModel
            {
                Success = true,
                Message = "Trò chuyện với AI thành công",
                Data = aiResult,
                // rawData = chatBotAi // optional: trả về thêm nếu cần debug
            });
        }

        [HttpGet("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetAllChat([FromRoute] Guid userId, int page = 1, int limit = 10)
        {
            var chats = await mediator.Send(new GetUserChatQuery { Page = page, Limit = limit, UserId = userId });
            return new ResultModel
            {
                Data = chats,
                Status = 200,
                Success = true,
            };
        }


    }
}
