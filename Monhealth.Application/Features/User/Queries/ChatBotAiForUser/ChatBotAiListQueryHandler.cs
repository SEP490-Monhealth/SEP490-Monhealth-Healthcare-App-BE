using System.Text;
using System.Text.Json;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class ChatBotAiListQueryHandler : IRequestHandler<ChatBotAiListQuery, (ChatBotAi, HealthPlanResponseDto)>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IWorkoutRepository _workoutRepository;
        private readonly IUserRepository _userRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IMetricRepository _metricRepository;
        private readonly HttpClient _httpClient;
        private readonly string _geminiApiKey;
        private readonly ILogger<ChatBotAiListQueryHandler> _logger;
        private readonly IHubContext<SignalRHub> _hubContext; // Inject IHubContext

        public ChatBotAiListQueryHandler(
            IMetricRepository metricRepository,
            IFoodRepository foodRepository,
            IWorkoutRepository workoutRepository,
            IUserRepository userRepository,
            IGoalRepository goalRepository,
            HttpClient httpClient,
            IConfiguration configuration,
            ILogger<ChatBotAiListQueryHandler> logger,
            IHubContext<SignalRHub> hubContext)
        {
            _foodRepository = foodRepository;
            _workoutRepository = workoutRepository;
            _userRepository = userRepository;
            _goalRepository = goalRepository;
            _metricRepository = metricRepository;
            _httpClient = httpClient;
            _logger = logger;
            _geminiApiKey = configuration["Gemini:ApiKey"];
            _hubContext = hubContext;
        }
        public async Task<(ChatBotAi, HealthPlanResponseDto)> Handle(ChatBotAiListQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            if (user == null) throw new Exception("User not found.");

            var metrics = await _metricRepository.GetByUserIdAsync(request.UserId);
            if (metrics == null) throw new Exception("Metrics not found for the user.");

            var foods = await _foodRepository.GetFoodByUserHasNoAllergiesAsync(request.UserId) ?? new List<Food>();
            foods = foods.Where(f => f != null).ToList();

            var workouts = await _workoutRepository.GetAllAsync() ?? new List<Workout>();
            var goal = await _goalRepository.GetByUserIdAsync(request.UserId);

            var workoutNames = workouts
                .Where(w => !string.IsNullOrEmpty(w.WorkoutName))
                .Select(w => w.WorkoutName)
                .ToList();

            var foodDTOs = foods
                .Where(f => f != null && f.Nutrition != null)
                .GroupBy(f => new
                {
                    Calories = f.Nutrition?.Calories ?? 0,
                    Protein = f.Nutrition?.Protein ?? 0,
                    Carbs = f.Nutrition?.Carbs ?? 0,
                    Fat = f.Nutrition?.Fat ?? 0
                })
                .Select(g => new FoodDTO12
                {
                    FoodId = g.Select(f => f.FoodId).ToList(), //
                    FoodName = g.Where(f => !string.IsNullOrEmpty(f.FoodName)).Select(f => f.FoodName).ToList(),
                    Calories = g.Key.Calories,
                    Protein = g.Key.Protein,
                    Carbs = g.Key.Carbs,
                    Fat = g.Key.Fat
                })
                .ToList();

            var chatBotAi = new ChatBotAi
            {
                UserName = user.UserName ?? string.Empty,
                Metric = new MetricDTO12
                {
                    Height = metrics.Height,
                    Weight = metrics.Weight,
                    Bmi = metrics.Bmi,
                    Bmr = metrics.Bmr,
                    Tdee = metrics.Tdee,
                    Ibw = metrics.Ibw
                },
                Goal = new GoalDTO12
                {
                    CaloriesBurnedGoal = goal.CaloriesBurnedGoal,
                    CaloriesGoal = goal.CaloriesGoal,
                    CaloriesRatio = goal.CaloriesRatio,
                    CarbsGoal = goal.CarbsGoal,
                    FatGoal = goal.FatGoal,
                    FiberGoal = goal.FiberGoal,
                    ProteinGoal = goal.ProteinGoal,
                    SugarGoal = goal.SugarGoal,
                    WeightGoal = goal.WeightGoal,
                    WorkoutDurationGoal = goal.WorkoutDurationGoal
                },
                Foods = foodDTOs,
                Workouts = new WorkoutDTO12
                {
                    WorkoutName = workoutNames
                }
            };

            // Gọi API Gemini với dữ liệu và truy vấn
            string aiResultJson = await CallGeminiApi(chatBotAi, request.Query);

            // Deserialize JSON từ Gemini thành DTO
            var healthPlan = JsonSerializer.Deserialize<HealthPlanResponseDto>(aiResultJson, GetJsonSerializerOptions());


            if (healthPlan == null)
                throw new Exception("Không thể phân tích dữ liệu phản hồi từ Gemini API.");

            // Gửi kết quả đến client qua SignalR
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", aiResultJson); // Gửi tin nhắn tới tất cả client

            return (chatBotAi, healthPlan);
        }
        private JsonSerializerOptions GetJsonSerializerOptions()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = null // Giữ nguyên tên key tiếng Việt trong JSON
            };
            options.Converters.Add(new GuidConverter());  // Thêm GuidConverter vào
            return options;
        }
        private async Task<string> CallGeminiApi(ChatBotAi chatBotAi, string query)
        {
            var url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={_geminiApiKey}";

            // Step 1: Check if query is health-related
            string prompt2 = GeminiPromptBuilder.BuildPrompt2(query);
            var checkRequest = new
            {
                contents = new[]
                {
            new
            {
                parts = new[]
                {
                    new { text = prompt2 }
                }
            }
        }
            };

            var checkJson = JsonSerializer.Serialize(checkRequest);
            var checkContent = new StringContent(checkJson, Encoding.UTF8, "application/json");

            // Gửi dữ liệu với Chunked Transfer Encoding
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = checkContent
            };

            // Send the request with HttpCompletionOption.ResponseHeadersRead
            var checkResponse = await _httpClient.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            var checkResponseString = await checkResponse.Content.ReadAsStringAsync();

            _logger.LogInformation("Response from prompt2: {Response}", checkResponseString);

            if (!checkResponse.IsSuccessStatusCode)
                throw new Exception($"Gemini API check call failed: {checkResponseString}");

            var checkDoc = JsonDocument.Parse(checkResponseString);
            var checkText = checkDoc.RootElement
                .GetProperty("candidates")[0]
                .GetProperty("content")
                .GetProperty("parts")[0]
                .GetProperty("text")
                .GetString();

            var checkJsonContent = ExtractJsonFromMarkdown(checkText!);

            try
            {
                var checkResult = JsonSerializer.Deserialize<HealthPlanResponseDto>(checkJsonContent);

                if (checkResult == null)
                    throw new Exception("Không thể đọc phản hồi JSON từ Gemini (prompt2).");

                // Nếu không liên quan đến sức khỏe → return ngay luôn phản hồi đơn giản
                if (!checkResult.health_or_fitness)
                {
                    _logger.LogWarning("⚠️ Câu hỏi không liên quan đến sức khỏe/thể hình, trả luôn kết quả từ prompt2.");
                    return JsonSerializer.Serialize(checkResult, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        PropertyNamingPolicy = null
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"❌ Lỗi khi parse JSON từ AI (Prompt2): {ex.Message}\n\n== Extracted JSON ==\n{checkJsonContent}");
            }

            // Step 2: fullPrompt cho việc tạo kế hoạch
            var fullPrompt = GeminiPromptBuilder.BuildFullPrompt(chatBotAi);
            var requestBody = new
            {
                contents = new[]
                {
            new
            {
                parts = new[]
                {
                    new { text = fullPrompt }
                }
            }
        }
            };

            var jsonBody = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            // Create HttpRequestMessage
            var requestMessage1 = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = content
            };

            // Use SendAsync with HttpCompletionOption
            var response = await _httpClient.SendAsync(requestMessage1, HttpCompletionOption.ResponseHeadersRead);

            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Gemini API call failed: {responseString}");

            try
            {
                using var doc = JsonDocument.Parse(responseString);
                var rawText = doc.RootElement
                    .GetProperty("candidates")[0]
                    .GetProperty("content")
                    .GetProperty("parts")[0]
                    .GetProperty("text")
                    .GetString();

                // ✅ Chỉ lấy JSON trong markdown block và return dưới dạng string
                var cleanedJson = ExtractJsonFromMarkdown(rawText!);
                return cleanedJson;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xử lý phản hồi Gemini (Prompt chính): {ex.Message}\nRaw content: {responseString}");
            }
        }

        public static string ExtractJsonFromMarkdown(string text)
        {
            try
            {
                int start = text.IndexOf("```json");
                int end = text.LastIndexOf("```");

                if (start >= 0 && end > start)
                {
                    var jsonBlock = text.Substring(start + 7, end - start - 7); // bỏ ```json\n
                    return jsonBlock.Trim();
                }

                // Fallback: nếu không tìm thấy markdown block, thử cắt từ dấu { đến }
                start = text.IndexOf('{');
                end = text.LastIndexOf('}');
                if (start >= 0 && end > start)
                {
                    return text.Substring(start, end - start + 1).Trim();
                }

                throw new Exception("Không tìm thấy JSON hợp lệ trong phản hồi.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi Extract JSON: {ex.Message}\nRaw:\n{text}");
            }
        }
    }
}