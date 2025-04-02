using Microsoft.AspNetCore.SignalR;

namespace Monhealth.Application
{
    public class SignalRHub : Hub
    {
        public async Task SendMessageToClient(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}