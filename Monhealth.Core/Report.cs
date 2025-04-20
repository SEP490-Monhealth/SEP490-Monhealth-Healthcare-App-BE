using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Report : BaseEntity
    {
        [Key]
        public Guid ReportId { get; set; }
        public Guid BookingId { get; set; }
        public string Reason { get; set; }
        public List<string> ImageUrls { get; set; } = new();

        [ForeignKey(nameof(BookingId))]
        public Booking Booking { get; set; }
    }
}
