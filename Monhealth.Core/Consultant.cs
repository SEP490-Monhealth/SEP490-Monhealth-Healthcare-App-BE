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
        public string Bio { get; set; } = string.Empty;
        public int Experience { get; set; }
        // [ForeignKey(nameof(UserId))]
        // public AppUser AppUser { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
        public ICollection<ConsultantExpertise>? ConsultantExpertises { get; set; }
    }
}
