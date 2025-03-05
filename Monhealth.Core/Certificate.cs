using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Certificate : TimeEntity
    {
        [Key]
        public Guid CertificateId { get; set; }
        public Guid? ExpertiseId { get; set; }
        public Guid? ConsultantId { get; set; }
        public string CertificateName { get; set; } = string.Empty;
        public string ImageUrls { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(ConsultantId))]
        public Consultant? Consultant { get; set; }

        [ForeignKey(nameof(ExpertiseId))]
        public Expertise? Expertise { get; set; }
    }
}
