using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Message : TimeEntity
    {
        [Key]
        public Guid MessageId { get; set; }
        public Guid ChatId { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Content { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;

        [ForeignKey(nameof(ChatId))]
        public Chat Chat { get; set; }
    }
}
