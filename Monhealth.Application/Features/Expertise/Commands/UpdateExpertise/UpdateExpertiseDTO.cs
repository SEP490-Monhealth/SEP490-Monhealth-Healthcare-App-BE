using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Expertise.Commands.UpdateExpertise
{
    public class UpdateExpertiseDTO
    {
        [JsonPropertyName("expertise")]
        public string ExpertiseName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string ExpertiseDescription { get; set; } = null!;
        [JsonPropertyName("certificate")]
        public string CertificateName { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public List<string> Images { get; set; } = new List<string>();
    }
}
