using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class CertificateImage : TimeEntity
    {
        [Key]
        public Guid ImageId { get; set; } // PK
        public Guid CertificateId { get; set; } // FK
        public string Url { get; set; } = string.Empty; // FK
        [ForeignKey(nameof(CertificateId))]
        public Certificate Certificate { get; set; }

    }
}
