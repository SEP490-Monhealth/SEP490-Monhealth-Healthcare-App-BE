using System.Text;
using System.Text.Json;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;

namespace Monhealth.Api.Controllers
{
    public class GenerateRequest
    {
        public Guid UserId { get; set; }
        public string Query { get; set; }
    }

    [ApiController]
    [Route("api/ai-health")]
    public class AiController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly IMediator _mediator;

        public AiController(IHttpClientFactory httpClientFactory, IConfiguration configuration, IMediator mediator)
        {
            _httpClient = httpClientFactory.CreateClient();
            _apiKey = configuration["Gemini:ApiKey"];
            _mediator = mediator;
        }

        [HttpPost("generate-plan")]
        public async Task<IActionResult> GenerateHealthPlan([FromBody] GenerateRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Query) || request.UserId == Guid.Empty)
                return BadRequest("Vui lòng cung cấp query và userId hợp lệ.");

            // 1. Lấy dữ liệu người dùng từ handler
            var (chatBotData, _) = await _mediator.Send(new ChatBotAiListQuery { UserId = request.UserId });

            // 2. Gộp query + dữ liệu người dùng
            var fullPrompt = new
            {
                query = request.Query,
                userData = chatBotData
            };

            var fullPromptJson = JsonSerializer.Serialize(fullPrompt, new JsonSerializerOptions { WriteIndented = false });

            // 3. Gửi tới Gemini
            var url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-pro:generateContent?key={_apiKey}";

            var body = new
            {
                contents = new[]
                {
                    new {
                        parts = new[] { new { text = fullPromptJson } }
                    }
                }
            };

            var jsonBody = JsonSerializer.Serialize(body);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);
            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                return StatusCode((int)response.StatusCode, responseString);

            using var doc = JsonDocument.Parse(responseString);
            var root = doc.RootElement;

            var text = root
                .GetProperty("candidates")[0]
                .GetProperty("content")
                .GetProperty("parts")[0]
                .GetProperty("text")
                .GetString();

            // Nếu Gemini phản hồi JSON dạng MealPlan - WorkoutRoutine - Summary, ta parse lại
            var structuredResult = JsonSerializer.Deserialize<JsonElement>(text); // Hoặc define một model mạnh kiểu `ChatBotAiResult`

            return Ok(structuredResult);
        }
    }
}
