using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Review : BaseEntity
    {
        [Key]
        public Guid ReviewId { get; set; } // PK
        public Guid BookingId { get; set; } // FK
        public Guid UserId { get; set; } // FK
        public Guid ConsultantId { get; set; } // FK
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        [ForeignKey(nameof(BookingId))]
        public Booking Booking { get; set; }

    }
}
