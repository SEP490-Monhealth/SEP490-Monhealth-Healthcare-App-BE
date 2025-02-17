using Monhealth.Domain;
using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Core
{
    public class Expertise : TimeEntity
    {
        [Key]
        public Guid ExpertiseId { get; set; }
        public string ExpertiseName { get; set; } = string.Empty;

        public Certificate? Certificate { get; set; }
        public ICollection<ConsultantExpertise>? ConsultantExpertises { get; set; }
    }
}