using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Goal : BaseEntity
    {
        [Key]
        public Guid GoalId { get; set; }
        public Guid UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; } = string.Empty;
        public GoalStatus Status { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }

    }
}
