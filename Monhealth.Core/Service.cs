using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Service : TimeEntity
    {
        [Key]
        public Guid ServiceId { get; set; } // PK 
        public Guid ConsultantId { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public string ServiceDescription { get; set; } = string.Empty;
        public int Price { get; set; }

        [ForeignKey(nameof(ConsultantId))]
        public AppUser Consultant { get; set; }

        public ICollection<Booking> Bookings { get; set; }

    }
}
