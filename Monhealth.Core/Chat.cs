using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Chat : TimeEntity
    {
        [Key]
        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }
        public Guid ConsultantId { get; set; }
        public string LastMessage { get; set; } = string.Empty;

        public ICollection<Message> Messages { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(ConsultantId))]
        public Consultant Consultant { get; set; }
    }
}
