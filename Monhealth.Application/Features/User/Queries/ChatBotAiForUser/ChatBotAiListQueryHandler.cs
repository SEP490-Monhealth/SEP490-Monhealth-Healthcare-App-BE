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
        private readonly IHubContext<SignalRHub> _hubContext;

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
            // Lấy thông tin người dùng
            var user = await _userRepository.GetByIdAsync(request.UserId);
            if (user == null)
                throw new Exception("User not found.");

            // Lấy thông tin metric của người dùng
            var metrics = await _metricRepository.GetByUserIdAsync(request.UserId);
            if (metrics == null)
                throw new Exception("Metrics not found for the user.");

            // Lấy danh sách food (loại bỏ những đối tượng null nếu có)
            var foods = await _foodRepository.GetFoodByUserHasNoAllergiesAsync(request.UserId) ?? new List<Food>();
            foods = foods.Where(f => f != null).ToList();

            // Lấy danh sách workout và goal
            var workouts = await _workoutRepository.GetAllAsync() ?? new List<Workout>();
            var goal = await _goalRepository.GetByUserIdAsync(request.UserId);

            // Mapping danh sách workout (chỉ lấy workoutId và workoutName)
            var workoutDTOList = workouts
                .Where(w => !string.IsNullOrEmpty(w.WorkoutName))
                .Select(w => new WorkoutDTOItem
                {
                    WorkoutId = w.WorkoutId,
                    WorkoutName = w.WorkoutName
                })
                .ToList();

            // Mapping danh sách food theo nhóm dinh dưỡng
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
                    FoodId = g.Select(f => f.FoodId).ToList(),
                    FoodName = g.Where(f => !string.IsNullOrEmpty(f.FoodName)).Select(f => f.FoodName).ToList(),
                    Calories = g.Key.Calories,
                    Protein = g.Key.Protein,
                    Carbs = g.Key.Carbs,
                    Fat = g.Key.Fat
                })
                .ToList();

            // Xây dựng đối tượng chatBotAi (dữ liệu đầu vào cho Gemini)
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
                    Workouts = workoutDTOList
                }
            };

            // Nếu không có truy vấn từ client thì trả luôn thông tin Metric qua SignalR mà không cần gọi GEMINI API
            if (string.IsNullOrWhiteSpace(request.Query))
            {
                // Gửi thông tin Metric về cho client (bạn có thể dùng Clients.Caller hay Clients.All tùy logic nghiệp vụ)
                await _hubContext.Clients.All.SendAsync("ReceiveMetric", chatBotAi.Metric);

                // Trả về một HealthPlanResponseDto mặc định (bạn cần tạo Object phù hợp theo cấu trúc dự định)
                var defaultPlan = new HealthPlanResponseDto
                {
                    MealPlan = null,
                    WorkoutRoutine = null,
                    health_or_fitness = true,
                    GeneralAdvice = "Đây là thông tin Metric của bạn.",
                    SummaryConversation = "Không có kế hoạch chi tiết do không có yêu cầu từ người dùng."
                };

                return (chatBotAi, defaultPlan);
            }

            // Nếu có truy vấn, gọi GEMINI API để lấy kế hoạch dựa trên dữ liệu đầu vào
            string aiResultJson = await CallGeminiApi(chatBotAi, request.Query);

            // Deserialize phản hồi JSON từ GEMINI API
            var healthPlan = JsonSerializer.Deserialize<HealthPlanResponseDto>(
                aiResultJson,
                GetJsonSerializerOptions()
            );

            if (healthPlan == null)
                throw new Exception("Không thể phân tích dữ liệu phản hồi từ Gemini API.");

            // Gửi phản hồi của GEMINI API đến các client qua SignalR (ví dụ như dùng ReceiveMessage)
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", aiResultJson);

            return (chatBotAi, healthPlan);
        }

        private JsonSerializerOptions GetJsonSerializerOptions()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = null // Giữ nguyên key JSON (ví dụ: có thể là tiếng Việt)
            };
            options.Converters.Add(new GuidConverter());
            return options;
        }

        private async Task<string> CallGeminiApi(ChatBotAi chatBotAi, string query)
        {
            var url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={_geminiApiKey}";

            // --- Bước 1: Sử dụng prompt2 để kiểm tra xem query có liên quan đến health hay không ---
            string prompt2 = GeminiPromptBuilder.BuildPrompt2(query);
            var checkRequest = new
            {
                contents = new[]
                {
                    new { parts = new[] { new { text = prompt2 } } }
                }
            };

            var checkJson = JsonSerializer.Serialize(checkRequest);
            var checkContent = new StringContent(checkJson, Encoding.UTF8, "application/json");
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = checkContent
            };

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

                // Nếu câu hỏi không liên quan đến sức khỏe, trả luôn kết quả từ prompt2
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
                throw new Exception(
                    $"❌ Lỗi khi parse JSON từ AI (Prompt2): {ex.Message}\n\n== Extracted JSON ==\n{checkJsonContent}"
                );
            }

            // --- Bước 2: Xây dựng full prompt để tạo kế hoạch dựa trên dữ liệu người dùng ---
            var fullPrompt = GeminiPromptBuilder.BuildFullPrompt(chatBotAi);
            var requestBody = new
            {
                contents = new[]
                {
                    new { parts = new[] { new { text = fullPrompt } } }
                }
            };

            var jsonBody = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            var requestMessage1 = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = content
            };

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

                // Chỉ lấy JSON trong markdown block và trả về string
                var cleanedJson = ExtractJsonFromMarkdown(rawText!);
                return cleanedJson;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Lỗi khi xử lý phản hồi Gemini (Prompt chính): {ex.Message}\nRaw content: {responseString}"
                );
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
                    // Bỏ đoạn "```json" và các khoảng trắng, newline
                    var jsonBlock = text.Substring(start + 7, end - start - 7);
                    return jsonBlock.Trim();
                }

                // Fallback: Nếu không có Markdown block, tìm dấu '{' và '}'
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
