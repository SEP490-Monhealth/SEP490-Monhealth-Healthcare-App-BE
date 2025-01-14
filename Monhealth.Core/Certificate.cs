using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Certificate : BaseEntity
    {
        [Key]
        public Guid CertificateId { get; set; } // PK 
        public Guid UserId { get; set; } // FK 
        public string CertificateName { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool Status { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }
        public ICollection<CertificateImage> Images { get; set; }
    }

}
