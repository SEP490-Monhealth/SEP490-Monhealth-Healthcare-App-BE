using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Certificate.Commands.UpdateCertificate
{
    public class UpdateCertificateDTO
    {
        public string? ExpertiseName { get; set; }
        [JsonPropertyName("number")]
        public string CertificateNumber { get; set; } = null!;
        [JsonPropertyName("name")]
        public string CertificateName { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string IssuedBy { get; set; } = null!;
        public List<string> ImageUrls { get; set; } = new List<string>();
    }
}
