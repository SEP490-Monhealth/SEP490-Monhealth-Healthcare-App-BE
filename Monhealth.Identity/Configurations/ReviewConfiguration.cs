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
                ReviewId = Guid.Parse("ef587932-e689-4ced-afef-6067fc9be164"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                BookingId = Guid.Parse("2816BE7A-00E3-4ACC-B7CB-28CA8F9FDD84"),
                Rating = 5,
                Comment = "Tôi rất hài lòng với buổi tư vấn của chuyên viên Văn Dũng. Anh ấy rất tận tâm và chuyên nghiệp. Tôi đã nhận được nhiều lời khuyên hữu ích về cách cải thiện sức khỏe và lối sống của mình. Kiến thức của anh ấy thật ấn tượng và cách giải thích rất dễ hiểu.",
                CreatedAt = DateTime.ParseExact("02-05-2025 17:38:22", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("02-05-2025 17:38:22", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Toàn - Nhật Quang
            #region Review 2 for Booking 3
            new Review
            {
                ReviewId = Guid.Parse("20990e10-9830-40f1-8064-c97ccbd2b832"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                BookingId = Guid.Parse("D203CDA3-84D8-4B38-A09B-15975005EA82"),
                Rating = 1,
                Comment = "Thật sự tôi rất thất vọng với buổi tư vấn này. Chuyên viên đến trễ hơn 15 phút và không chuẩn bị kỹ lưỡng. Trong suốt buổi, tôi cảm thấy như mình không được chú ý. Những câu hỏi của tôi về cách cải thiện giấc ngủ không được trả lời đầy đủ, chỉ nhận được những lời khuyên chung chung mà tôi có thể tìm thấy trên internet.",
                CreatedAt = DateTime.ParseExact("12-04-2025 16:12:45", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("12-04-2025 16:12:45", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Duy - Thế Anh
            #region Review 3 for Booking 4
            new Review
            {
                ReviewId = Guid.Parse("2b041763-88e9-414c-8f0b-fa460c5d1e12"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                BookingId = Guid.Parse("fa8f2dd7-8f5e-4da1-aa9c-64d95feeb8ed"),
                Rating = 5,
                Comment = "Bác sĩ Thế Anh rất nhiệt tình và chu đáo. Tôi cảm thấy được lắng nghe và đã nhận được những lời khuyên quý báu về chế độ ăn uống và tập luyện phù hợp với tình trạng sức khỏe của mình. Cảm ơn bác sĩ rất nhiều!",
                CreatedAt = DateTime.ParseExact("27-04-2025 10:28:33", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("27-04-2025 10:28:33", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Duy - Xuân Quang
            #region Review 4 for Booking 5
            new Review
            {
                ReviewId = Guid.Parse("5d2fc5d4-39c1-40e4-8761-54297732c10d"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                BookingId = Guid.Parse("fd79d35c-785e-4b43-a471-37272379bb1e"),
                Rating = 4,
                Comment = "Chuyên viên Xuân Quang có kiến thức chuyên môn tốt và đã tư vấn chi tiết về các vấn đề tôi đang gặp phải. Tuy nhiên, tôi cảm thấy thời gian tư vấn hơi ngắn so với mong đợi. Nhìn chung, buổi tư vấn khá hữu ích và tôi đã học được nhiều điều.",
                CreatedAt = DateTime.ParseExact("15-04-2025 11:52:08", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("15-04-2025 11:52:08", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Duy - Tiến Phát
            #region Review 5 for Booking 6
            new Review
            {
                ReviewId = Guid.Parse("05871934-60ac-413c-9db2-548430b109fb"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                BookingId = Guid.Parse("a5586882-da12-4f03-8f9f-75b9bee2ae36"),
                Rating = 5,
                Comment = "Bác sĩ Tiến Phát rất tận tâm và lắng nghe. Tôi đã nhận được phác đồ điều trị phù hợp và lời khuyên thiết thực về việc cải thiện sức khỏe. Cách bác sĩ giải thích mọi thứ rất dễ hiểu và tôi cảm thấy an tâm hơn.",
                CreatedAt = DateTime.ParseExact("20-03-2025 14:57:41", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("20-03-2025 14:57:41", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Đại - Văn Dũng
            #region Review 6 for Booking 7
            new Review
            {
                ReviewId = Guid.Parse("62cfe7ae-169d-4690-9081-d0cfad619bf3"),
                UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                BookingId = Guid.Parse("8cffde44-a077-496e-8b56-b4f64a4c472f"),
                Rating = 4,
                Comment = "Chuyên viên Văn Dũng có kiến thức chuyên môn tốt và đã đưa ra nhiều lời khuyên hữu ích về chế độ dinh dưỡng. Tôi đánh giá cao cách tiếp cận cá nhân hóa. Mặc dù phòng khám hơi khó tìm nhưng nhìn chung tôi hài lòng với buổi tư vấn.",
                CreatedAt = DateTime.ParseExact("06-04-2025 13:24:18", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("06-04-2025 13:24:18", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Đại - Nhật Quang
            #region Review 7 for Booking 8
            new Review
            {
                ReviewId = Guid.Parse("115fb75e-332e-4748-b09e-5475c714aa20"),
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
                ReviewId = Guid.Parse("fc7edb73-9074-4359-b4cf-9aee23b5db13"),
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
                ReviewId = Guid.Parse("dfbdc47f-fa5a-4e72-ad27-4bda1a672227"),
                UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                BookingId = Guid.Parse("ef4e1ca8-b700-45cc-a48e-0307f5e1fd99"),
                Rating = 5,
                Comment = "Bác sĩ Thịnh thực sự xuất sắc! Buổi tư vấn rất chi tiết và đúng vào vấn đề của tôi. Bác sĩ đã giải thích rõ ràng về các phương pháp tập luyện phù hợp với thể trạng của tôi và đưa ra những lời khuyên hữu ích về chế độ dinh dưỡng cân bằng. Tôi cảm thấy rất tự tin sau buổi tư vấn này!",
                CreatedAt = DateTime.ParseExact("03-05-2025 12:17:55", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025 12:17:55", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Toàn - Thịnh
            #region Review 10 for Booking 11
            new Review
            {
                ReviewId = Guid.Parse("874e5430-3fbe-43c2-80a4-53d30bfb4e32"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                BookingId = Guid.Parse("874e5430-3fbe-43c2-80a4-53d30bfb4e32"),
                Rating = 5,
                Comment = "Tư vấn rất hữu ích và giúp tôi cải thiện thói quen ăn uống. Tôi cảm thấy tự tin hơn khi áp dụng những lời khuyên này vào cuộc sống hàng ngày.",
                CreatedAt = DateTime.ParseExact("23-04-2025 11:23:57", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("23-04-2025 11:23:57", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Toàn - Thịnh
            #region Review 11 for Booking 12
            new Review
            {
                ReviewId = Guid.Parse("876dc22f-3df5-4188-a44b-943d6f7bd1b3"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                BookingId = Guid.Parse("876dc22f-3df5-4188-a44b-943d6f7bd1b3"),
                Rating = 4,
                Comment = "Buổi khám tim mạch rất cần thiết và tôi cảm thấy yên tâm hơn. Bác sĩ đã giải thích rõ ràng về tình trạng sức khỏe của tôi.",
                CreatedAt = DateTime.ParseExact("22-01-2025 14:20:20", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("22-01-2025 14:20:20", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Duy - Thịnh
            #region Review 12 for Booking 13
            new Review
            {
                ReviewId = Guid.Parse("c10bba32-5eb5-4dee-a38a-cb9ae944b704"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                BookingId = Guid.Parse("c10bba32-5eb5-4dee-a38a-cb9ae944b704"),
                Rating = 5,
                Comment = "Tư vấn tâm lý rất hiệu quả, tôi cảm thấy thoải mái hơn và có thể chia sẻ những điều tôi đang gặp phải.",
                CreatedAt = DateTime.ParseExact("18-02-2025 20:21:00", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("18-02-2025 20:21:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Duy - Thịnh
            #region Review 13 for Booking 14
            new Review
            {
                ReviewId = Guid.Parse("27a30bed-5e7d-4b85-b31e-ee94124946e3"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                BookingId = Guid.Parse("27a30bed-5e7d-4b85-b31e-ee94124946e3"),
                Rating = 4,
                Comment = "Kế hoạch tập luyện cá nhân hóa rất phù hợp với tôi. Tôi cảm thấy có động lực hơn để thực hiện.",
                CreatedAt = DateTime.ParseExact("08-03-2025 15:05:10", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("08-03-2025 15:05:10", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Khải - Thịnh
            #region Review 14 for Booking 15
            new Review
            {
                ReviewId = Guid.Parse("4d34146b-4d0a-43e6-bf03-bf82f8aec772"),
                UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                BookingId = Guid.Parse("4d34146b-4d0a-43e6-bf03-bf82f8aec772"),
                Rating = 5,
                Comment = "Tư vấn rất chi tiết và giúp tôi hiểu rõ hơn về sức khỏe của mình. Tôi cảm thấy tự tin hơn khi áp dụng những lời khuyên này.",
                CreatedAt = DateTime.ParseExact("16-03-2025 14:22:00", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("16-03-2025 14:22:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Khải - Thịnh
            #region Review 15 for Booking 16
            new Review
            {
                ReviewId = Guid.Parse("c0e6a488-58bf-495a-86a1-362e4df03072"),
                UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                BookingId = Guid.Parse("c0e6a488-58bf-495a-86a1-362e4df03072"),
                Rating = 4,
                Comment = "Tư vấn sức khỏe tổng quát rất hữu ích. Tôi đã nhận được những thông tin cần thiết để cải thiện sức khỏe của mình.",
                CreatedAt = DateTime.ParseExact("15-04-2025 12:45:20", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("15-04-2025 12:45:20", "dd-MM-yyyy HH:mm:ss", null),
            }
            #endregion
            );
        }
    }
}
