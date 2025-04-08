using MediatR;
using Monhealth.Application.Features.ScanImageByAi.DTO;
using Monhealth.Application.Features.ScanImageByAi.Prompt; // Đảm bảo đã import namespace này
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

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
            private readonly ILogger<GeminiQueryHandler> _logger;

            public GeminiQueryHandler(IConfiguration configuration, HttpClient httpClient, ILogger<GeminiQueryHandler> logger)
            {
                _geminiApiKey = configuration["Gemini:ApiKey"];
                _httpClient = httpClient;
                _logger = logger;
            }

            public async Task<ScanImageResponseDTO> Handle(ScanImageQuery request, CancellationToken cancellationToken)
            {
                // Gọi prompt đầu tiên sử dụng BuildFullPrompt
                var prompt = GeminiPromptScanner.BuildFullPrompt();
                byte[] image;
                using (var memoryStream = new MemoryStream())
                {
                    await request.SourceStream.CopyToAsync(memoryStream, cancellationToken);
                    image = memoryStream.ToArray();
                }

                // Log kích thước của ảnh (số byte)
                _logger.LogInformation("Input image byte length: {Length}", image.Length);

                // Gọi API với prompt đầu tiên
                var result = await CallGeminiApi(prompt, image, cancellationToken);
                _logger.LogInformation("Response from Gemini API (first prompt): {@Response}", result);

                if (result.IsImage)
                {
                    return result;
                }
                else
                {
                    // Nếu không, sử dụng prompt thứ 2 (BuildPrompt2) để yêu cầu phản hồi khác
                    var prompt2 = GeminiPromptScanner.BuildPrompt2();
                    result = await CallGeminiApi(prompt2, image, cancellationToken);
                    _logger.LogInformation("Response from Gemini API (second prompt): {@Response}", result);
                    return result;
                }
            }

            // Hàm tách JSON thuần ra khỏi markdown (nếu có)
            private string ExtractJsonFromMarkdown(string input)
            {
                if (input.StartsWith("```json"))
                {
                    // Dùng Regex để bắt nội dung giữa ```json và ```
                    var regex = new Regex(@"```json\s*(?<json>.*?)\s*```", RegexOptions.Singleline);
                    var match = regex.Match(input);
                    if (match.Success)
                    {
                        return match.Groups["json"].Value;
                    }
                }
                // Nếu không có markdown hoặc không match, trả về input ban đầu
                return input;
            }

            // Phương thức helper để gọi Gemini API với một prompt nhất định
            private async Task<ScanImageResponseDTO> CallGeminiApi(string prompt, byte[] images, CancellationToken cancellationToken)
            {
                // Chuyển đổi ảnh sang Base64 string
                var base64Image = Convert.ToBase64String(images);
                // Log chuỗi Base64 (chỉ log 100 ký tự đầu để tránh log quá dài)
                _logger.LogInformation("Base64 Image Data (first 100 characters): {Base64}",
                    base64Image.Substring(0, Math.Min(100, base64Image.Length)));

                // Cập nhật URL theo model của Gemini được cấp quyền (ví dụ: gemini-pro)
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
                                new
                                {
                                    inline_data = new
                                    {
                                        mime_type = "image/jpeg",
                                        data = base64Image
                                    }
                                }
                            }
                        }
                    }
                };

                var jsonPayload = JsonSerializer.Serialize(payload);
                // Log JSON payload sẽ gửi đi
                _logger.LogInformation("JSON Payload: {JsonPayload}", jsonPayload);

                using var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                try
                {
                    // Gọi Gemini API
                    var response = await _httpClient.PostAsync(url, content, cancellationToken);
                    var rawResponseContent = await response.Content.ReadAsStringAsync(cancellationToken);
                    
                    // Log raw response content
                    _logger.LogInformation("Raw Response Content: {ResponseContent}", rawResponseContent);

                    if (!response.IsSuccessStatusCode)
                    {
                        _logger.LogError("Gemini API error: StatusCode {StatusCode}, Content: {ErrorContent}",
                            response.StatusCode, rawResponseContent);
                        throw new Exception($"Gemini API error: {response.StatusCode} - {rawResponseContent}");
                    }

                    // --- Bắt đầu xử lý response ---
                    // Vì response chứa nhiều thông tin, ta cần lấy candidate đầu tiên chứa nội dung markdown
                    string candidateMarkdown = null;
                    try
                    {
                        using var document = JsonDocument.Parse(rawResponseContent);
                        if (document.RootElement.TryGetProperty("candidates", out JsonElement candidatesElement) &&
                            candidatesElement.GetArrayLength() > 0)
                        {
                            var candidate = candidatesElement[0];
                            if (candidate.TryGetProperty("content", out JsonElement contentElement) &&
                                contentElement.TryGetProperty("parts", out JsonElement partsElement) &&
                                partsElement.GetArrayLength() > 0)
                            {
                                candidateMarkdown = partsElement[0].GetProperty("text").GetString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Lỗi khi parse raw response content");
                    }

                    // Nếu đã lấy được markdown từ candidate, xử lý để tách JSON thuần
                    string jsonResponse;
                    if (!string.IsNullOrEmpty(candidateMarkdown))
                    {
                        _logger.LogInformation("Markdown text extracted: {MarkdownText}", candidateMarkdown);
                        jsonResponse = ExtractJsonFromMarkdown(candidateMarkdown);
                        _logger.LogInformation("Extracted JSON Response: {JsonResponse}", jsonResponse);
                    }
                    else
                    {
                        // Nếu không lấy được candidate, cố gắng dùng toàn bộ raw response
                        jsonResponse = rawResponseContent;
                    }

                    // Deserialize kết quả trả về thành DTO, lưu ý cấu hình case-insensitive
                    var result = JsonSerializer.Deserialize<ScanImageResponseDTO>(jsonResponse, new JsonSerializerOptions
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
                    _logger.LogError(ex, "Lỗi khi gọi Gemini API");
                    throw new Exception("Lỗi khi gọi Gemini API: " + ex.Message);
                }
            }
        }
    }
}
