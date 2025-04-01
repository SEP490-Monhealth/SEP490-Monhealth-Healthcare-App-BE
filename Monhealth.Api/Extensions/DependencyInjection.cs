using Monhealth.Api.Services;
using Monhealth.Application.Contracts.ChatBox;

namespace Monhealth.Api.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddChatNotification(this IServiceCollection services)
        {
            services.AddSignalR();

            // Khai báo scoped services tại đây
            services.AddScoped<IChatNotificationService, ChatNotificationService>();

            // Thêm các service presentation khác vào đây khi cần

            return services;
        }
    }
}
