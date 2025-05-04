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

            // Quang Thể hình
            #region Consultant 1  
            new Consultant
            {
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
                UserId = Guid.Parse("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                ExpertiseId = Guid.Parse("44d9ffb3-a8b8-407b-975c-99e6f6146bc9"),
                Bio = "Chuyên gia thể hình Quang, với hơn 5 năm kinh nghiệm huấn luyện thể hình cho hàng trăm khách hàng, giúp họ đạt được mục tiêu tăng cơ và giảm mỡ hiệu quả. Tôi luôn sử dụng các bài tập đa dạng và công cụ phù hợp để mang lại kết quả tối ưu.",
                Experience = 5,
                BookingCount = 1,
                RatingCount = 0,
                AverageRating = 0,
                Views = 14,
                VerificationStatus = VerificationStatus.Verified,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Thịnh Sức khỏe tổng quát
            #region Consultant 2
            new Consultant
            {
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                UserId = Guid.Parse("6535e9eb-fd28-448a-bb0f-31b2dbe2a013"),
                ExpertiseId = Guid.Parse("6c6a7d90-1c16-44ae-9b2a-b3addfe55dbc"),
                Bio = "Chuyên tư vấn về lối sống lành mạnh và cách duy trì sự cân bằng giữa công việc, cuộc sống và tập luyện thể thao.",
                Experience = 1,
                BookingCount = 0,
                RatingCount = 1,
                AverageRating = 0,
                Views = 21,
                VerificationStatus = VerificationStatus.Verified,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Quốc Duy Chế độ ăn kiêng
            #region Consultant 3
            new Consultant
            {
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                UserId = Guid.Parse("258e6035-f606-492e-9d24-c6e27ec1ecfe"),
                ExpertiseId = Guid.Parse("c32b7429-13df-4aa0-b32d-705d1050de5f"),
                Bio = "Với kinh nghiệm tư vấn cho hàng nghìn khách hàng về chế độ ăn kiêng và giảm cân an toàn. Phương Anh luôn thiết kế thực đơn giảm cân phù hợp với nhu cầu và sức khỏe của từng người.",
                Experience = 2,
                BookingCount = 0,
                RatingCount = 0,
                AverageRating = 0,
                Views = 17,
                VerificationStatus = VerificationStatus.Verified,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Thế Anh Thiền
            #region Consultant 4
            new Consultant
            {
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                UserId = Guid.Parse("2606b7e4-3fec-43c2-8988-8db7dfb0d56e"),
                ExpertiseId = Guid.Parse("d762370d-3b36-45f6-ae15-bbe4c2b9bf8a"),
                Bio = "Chuyên gia Thiền Thế Anh, với hơn 6 năm kinh nghiệm trong việc giảng dạy thiền và phát triển nhận thức. Tôi giúp khách hàng vượt qua căng thẳng, lo âu và tìm lại sự bình yên trong tâm trí.",
                Experience = 6,
                BookingCount = 0,
                RatingCount = 0,
                AverageRating = 0,
                Views = 36,
                VerificationStatus = VerificationStatus.Verified,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Xuân Quang Yoga
            #region Consultant 5
            new Consultant
            {
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                UserId = Guid.Parse("b49c65e4-1864-4f8d-82ad-87838284e33f"),
                ExpertiseId = Guid.Parse("67188399-9f09-4b74-9eb3-31ff82734850"),
                Bio = "7 năm kinh nghiệm trong việc giảng dạy Yoga cho các nhóm đối tượng khác nhau, từ người mới bắt đầu đến những người muốn nâng cao kỹ thuật. Luôn tập trung vào sự cân bằng thân-tâm và sự thư giãn tối đa trong mỗi buổi tập.",
                Experience = 7,
                BookingCount = 0,
                RatingCount = 0,
                AverageRating = 0,
                Views = 38,
                VerificationStatus = VerificationStatus.Verified,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Tiến Phát Thể thao
            #region Consultant 6
            new Consultant
            {
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                UserId = Guid.Parse("619de5dc-80d1-40c7-bae5-bd8940d6e780"),
                ExpertiseId = Guid.Parse("c5d7a490-e25e-4ae6-a6db-2d637e6630de"),
                Bio = "Chuyên tư vấn kỹ thuật thể thao và phòng ngừa chấn thương cho các vận động viên chuyên nghiệp. Bản thân tôi đã giúp nhiều vận động viên nâng cao thành tích thi đấu và duy trì sức khỏe lâu dài.",
                Experience = 3,
                BookingCount = 0,
                RatingCount = 0,
                AverageRating = 0,
                Views = 19,
                VerificationStatus = VerificationStatus.Verified,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Văn Dũng Sức khỏe tâm lý
            #region Consultant 7
            new Consultant
            {
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                UserId = Guid.Parse("b2ad99a0-43fd-4b12-8864-3a2e2626fb90"),
                ExpertiseId = Guid.Parse("63100127-6781-4385-a1df-b21cae459bdb"),
                Bio = "Với hơn 8 năm kinh nghiệm, chuyên cung cấp dịch vụ tư vấn cho những người gặp vấn đề về căng thẳng, lo âu và stress. Tôi áp dụng các phương pháp trị liệu hiện đại như CBT (Cognitive Behavioral Therapy) để giúp khách hàng cải thiện sức khỏe tinh thần.",
                Experience = 8,
                BookingCount = 1,
                RatingCount = 0,
                AverageRating = 0,
                Views = 54,
                VerificationStatus = VerificationStatus.Verified,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Van Huu Toan Con Giấc ngủ
            #region Consultant 8
            new Consultant
            {
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                UserId = Guid.Parse("20041d5b-01e4-443f-9652-e39beb9748e5"),
                ExpertiseId = Guid.Parse("8ad55299-b566-47e8-a9a0-1997e893e153"),
                Bio = "Với kinh nghiệm hơn 2 năm trong lĩnh vực tư vấn tâm lý, tôi chuyên hỗ trợ những người gặp phải các triệu chứng trầm cảm, lo âu và căng thẳng kéo dài. Tôi tin rằng mỗi người đều có khả năng tìm lại sự cân bằng và hạnh phúc trong cuộc sống. Thông qua phương pháp trị liệu cá nhân hóa và sự đồng hành tận tâm, tôi giúp khách hàng từng bước vượt qua khó khăn, cải thiện sức khỏe tinh thần và xây dựng một cuộc sống tích cực hơn",
                Experience = 2,
                BookingCount = 0,
                RatingCount = 0,
                AverageRating = 0,
                Views = 27,
                VerificationStatus = VerificationStatus.Verified,
                Status = false,
                UpdatedAt = today,
                CreatedAt = today,
            }
            #endregion
            );
        }
    }
}
