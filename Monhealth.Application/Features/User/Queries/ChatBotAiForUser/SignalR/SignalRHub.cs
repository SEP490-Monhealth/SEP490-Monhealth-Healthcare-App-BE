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
        public override async Task OnConnectedAsync()
        {
            string connectionId = Context.ConnectionId;

            var welcomeMessage = new
            {
                messageId = Guid.NewGuid().ToString(),
                sender = "MonAI",
                content = new
                {
                    generalAdvice = "Chào bạn! Tôi là MonAI, trợ lý ảo của bạn. Tôi có thể giúp gì cho bạn?",
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
