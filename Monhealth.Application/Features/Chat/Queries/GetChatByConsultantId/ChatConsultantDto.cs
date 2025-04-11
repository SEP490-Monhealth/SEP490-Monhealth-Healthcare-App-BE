﻿using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Chat.Queries.GetChatByConsultantId
{
    public class ChatConsultantDto : BaseEntity
    {
        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }
        public Guid ConsultantId { get; set; }
        public Member Member { get; set; }
        public string LastMessage { get; set; } = string.Empty;
    }
    public class Member
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
    }
}
