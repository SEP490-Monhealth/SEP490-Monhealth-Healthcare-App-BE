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

            // Quang Thể hình
            #region Certificate 1
            new Certificate
            {
                CertificateId = Guid.NewGuid(),
                ExpertiseId = Guid.Parse("44d9ffb3-a8b8-407b-975c-99e6f6146bc9"),
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
                CertificateNumber = "CCH-2025-001",
                CertificateName = "Chứng chỉ thể hình vóc dáng",
                IssueDate = DateTime.ParseExact("01-01-2022", "dd-MM-yyyy", null),
                ExpiryDate = DateTime.ParseExact("01-01-2027", "dd-MM-yyyy", null),
                IssuedBy = "NASM",
                ImageUrls = new List<string> { "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media&token=331a36a4-82bb-4102-b224-da8cc1067efb" },
                CreatedAt = today,
                UpdatedAt = today,
                IsVerified = true,
            },
            #endregion

            // Thịnh Sức khỏe tổng quát
            #region Certificate 2
            new Certificate
            {
                CertificateId = Guid.NewGuid(),
                ExpertiseId = Guid.Parse("6c6a7d90-1c16-44ae-9b2a-b3addfe55dbc"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                CertificateNumber = "CCH-2022-040",
                CertificateName = "Chứng chỉ sức khỏe tổng quát",
                IssueDate = DateTime.ParseExact("01-01-2023", "dd-MM-yyyy", null),
                ExpiryDate = DateTime.ParseExact("01-01-2028", "dd-MM-yyyy", null),
                IssuedBy = "Mindful Schools",
                ImageUrls = new List<string> { "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media&token=331a36a4-82bb-4102-b224-da8cc1067efb" },
                CreatedAt = today,
                UpdatedAt = today,
                IsVerified = true,

            },
            #endregion

            // Quốc Duy Chế độ ăn kiêng
            #region Certificate 3
            new Certificate
            {
                CertificateId = Guid.NewGuid(),
                ExpertiseId = Guid.Parse("c32b7429-13df-4aa0-b32d-705d1050de5f"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                CertificateNumber = "CCH-2024-033",
                CertificateName = "Chứng chỉ giảm cân VICN",
                IssueDate = DateTime.ParseExact("01-01-2024", "dd-MM-yyyy", null),
                ExpiryDate = DateTime.ParseExact("01-01-2029", "dd-MM-yyyy", null),
                IssuedBy = "Academy of Nutrition",
                ImageUrls = new List<string> { "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media&token=331a36a4-82bb-4102-b224-da8cc1067efb" },
                CreatedAt = today,
                UpdatedAt = today,
                IsVerified = true,

            },
            #endregion

            // Thế Anh Thiền
            #region Certificate 4
            new Certificate
            {
                CertificateId = Guid.NewGuid(),
                ExpertiseId = Guid.Parse("d762370d-3b36-45f6-ae15-bbe4c2b9bf8a"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                CertificateNumber = "CCH-2025-042",
                CertificateName = "Chứng chỉ thiền",
                IssueDate = DateTime.ParseExact("01-01-2025", "dd-MM-yyyy", null),
                ExpiryDate = DateTime.ParseExact("01-01-2028", "dd-MM-yyyy", null),
                IssuedBy = "National Strength and Conditioning",
                ImageUrls = new List<string> { "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media&token=331a36a4-82bb-4102-b224-da8cc1067efb" },
                CreatedAt = today,
                UpdatedAt = today,
                IsVerified = true,

            },
            #endregion

            // Xuân Quang Yoga
            #region Certificate 5
            new Certificate
            {
                CertificateId = Guid.NewGuid(),
                ExpertiseId = Guid.Parse("67188399-9f09-4b74-9eb3-31ff82734850"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                CertificateNumber = "CCH-2024-121",
                CertificateName = "Chứng chỉ Yoga toàn thân",
                IssueDate = DateTime.ParseExact("01-01-2024", "dd-MM-yyyy", null),
                ExpiryDate = DateTime.ParseExact("01-01-2029", "dd-MM-yyyy", null),
                IssuedBy = "Yoga Alliance",
                ImageUrls = new List<string> { "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media&token=331a36a4-82bb-4102-b224-da8cc1067efb" },
                CreatedAt = today,
                UpdatedAt = today,
                IsVerified = true,

            },
            #endregion

            // Tiến phát Thể thao
            #region Certificate 6
            new Certificate
            {
                CertificateId = Guid.NewGuid(),
                ExpertiseId = Guid.Parse("c5d7a490-e25e-4ae6-a6db-2d637e6630de"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                CertificateNumber = "CCH-2025-531",
                CertificateName = "Giáo viên thể thao",
                IssueDate = DateTime.ParseExact("01-01-2024", "dd-MM-yyyy", null),
                ExpiryDate = DateTime.ParseExact("01-01-2027", "dd-MM-yyyy", null),
                IssuedBy = "ACSM",
                ImageUrls = new List<string> { "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media&token=331a36a4-82bb-4102-b224-da8cc1067efb" },
                CreatedAt = today,
                UpdatedAt = today,
                IsVerified = true,

            },
            #endregion

            // Văn Dũng Sức khỏe tâm lý
            #region Certificate 7
            new Certificate
            {
                CertificateId = Guid.NewGuid(),
                ExpertiseId = Guid.Parse("63100127-6781-4385-a1df-b21cae459bdb"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                CertificateNumber = "CCH-2023-751",
                CertificateName = "Chứng chỉ hỗ trợ tâm lý",
                IssueDate = DateTime.ParseExact("01-01-2025", "dd-MM-yyyy", null),
                ExpiryDate = DateTime.ParseExact("01-01-2029", "dd-MM-yyyy", null),
                IssuedBy = "American Council on Exercise",
                ImageUrls = new List<string> { "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media&token=331a36a4-82bb-4102-b224-da8cc1067efb" },
                CreatedAt = today,
                UpdatedAt = today,
                IsVerified = true,

            },
            #endregion

            #region Certificate 8
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
                ImageUrls = new List<string> { "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_1.jpg?alt=media&token=331a36a4-82bb-4102-b224-da8cc1067efb", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fcertificates%2Fchung_chi_2.jpg?alt=media&token=25015de2-7cdc-4a9f-9355-0c7b4b99fd85" },
                CreatedAt = today,
                UpdatedAt = today,
                IsVerified = true,

            }
            #endregion
            );
        }
    }
}