using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Chat.Queries.GetUserChatByUserId
{
    public class ChatDto : BaseEntity
    {
        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }
        public Guid ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
        public string LastMessage { get; set; } = string.Empty;

    }
    public class Consultant
    {
        public string FullName { get; set; }
        public string AvatarUrl { get; set; }
    }
}
