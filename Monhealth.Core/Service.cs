using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
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
        public Guid CategoryId { get; set; }
        public ServiceType ServiceType { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public string ServiceDescription { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Duration { get; set; }
        public bool Status { get; set; }
        public string OnlineLink { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool VisitHome { get; set; }
        public int MaxDistance { get; set; }

        [ForeignKey(nameof(ConsultantId))]
        public Consultant Consultant { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public ICollection<Booking> Bookings { get; set; }

    }
}
