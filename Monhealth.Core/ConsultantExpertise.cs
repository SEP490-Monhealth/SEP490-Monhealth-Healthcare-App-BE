using System.ComponentModel.DataAnnotations;
using Monhealth.Domain;
using Monhealth.Domain.Common;

namespace Monhealth.Core
{
    public class ConsultantExpertise : TimeEntity
    {
        [Key]
        public Guid ConsultantExpertiseId { get; set; }
        public Guid ConsultantId { get; set; }
        public string Expertise { get; set; } = string.Empty;
        public Consultant Consultant { get; set; }
    }
}