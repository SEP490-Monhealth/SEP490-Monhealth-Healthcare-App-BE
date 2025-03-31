using System.Text;
using System.Text.Json;
using MediatR;
using Microsoft.Extensions.Configuration;
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

        public ChatBotAiListQueryHandler(
            IMetricRepository metricRepository,
            IFoodRepository foodRepository,
            IWorkoutRepository workoutRepository,
            IUserRepository userRepository,
            IGoalRepository goalRepository,
            HttpClient httpClient,
            IConfiguration configuration)
        {
            _foodRepository = foodRepository;
            _workoutRepository = workoutRepository;
            _userRepository = userRepository;
            _goalRepository = goalRepository;
            _metricRepository = metricRepository;
            _httpClient = httpClient;
            _geminiApiKey = configuration["Gemini:ApiKey"];
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
            var healthPlan = JsonSerializer.Deserialize<HealthPlanResponseDto>(aiResultJson, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = null // Giữ nguyên tên key tiếng Việt trong JSON
            });

            if (healthPlan == null)
                throw new Exception("Không thể phân tích dữ liệu phản hồi từ Gemini API.");

            return (chatBotAi, healthPlan);
        }

        private async Task<string> CallGeminiApi(ChatBotAi chatBotAi, string query)
        {
            var url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={_geminiApiKey}";

            var fullPrompt = @$"
Bạn là một chuyên gia tư vấn dinh dưỡng và huấn luyện thể hình trong một hệ thống chăm sóc sức khỏe cá nhân hóa. 
Nhiệm vụ của bạn là phân tích dữ liệu thể trạng, mục tiêu cá nhân, danh sách món ăn và các bài tập hiện có 
để xây dựng một **kế hoạch ăn uống và luyện tập phù hợp trong ngày**, hỗ trợ người dùng đạt mục tiêu tăng cân, tăng cơ, cải thiện thể chất.

---

🧠 **Yêu cầu cá nhân từ người dùng**:

---

Dưới đây là dữ liệu đầu vào từ người dùng:

1. **Thể trạng hiện tại (metric)**:
{JsonSerializer.Serialize(chatBotAi.Metric)}

2. **Mục tiêu cá nhân (goal)**:
{JsonSerializer.Serialize(chatBotAi.Goal)}

3. **Danh sách món ăn khả dụng (foods)**:
{JsonSerializer.Serialize(chatBotAi.Foods)}

4. **Danh sách bài tập sẵn có (workouts)**:
{JsonSerializer.Serialize(chatBotAi.Workouts)}

---

✅ **Yêu cầu lập kế hoạch trong ngày**:

- Chế độ ăn chia thành 3 bữa chính và 1 bữa phụ (Snack, nếu cần).
- Ưu tiên lựa chọn món ăn từ danh sách `foods`, dễ tìm tại Việt Nam, hỗ trợ tối ưu cho **tăng cân lành mạnh và phát triển cơ bắp**.
- Tổng năng lượng và dưỡng chất tiêu thụ trong ngày nên tiệm cận với mục tiêu: `CaloriesGoal`, `ProteinGoal`, `CarbsGoal`, `FatGoal`.
- Ghi rõ tổng năng lượng tiêu thụ và **giải thích chi tiết** lý do lựa chọn món ăn, kèm gợi ý thay thế nếu có dị ứng hoặc hạn chế thực phẩm.

- Kế hoạch luyện tập gồm 3 giai đoạn:
  - **Khởi động** (5 phút)
  - **Tập chính** (tối thiểu 25 phút)
  - **Giãn cơ** (5 phút)
- Bài tập chọn từ danh sách `workouts`, phù hợp với khả năng, đảm bảo thời lượng ≥ `WorkoutDurationGoal` và đốt cháy ≥ `CaloriesBurnedGoal`.

---

📌 **Chỉ trả về phản hồi ở dạng JSON hợp lệ theo đúng cấu trúc dưới đây. Không được thêm mô tả, tiêu đề, markdown hoặc ký tự nào bên ngoài JSON.**

```json
{{
  ""MealPlan"": {{
    ""Breakfast"": ""Tên món ăn sáng"",
    ""Lunch"": ""Tên món ăn trưa"",
    ""Dinner"": ""Tên món ăn tối"",
    ""Snack"": ""Tên món phụ hoặc null"",
    ""TotalCalories"": 0,
    ""Detail"": ""Mô tả chi tiết thành phần dinh dưỡng, lý do chọn từng món, và gợi ý thay thế nếu cần.""
  }},
  ""WorkoutRoutine"": [
    {{
      ""Stage"": ""Khởi động"",
      ""Exercises"": [""Tên bài tập""],
      ""Duration"": 5
    }},
    {{
      ""Stage"": ""Tập chính"",
      ""Exercises"": [""Tên bài tập""],
      ""Duration"": 25
    }},
    {{
      ""Stage"": ""Giãn cơ"",
      ""Exercises"": [""Tên bài tập""],
      ""Duration"": 5
    }}
  ],
  ""Tư vấn tổng quan từ AI"": ""Phân tích tổng thể và định hướng cải thiện sức khỏe."",
  ""Summary Conversation"": ""Tóm tắt kế hoạch cá nhân hóa dựa trên dữ liệu người dùng.""
}}
";


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

            var response = await _httpClient.PostAsync(url, content);
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

                var cleanedJson = ExtractJsonFromMarkdown(rawText!);

                var result = JsonSerializer.Deserialize<HealthPlanResponseDto>(cleanedJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = null
                });

                if (result == null)
                    throw new Exception("Không thể phân tích phản hồi JSON từ Gemini.");

                return JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = null
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xử lý phản hồi Gemini: {ex.Message}\nRaw content: {responseString}");
            }
        }
        private string ExtractJsonFromMarkdown(string rawText)
        {
            if (string.IsNullOrWhiteSpace(rawText)) return string.Empty;

            var startIndex = rawText.IndexOf("{");
            var endIndex = rawText.LastIndexOf("}");

            if (startIndex >= 0 && endIndex > startIndex)
            {
                return rawText.Substring(startIndex, endIndex - startIndex + 1);
            }

            return rawText;
        }

    }
}