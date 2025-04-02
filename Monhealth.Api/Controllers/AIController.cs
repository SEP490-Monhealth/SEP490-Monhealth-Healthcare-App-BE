using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using MediatR;
using Monhealth.Application;

namespace Monhealth.Api.Controllers
{
    public class GenerateRequest
    {
        public Guid UserId { get; set; }
        public string Query { get; set; }
    }

    [ApiController]
    [Route("api/gemini-chat")]
    public class AiController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AiController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // [HttpPost("generate")]
        // public async Task<IActionResult> GenerateContent([FromBody] GenerateRequest request)
        // {
        //     if (string.IsNullOrWhiteSpace(request.Query) || request.UserId == Guid.Empty)
        //         return BadRequest("Thiếu thông tin người dùng hoặc câu hỏi.");

        //     var query = new ChatBotAiListQuery(request.UserId, request.Query);

        //     var (chatBotAi, aiResult) = await _mediator.Send(query);

        //     return Ok(new
        //     {
        //         success = true,
        //         result = aiResult,
        //         // rawData = chatBotAi // optional: trả về thêm nếu cần debug
        //     });
        // }
    }
}
