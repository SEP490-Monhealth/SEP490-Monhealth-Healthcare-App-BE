using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Message.Queries.GetAllMessages
{
    public class MessageDto : TimeEntity
    {
        public Guid MessageId { get; set; }
        public Guid ChatId { get; set; }
        public Guid SenderId { get; set; }
        public string AvatarUrl { get; set; } = string.Empty;
        //public bool IsSender { get; set; }
        public string Content { get; set; } = string.Empty;
        public bool IsRead { get; set; }
    }
}
