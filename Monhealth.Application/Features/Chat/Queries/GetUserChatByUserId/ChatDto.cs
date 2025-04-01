using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Chat.Queries.GetUserChatByUserId
{
    public class ChatDto : TimeEntity
    {
        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }
        public Guid ConsultantId { get; set; }
        public string LastMessage { get; set; } = string.Empty;

    }
}
