using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;
using System.Text.Json;

namespace Monhealth.Application
{
    public class MetricForUser
    {
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float ActivityLevel { get; set; }
        public float Bmi { get; set; }
        public float Bmr { get; set; }
        public float Tdee { get; set; }
        public float Ibw { get; set; }
    }

    public class SignalRHub : Hub
    {
        private readonly IUserRepository _userRepo;
        private readonly IMetricRepository _metricRepository;
        private readonly ILogger<SignalRHub> _logger;

        public SignalRHub(IMetricRepository metricRepository,
        ILogger<SignalRHub> logger,
        IUserRepository userRepo)
        {
            _userRepo = userRepo;
            _metricRepository = metricRepository;
            _logger = logger;
        }

        public override async Task OnConnectedAsync()
        {
            _logger.LogInformation("Client connected: {ConnectionId}", Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            _logger.LogInformation("Client disconnected: {ConnectionId}, Exception: {Exception}",
                Context.ConnectionId, exception?.Message ?? "No exception");
            await base.OnDisconnectedAsync(exception);
        }

        public async Task JoinChat(string userId)
        {
            _logger.LogInformation("JoinChat called with userId: {UserId}", userId);

            if (string.IsNullOrEmpty(userId))
            {
                _logger.LogWarning("Empty userId provided by client {ConnectionId}", Context.ConnectionId);
                await Clients.Caller.SendAsync("ErrorOccurred", "Invalid user ID provided");
                return;
            }

            try
            {
                // Check if we can parse the userId to a Guid to ensure validity
                if (Guid.TryParse(userId, out Guid userGuid))
                {
                    _logger.LogInformation("Valid userId format: {UserGuid}", userGuid);

                    // Add connection to a group named after the userId
                    await Groups.AddToGroupAsync(Context.ConnectionId, userId);
                    _logger.LogInformation("Added to group: {UserId}", userId);

                    // Fetch user metrics - get the list first
                    _logger.LogInformation("Fetching metrics for user: {UserGuid}", userGuid);

                    var metrics = await _metricRepository.GetMetricByUserIdAsync(userGuid);
                    var user = await _userRepo.GetUserByIdAsync(userGuid);

                    if (metrics == null || !metrics.Any())
                    {
                        _logger.LogWarning("No metrics found for user: {UserGuid}", userGuid);
                        await Clients.Caller.SendAsync("ErrorOccurred", "No metrics found for this user");
                        return;
                    }

                    // Get the most recent metric
                    var latestMetric = metrics
                        .OrderByDescending(m => m.CreatedAt)
                        .FirstOrDefault();

                    _logger.LogInformation("Latest metric found with date: {Date}", latestMetric?.CreatedAt);

                    var metricForUser = new MetricForUser
                    {
                        Gender = latestMetric.Gender,
                        DateOfBirth = latestMetric.DateOfBirth,
                        Height = latestMetric.Height,
                        Weight = latestMetric.Weight,
                        ActivityLevel = latestMetric.ActivityLevel,
                        Bmi = latestMetric.Bmi,
                    };

                    _logger.LogInformation("User latest metrics retrieved: {Metrics}",
                        JsonSerializer.Serialize(metricForUser));

                    // Tạo tin nhắn chào mừng với thông tin cá nhân hóa
                    string welcomeText = CreatePersonalizedWelcomeMessage(metricForUser, user.FullName);

                    var welcomeMessage = new
                    {
                        messageId = Guid.NewGuid().ToString(),
                        sender = "Mon AI",
                        content = new
                        {
                            generalAdvice = welcomeText,
                            summaryConversation = "",
                            isHealthOrFitness = false
                        }
                    };

                    _logger.LogInformation("Sending personalized welcome message to user");
                    await Clients.Caller.SendAsync("ReceiveMessage", welcomeMessage);

                    _logger.LogInformation("Sending join confirmation");
                    await Clients.Caller.SendAsync("JoinedChat", $"Successfully joined chat as user {userId}");
                }
                else
                {
                    _logger.LogWarning("Invalid userId format: {UserId}", userId);
                    await Clients.Caller.SendAsync("ErrorOccurred", "Invalid user ID format");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in JoinChat method for userId: {UserId}", userId);
                await Clients.Caller.SendAsync("ErrorOccurred", $"Error joining chat: {ex.Message}");
            }
        }

        private string CreatePersonalizedWelcomeMessage(MetricForUser metric, string fullName)
        {
            int age = CalculateAge(metric.DateOfBirth);
            string bmiStatus = GetBmiStatus(metric.Bmi);
            string activityText = GetActivityLevelText(metric.ActivityLevel);

            string message = $"Xin chào {fullName}! Rất vui được gặp bạn hôm nay. " +
                $"Tôi là Mon AI, trợ lý sức khỏe cá nhân của bạn.\n\n" +
                $"Dựa trên thông tin hiện tại, bạn đang {age} tuổi, cao {metric.Height}cm và nặng {metric.Weight}kg. " +
                $"Chỉ số BMI của bạn là {metric.Bmi:F1}, cho thấy bạn đang {bmiStatus}. " +
                $"Mức hoạt động thể chất của bạn ở mức {activityText}.\n\n" +
                $"Tôi có thể giúp bạn theo dõi sức khỏe, cung cấp lời khuyên về dinh dưỡng và tập luyện. " +
                $"Hãy cho tôi biết bạn cần giúp đỡ điều gì nhé!";

            return message;
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }

        private string GetBmiStatus(float bmi)
        {
            if (bmi < 18.5) return "thiếu cân";
            if (bmi < 25) return "có cân nặng bình thường";
            if (bmi < 30) return "thừa cân";
            return "béo phì";
        }

        private string GetActivityLevelText(float activityLevel)
        {
            if (activityLevel <= 1.2f) return "ít vận động";
            if (activityLevel <= 1.375f) return "vận động nhẹ";
            if (activityLevel <= 1.55f) return "vận động vừa phải";
            if (activityLevel <= 1.725f) return "vận động tích cực";
            return "vận động rất tích cực";
        }

        public async Task SendMessageToClient(string message)
        {
            _logger.LogInformation("SendMessageToClient called with message: {Message}",
                message?.Length > 100 ? message.Substring(0, 100) + "..." : message);

            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}