﻿using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Consultant.Commands.CreateConsultant
{
    public class CreateConsultantDTO
    {
        public Guid? UserId { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int? Experience { get; set; }
        [JsonPropertyName("expertise")]
        public string ExpertiseName { get; set; } = string.Empty;
        [JsonPropertyName("certificate")]
        public string CertificateName { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public List<string>? Images { get; set; }
    }
}
