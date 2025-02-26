using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Consultant : TimeEntity
    {
        [Key]
        public Guid ConsultantId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ExpertiseId { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int? Experience { get; set; }
        public bool? Status { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(ExpertiseId))]
        public Expertise Expertise { get; set; }
    }
}
