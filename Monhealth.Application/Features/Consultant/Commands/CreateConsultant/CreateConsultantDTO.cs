using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Consultant.Commands.CreateConsultant
{
    public class CreateConsultantDTO
    {
        public Guid? UserId { get; set; }
        public Guid ExpertiseId { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int? Experience { get; set; }

        // Expertise
        public string ExpertiseName { get; set; } = string.Empty;

        // Certificate
        public string CertificateName { get; set; } = string.Empty;
        public string Images { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
