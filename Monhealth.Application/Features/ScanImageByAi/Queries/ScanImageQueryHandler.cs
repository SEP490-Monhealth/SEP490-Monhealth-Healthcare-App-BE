using MediatR;
using Monhealth.Application.Features.ScanImageByAi.DTO;
using Monhealth.Application.Features.ScanImageByAi.Prompt; // Đảm bảo đã import namespace này
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Text.Json;
using DotnetGeminiSDK.Client.Interfaces;
using DotnetGeminiSDK.Model.Response;

namespace Monhealth.Application
{
    // Sử dụng kiểu trả về là ScanImageResponseDTO (đã được cấu trúc theo JSON của prompt)
    public class ScanImageQuery : IRequest<ScanImageResponseDTO>
    {
        public Stream SourceStream { get; set; }
        public ScanImageQuery(Stream sourceStream)
        {
            SourceStream = sourceStream;
        }

        public class GeminiQueryHandler : IRequestHandler<ScanImageQuery, ScanImageResponseDTO>
        {
            private readonly string _geminiApiKey;
            private readonly HttpClient _httpClient;

            public GeminiQueryHandler(IConfiguration configuration, HttpClient httpClient)
            {
                _geminiApiKey = configuration["Gemini:ApiKey"];
                _httpClient = httpClient;
            }

            public async Task<ScanImageResponseDTO> Handle(ScanImageQuery request, CancellationToken cancellationToken)
            {
                // Gọi prompt đầu tiên sử dụng BuildFullPrompt
                var prompt = GeminiPromptScanner.BuildFullPrompt();
                byte[] image = [];
                using (var memoryStream = new MemoryStream())
                {
                    request.SourceStream.CopyTo(memoryStream);
                    image = memoryStream.ToArray();
                }
                var result = await CallGeminiApi(prompt, image, cancellationToken);
                // Kiểm tra trường IsImage:
                // Nếu hình ảnh xác định là món ăn, trả về kết quả ngay
                if (result.IsImage)
                {
                    return result;
                }
                else
                {
                    // Nếu không, sử dụng prompt thứ 2 (BuildPrompt2) để yêu cầu phản hồi khác
                    var prompt2 = GeminiPromptScanner.BuildPrompt2();
                    result = await CallGeminiApi(prompt2, image, cancellationToken);
                    return result;
                }
            }

            // Phương thức helper để gọi Gemini API với một prompt nhất định
            private async Task<ScanImageResponseDTO> CallGeminiApi(string prompt, byte[] images, CancellationToken cancellationToken)
            {
                // Cập nhật URL theo model của Gemini bạn được cấp quyền (ví dụ: gemini-pro)
                var url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={_geminiApiKey}";

                // Chuẩn bị payload theo định dạng yêu cầu của Gemini API
                var payload = new
                {
                    contents = new[]
                    {
                    new
                    {
                        parts = new object[]
                        {
                            new { text = prompt },
                            new{
                                inline_data = new {
                                    mime_type = "image/jpeg",
                                    data = images // Chuyển đổi byte[] thành Base64 string
                                }
                            }
                        }
                    }
                }
                };

                var jsonPayload = JsonSerializer.Serialize(payload);
                using var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                try
                {
                    // Gọi Gemini API
                    var response = await _httpClient.PostAsync(url, content, cancellationToken);

                    if (!response.IsSuccessStatusCode)
                    {
                        var errorContent = await response.Content.ReadAsStringAsync(cancellationToken);
                        throw new Exception($"Gemini API error: {response.StatusCode} - {errorContent}");
                    }

                    var geminiResponseContent = await response.Content.ReadAsStringAsync(cancellationToken);

                    // Deserialize kết quả trả về thành DTO, lưu ý cấu hình case-insensitive
                    var result = JsonSerializer.Deserialize<ScanImageResponseDTO>(geminiResponseContent, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (result == null)
                    {
                        throw new Exception("Unable to deserialize Gemini API response.");
                    }

                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi gọi Gemini API: " + ex.Message);
                }
            }
        }
    }
}
