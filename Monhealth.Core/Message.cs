using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
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

        [ForeignKey(nameof(ChatId))]
        public Chat Chat { get; set; }
        // Navigation properties
        [ForeignKey(nameof(SenderId))]
        public AppUser SenderAppUser { get; set; }

        [ForeignKey(nameof(SenderId))]
        public Consultant SenderConsultant { get; set; }

        [ForeignKey(nameof(ReceiverId))]
        public AppUser ReceiverAppUser { get; set; }

        [ForeignKey(nameof(ReceiverId))]
        public Consultant ReceiverConsultant { get; set; }
    }
}
