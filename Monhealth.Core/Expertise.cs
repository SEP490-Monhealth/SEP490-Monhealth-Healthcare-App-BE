using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Domain
{
    public class Expertise : TimeEntity
    {
        [Key]
        public Guid ExpertiseId { get; set; }
        public string ExpertiseName { get; set; } = string.Empty;
        public string ExpertiseDescription { get; set; } = string.Empty;

        public ICollection<Consultant>? Consultants { get; set; }
    }
}