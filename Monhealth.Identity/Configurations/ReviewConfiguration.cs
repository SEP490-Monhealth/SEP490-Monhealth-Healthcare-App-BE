using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(

            // Toàn - Văn Dũng
            #region Review 1 for Booking 1
            new Review
            {
                ReviewId = Guid.Parse("F28C5D8A-2D1B-463C-B938-5D4C6B9F6851"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                BookingId = Guid.Parse("2816BE7A-00E3-4ACC-B7CB-28CA8F9FDD84"),
                Rating = 5,
                Comment = "Chuyên viên Văn Dũng rất tận tâm và chuyên nghiệp. Tôi nhận được nhiều lời khuyên hữu ích về cách cải thiện sức khỏe và lối sống. Đặc biệt ấn tượng với kiến thức chuyên môn và phương pháp tư vấn dễ hiểu.",
                CreatedAt = DateTime.ParseExact("02-05-2025 17:38:22", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("02-05-2025 17:38:22", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Toàn - Quang (Reported status but IsReviewed = true)
            #region Review 2 for Booking 3
            new Review
            {
                ReviewId = Guid.Parse("C9D2F4E7-A5B3-4C81-89D6-F07E8A6509B2"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                BookingId = Guid.Parse("D203CDA3-84D8-4B38-A09B-15975005EA82"),
                Rating = 1,
                Comment = "Buổi tư vấn không đạt kỳ vọng. Chuyên viên đến trễ và không chuẩn bị kỹ các tài liệu. Thái độ phục vụ chưa tốt và tư vấn quá chung chung, không đề cập đến vấn đề cụ thể của tôi. Rất thất vọng!",
                CreatedAt = DateTime.ParseExact("12-04-2025 16:12:45", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("12-04-2025 16:12:45", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Duy - Thế Anh
            #region Review 3 for Booking 4
            new Review
            {
                ReviewId = Guid.Parse("A1B2C3D4-E5F6-47G8-H9I0-J1K2L3M4N5O6"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                BookingId = Guid.Parse("fa8f2dd7-8f5e-4da1-aa9c-64d95feeb8ed"),
                Rating = 5,
                Comment = "Bác sĩ Thế Anh rất nhiệt tình và chu đáo. Tôi đã nhận được những lời khuyên quý báu về chế độ ăn uống và tập luyện phù hợp với tình trạng sức khỏe hiện tại của mình. Cảm ơn bác sĩ rất nhiều!",
                CreatedAt = DateTime.ParseExact("27-04-2025 10:28:33", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("27-04-2025 10:28:33", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Duy - Xuân Quang
            #region Review 4 for Booking 5
            new Review
            {
                ReviewId = Guid.Parse("B2C3D4E5-F6G7-48H9-I0J1-K2L3M4N5O6P7"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                BookingId = Guid.Parse("fd79d35c-785e-4b43-a471-37272379bb1e"),
                Rating = 4,
                Comment = "Chuyên viên Xuân Quang có kiến thức chuyên môn tốt và đã tư vấn chi tiết về các vấn đề tôi đang gặp phải. Tuy nhiên, thời gian tư vấn hơi ngắn so với mong đợi. Nhìn chung buổi tư vấn khá hữu ích.",
                CreatedAt = DateTime.ParseExact("15-04-2025 11:52:08", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("15-04-2025 11:52:08", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Duy - Tiến Phát
            #region Review 5 for Booking 6
            new Review
            {
                ReviewId = Guid.Parse("C3D4E5F6-G7H8-49I0-J1K2-L3M4N5O6P7Q8"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                BookingId = Guid.Parse("a5586882-da12-4f03-8f9f-75b9bee2ae36"),
                Rating = 5,
                Comment = "Bác sĩ Tiến Phát rất tận tâm và lắng nghe. Tôi đã nhận được phác đồ điều trị phù hợp và lời khuyên thiết thực về việc cải thiện sức khỏe. Đặc biệt ấn tượng với cách bác sĩ giải thích mọi thứ một cách dễ hiểu.",
                CreatedAt = DateTime.ParseExact("20-03-2025 14:57:41", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("20-03-2025 14:57:41", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Đại - Văn Dũng
            #region Review 6 for Booking 7
            new Review
            {
                ReviewId = Guid.Parse("D4E5F6G7-H8I9-4J0K-1L2M-3N4O5P6Q7R8"),
                UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                BookingId = Guid.Parse("8cffde44-a077-496e-8b56-b4f64a4c472f"),
                Rating = 4,
                Comment = "Chuyên viên Văn Dũng có kiến thức chuyên môn tốt và đã đưa ra nhiều lời khuyên hữu ích về chế độ dinh dưỡng. Tôi đánh giá cao cách tiếp cận cá nhân hóa. Phòng khám hơi khó tìm nhưng nhìn chung tôi hài lòng với buổi tư vấn.",
                CreatedAt = DateTime.ParseExact("06-04-2025 13:24:18", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("06-04-2025 13:24:18", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Đại - Nhật Quang
            #region Review 7 for Booking 8
            new Review
            {
                ReviewId = Guid.Parse("E5F6G7H8-I9J0-4K1L-2M3N-4O5P6Q7R8S9"),
                UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                BookingId = Guid.Parse("4bbfc94b-1613-4950-8861-e087214a7a77"),
                Rating = 5,
                Comment = "Buổi tư vấn với bác sĩ Nhật Quang vô cùng bổ ích. Bác sĩ đã dành thời gian lắng nghe và phân tích chi tiết tình trạng sức khỏe của tôi. Những lời khuyên về thay đổi lối sống rất thiết thực và dễ áp dụng. Tôi sẽ quay lại để tư vấn thêm.",
                CreatedAt = DateTime.ParseExact("12-04-2025 14:05:37", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("12-04-2025 14:05:37", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Khanh - Quốc Duy
            #region Review 8 for Booking 9
            new Review
            {
                ReviewId = Guid.Parse("F6G7H8I9-J0K1-4L2M-3N4O-5P6Q7R8S9T0"),
                UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                BookingId = Guid.Parse("5f0f10f3-66d8-4c51-a895-8550a54ffeaf"),
                Rating = 3,
                Comment = "Chuyên viên Quốc Duy có kiến thức chuyên môn khá tốt. Tuy nhiên, buổi tư vấn bị gián đoạn vài lần do vấn đề kỹ thuật. Một số lời khuyên hữu ích nhưng tôi mong đợi được nhận thêm tài liệu chi tiết sau buổi tư vấn.",
                CreatedAt = DateTime.ParseExact("27-03-2025 15:46:32", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("27-03-2025 15:46:32", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Khanh - Thịnh
            #region Review 9 for Booking 10
            new Review
            {
                ReviewId = Guid.Parse("G7H8I9J0-K1L2-4M3N-4O5P-6Q7R8S9T0U1"),
                UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                BookingId = Guid.Parse("ef4e1ca8-b700-45cc-a48e-0307f5e1fd99"),
                Rating = 5,
                Comment = "Bác sĩ Thịnh thực sự xuất sắc! Buổi tư vấn rất chi tiết và đúng vào vấn đề của tôi. Bác sĩ đã giải thích rõ ràng về các phương pháp tập luyện phù hợp với thể trạng của tôi và đưa ra những lời khuyên hữu ích về chế độ dinh dưỡng cân bằng. Tôi cảm thấy rất tự tin sau buổi tư vấn này!",
                CreatedAt = DateTime.ParseExact("03-05-2025 12:17:55", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025 12:17:55", "dd-MM-yyyy HH:mm:ss", null),
            }
            #endregion
            );
        }
    }
}
