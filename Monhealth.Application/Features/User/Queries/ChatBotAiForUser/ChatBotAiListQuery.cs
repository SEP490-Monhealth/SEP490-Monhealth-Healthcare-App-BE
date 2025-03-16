using MediatR;

namespace Monhealth.Application
{
    public class ChatBotAiListQuery : IRequest<(ChatBotAi , int)>
    {
        public Guid UserId { get; set; }
       
    }
}