using Monhealth.Core;
using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class ConsultantExpertise : TimeEntity
    {
        [Key]
        public Guid ConsultantExpertiseId { get; set; }
        public Guid? ConsultantId { get; set; }
        public Guid? ExpertiseId { get; set; }

        [ForeignKey(nameof(ExpertiseId))]
        public Expertise? Expertise { get; set; }
        [ForeignKey(nameof(ConsultantId))]
        public Consultant? Consultant { get; set; }
    }
}
