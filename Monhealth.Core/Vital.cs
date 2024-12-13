using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Vital : BaseEntity
    {
        [Key]
        public Guid VitalId { get; set; }
        public Guid UserId { get; set; }
        public string BloodPressure { get; set; } = string.Empty;
        public int HeartRate { get; set; }
        public float BloodGlucose { get; set; }
        public string Allergies { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
    }

}
