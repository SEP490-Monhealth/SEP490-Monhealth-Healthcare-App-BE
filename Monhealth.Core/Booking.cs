using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Booking : BaseEntity
    {
        [Key]
        public Guid BookingId { get; set; } // PK
        //public Guid? ServiceId { get; set; } // FK
        public Guid? UserId { get; set; } // FK
        public Guid? ConsultantId { get; set; } // FK
        public DateTime Date { get; set; }
        public string? Notes { get; set; } = string.Empty;
        public BookingStatus Status { get; set; }
        [ForeignKey(nameof(UserId)), Column(Order = 0)]
        public AppUser? User { get; set; }
        //[ForeignKey(nameof(ServiceId))]
        //public Service Service { get; set; }
        [ForeignKey(nameof(ConsultantId)), Column(Order = 1)]
        public Consultant? Consultant { get; set; }

    }
}
