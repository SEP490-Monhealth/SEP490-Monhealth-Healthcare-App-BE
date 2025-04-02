using MediatR;

namespace Monhealth.Application
{
    public class ChatBotAiListQuery : IRequest<(ChatBotAi, HealthPlanResponseDto)>
    {
        public Guid UserId { get; set; }
        public string Query { get; set; }

        public ChatBotAiListQuery(Guid userId, string query)
        {
            UserId = userId;
            Query = query;
        }
    }
}