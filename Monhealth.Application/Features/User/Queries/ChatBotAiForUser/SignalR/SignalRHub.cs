using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence; // Interface IMetricRepository
using Monhealth.Domain; // Model Metric

namespace Monhealth.Application
{
    public class SignalRHub : Hub
    {
        private readonly IMetricRepository _metricRepository;
        private readonly ILogger<SignalRHub> _logger;

        public SignalRHub(IMetricRepository metricRepository, ILogger<SignalRHub> logger)
        {
            _metricRepository = metricRepository;
            _logger = logger;
        }
        public async Task JoinGroup(string groupName, Guid userId)
        {
            // Thêm kết nối vào group
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            _logger.LogInformation(
                "User với ConnectionId '{ConnectionId}' đã tham gia group '{GroupName}'",
                Context.ConnectionId, groupName);

            // Gửi thông báo xác nhận đến client
            await Clients.Caller.SendAsync("JoinedGroup", $"Bạn đã tham gia group {groupName}");

            // Lấy thông tin Metric của user và gửi đến client
            try
            {
                var metric = await _metricRepository.GetByUserIdAsync(userId);
                if (metric == null)
                {
                    // Nếu không có thông tin Metric, có thể tạo giá trị mặc định hoặc thông báo lỗi
                    metric = new Metric
                    {
                        ActivityLevel = 0,
                        Height = 0,
                        Weight = 0,
                        Bmi = 0,
                        Bmr = 0,
                        Tdee = 0,
                        Ibw = 0
                    };
                }

                await Clients.Caller.SendAsync("ReceiveMetric", metric);
                _logger.LogInformation("Đã gửi thông tin Metric cho user {UserId}", userId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Lỗi khi lấy thông tin Metric cho user {UserId}", userId);
                await Clients.Caller.SendAsync("ReceiveMetric", new { error = "Lỗi khi lấy thông tin Metric" });
            }
        }

        public async Task SendMessageToClient(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
