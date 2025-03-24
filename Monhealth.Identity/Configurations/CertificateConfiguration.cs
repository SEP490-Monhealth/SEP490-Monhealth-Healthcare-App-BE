using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Certificate 1
            new Certificate
            {
                CertificateId = Guid.NewGuid(),
                ExpertiseId = Guid.Parse("8ad55299-b566-47e8-a9a0-1997e893e153"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                CertificateNumber = "CERT-2025-002",
                CertificateName = "Chứng chỉ tư vấn dinh dưỡng",
                IssueDate = DateTime.ParseExact("01-01-2025", "dd-MM-yyyy", null),
                ExpiryDate = DateTime.ParseExact("01-01-2026", "dd-MM-yyyy", null),
                IssuedBy = "Monhealth Academy",
                ImageUrls = new List<string> { "https://example.com/certificate1.jpg" },
                CreatedAt = today,
                UpdatedAt = today,
            }
            #endregion
            );
        }
    }
}