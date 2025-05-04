using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class ExpertiseConfiguration : IEntityTypeConfiguration<Expertise>
    {
        public void Configure(EntityTypeBuilder<Expertise> builder)
        {
            var admin = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6");
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Expertise 1
            new Expertise
            {
                ExpertiseId = Guid.Parse("7a61f09f-f999-44fd-8973-105e22df1401"),
                ExpertiseName = "Dinh dưỡng",
                ExpertiseDescription = "Tư vấn xây dựng chế độ ăn uống cân đối, đa dạng và phù hợp với thể trạng cá nhân.",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Expertise 2
            new Expertise
            {
                ExpertiseId = Guid.Parse("44d9ffb3-a8b8-407b-975c-99e6f6146bc9"),
                ExpertiseName = "Thể hình",
                ExpertiseDescription = "Hướng dẫn bài tập tăng cơ, giảm mỡ và định hình cơ thể theo mục tiêu mong muốn.",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Expertise 3
            new Expertise
            {
                ExpertiseId = Guid.Parse("63100127-6781-4385-a1df-b21cae459bdb"),
                ExpertiseName = "Sức khỏe tâm lý",
                ExpertiseDescription = "Hỗ trợ giải quyết vấn đề căng thẳng, lo âu và cải thiện sức khỏe tinh thần.",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Expertise 4
            new Expertise
            {
                ExpertiseId = Guid.Parse("c5d7a490-e25e-4ae6-a6db-2d637e6630de"),
                ExpertiseName = "Thể thao",
                ExpertiseDescription = "Nâng cao kỹ thuật, hiệu suất và phòng tránh chấn thương trong các môn thể thao.",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Expertise 5
            new Expertise
            {
                ExpertiseId = Guid.Parse("67188399-9f09-4b74-9eb3-31ff82734850"),
                ExpertiseName = "Yoga",
                ExpertiseDescription = "Hướng dẫn các tư thế, kỹ thuật thở và thiền định để cân bằng thân-tâm.",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Expertise 6
            new Expertise
            {
                ExpertiseId = Guid.Parse("d762370d-3b36-45f6-ae15-bbe4c2b9bf8a"),
                ExpertiseName = "Thiền",
                ExpertiseDescription = "Dạy phương pháp tập trung tư tưởng, thư giãn sâu và phát triển nhận thức.",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Expertise 7
            new Expertise
            {
                ExpertiseId = Guid.Parse("c32b7429-13df-4aa0-b32d-705d1050de5f"),
                ExpertiseName = "Chế độ ăn kiêng",
                ExpertiseDescription = "Thiết kế thực đơn giảm cân khoa học, an toàn và phù hợp với lối sống.",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Expertise 8
            new Expertise
            {
                ExpertiseId = Guid.Parse("6c6a7d90-1c16-44ae-9b2a-b3addfe55dbc"),
                ExpertiseName = "Sức khỏe tổng quát",
                ExpertiseDescription = "Tư vấn lối sống lành mạnh, cân bằng giữa làm việc, nghỉ ngơi và vận động.",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Expertise 9
            new Expertise
            {
                ExpertiseId = Guid.Parse("fdb9b159-8cd5-4a4b-9879-1a140365c207"),
                ExpertiseName = "Phục hồi chức năng",
                ExpertiseDescription = "Hướng dẫn các bài tập và phương pháp phục hồi sau chấn thương hoặc phẫu thuật.",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Expertise 10
            new Expertise
            {
                ExpertiseId = Guid.Parse("8ad55299-b566-47e8-a9a0-1997e893e153"),
                ExpertiseName = "Giấc ngủ",
                ExpertiseDescription = "Tư vấn cải thiện chất lượng giấc ngủ và khắc phục các rối loạn giấc ngủ nhẹ.",
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            }
            #endregion


            );
        }
    }
}