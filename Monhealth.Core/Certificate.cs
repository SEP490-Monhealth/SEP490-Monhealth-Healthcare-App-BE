﻿using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Certificate : TimeEntity
    {
        [Key]
        public Guid CertificateId { get; set; }
        public Guid? ConsultantId { get; set; }
        public Guid? ExpertiseId { get; set; }
        public string CertificateNumber { get; set; } = string.Empty;
        public string CertificateName { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string IssuedBy { get; set; } = null!;
        public bool IsVerified { get; set; } = false;
        public List<string> ImageUrls { get; set; } = new List<string>();

        [ForeignKey(nameof(ConsultantId))]
        public Consultant? Consultant { get; set; }
    }
}
