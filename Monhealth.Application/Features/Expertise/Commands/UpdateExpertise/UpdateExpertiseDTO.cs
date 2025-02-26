using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Expertise.Commands.UpdateExpertise
{
    public class UpdateExpertiseDTO
    {
        public string ExpertiseName { get; set; } = string.Empty;
        public string CertificateName { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public List<string> Images { get; set; } = new List<string>();

    }
}
