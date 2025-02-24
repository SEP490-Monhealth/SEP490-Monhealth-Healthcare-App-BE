using Monhealth.Core;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Certificate : TimeEntity
    {
        [Key]
        public Guid CertificateId { get; set; } // PK 
        public Guid? UserId { get; set; } // FK 
        public Guid? ExpertiseId { get; set; }
        public string CertificateName { get; set; } = string.Empty;
        public string Images { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool Status { get; set; }
        [ForeignKey(nameof(ExpertiseId))]
        public Expertise? Expertise { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser? User { get; set; }
    }

}
