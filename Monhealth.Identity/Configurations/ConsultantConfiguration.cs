using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class ConsultantConfiguration : IEntityTypeConfiguration<Consultant>
    {
        public void Configure(EntityTypeBuilder<Consultant> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Consultant 1
            new Consultant
            {
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                UserId = Guid.Parse("20041d5b-01e4-443f-9652-e39beb9748e5"),
                ExpertiseId = Guid.Parse("8ad55299-b566-47e8-a9a0-1997e893e153"),
                Bio = "Với kinh nghiệm hơn 2 năm trong lĩnh vực tư vấn tâm lý, tôi chuyên hỗ trợ những người gặp phải các triệu chứng trầm cảm, lo âu và căng thẳng kéo dài. Tôi tin rằng mỗi người đều có khả năng tìm lại sự cân bằng và hạnh phúc trong cuộc sống. Thông qua phương pháp trị liệu cá nhân hóa và sự đồng hành tận tâm, tôi giúp khách hàng từng bước vượt qua khó khăn, cải thiện sức khỏe tinh thần và xây dựng một cuộc sống tích cực hơn",
                Experience = 2,
                Views = 27,
                RatingCount = 100,
                AverageRating = 4.5,
                VerificationStatus = VerificationStatus.Verified,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            }
            #endregion
            );
        }
    }
}
