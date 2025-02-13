using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Schedule : TimeEntity
    {
        [Key]
        public Guid ScheduleId { get; set; } // PK 
        public Guid ConsultantId { get; set; } // FK 
        public DateOnly? Date { get; set; } // 
        public TimeOnly StarTime { get; set; } //
        public TimeOnly EndTime { get; set; }
        public int MaxBookings { get; set; }
        public int BookedSlots { get; set; } 
        public string Status { get; set; } = string.Empty;
        [ForeignKey(nameof(ConsultantId))]
        public AppUser User { get; set; }
    }
}
