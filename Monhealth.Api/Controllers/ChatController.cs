using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Chat.Commands.CreateChat;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/chats")]
    [ApiController]
    public class ChatController(IMediator mediator) : ControllerBase
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
        [HttpPost("generate-AI")]
        public async Task<ActionResult<ResultModel>> GenerateContent([FromBody] GenerateRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Query) || request.UserId == Guid.Empty)
                return BadRequest("Thiếu thông tin người dùng hoặc câu hỏi.");

            var query = new ChatBotAiListQuery(request.UserId, request.Query);

            var (chatBotAi, aiResult) = await mediator.Send(query);

            return Ok(new ResultModel
            {
                Success = true,
                Message = " trò chuyện với AI thành công",
                Data = aiResult,
                // rawData = chatBotAi // optional: trả về thêm nếu cần debug
            });
        }
    }
}
