using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Chat.Queries.GetInfoChatById
{
    public class GetInfoChatByIdDTO : BaseEntity
    {
        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }
        public Guid ConsultantId { get; set; }
        public Member Member { get; set; }
        public Consultant Consultant { get; set; }
    }
    public class Member 
    {
        public string? FullName { get; set; } 
        public string? PhoneNumber { get; set; } 
        public string? Email { get; set; } 
    }
    public class Consultant
    {
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
