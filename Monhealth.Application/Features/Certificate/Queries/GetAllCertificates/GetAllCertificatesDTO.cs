using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Certificate.Queries.GetAllCertificates
{
    public class GetAllCertificatesDTO
    {
        public Guid CertificateId { get; set; } // PK 
        public Guid ExpertiseId { get; set; }
        public string CertificateName { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new List<string>();
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
