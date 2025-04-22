using System.Security.Claims;
using Microsoft.AspNetCore.SignalR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

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
        private readonly IMetricRepository _metricRepository;

        public SignalRHub(IMetricRepository metricRepository)
        {
            _metricRepository = metricRepository;
        }

        public override async Task OnConnectedAsync()
        {
            string connectionId = Context.ConnectionId;
            string userIdStr = Context.User?.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
            Guid userId = Guid.Parse(userIdStr);
            var metricEntity = await _metricRepository.GetMetricByUserAsync(userId);
            var metricForUser = new MetricForUser
            {
                Gender = metricEntity.Gender,
                DateOfBirth = metricEntity.DateOfBirth,
                Height = metricEntity.Height,
                Weight = metricEntity.Weight,
                ActivityLevel = metricEntity.ActivityLevel,
                Bmi = metricEntity.Bmi,
                Bmr = metricEntity.Bmr,
                Tdee = metricEntity.Tdee,
                Ibw = metricEntity.Ibw
            };
            var welcomeMessage = new
            {
                messageId = Guid.NewGuid().ToString(),
                sender = "Mon AI",
                content = new
                {
                    generalAdvice = metricForUser,
                    summaryConversation = "",
                    isHealthOrFitness = false
                }
            };

            await Clients.Client(connectionId).SendAsync("ReceiveMessage", welcomeMessage);

            await base.OnConnectedAsync();
        }

        public async Task SendMessageToClient(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
