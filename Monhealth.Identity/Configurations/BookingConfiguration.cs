﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasData(

            // Toàn - Văn Dũng
            #region Booking 1
            new Booking
            {
                BookingId = Guid.Parse("2816BE7A-00E3-4ACC-B7CB-28CA8F9FDD84"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("A0385565-B5F4-4AD3-915E-B95558C00F7D"),
                Day = DateOnly.Parse("2025-05-01"),
                Notes = "Gần đây tôi cảm thấy mệt mỏi và không biết lý do. Hy vọng bác sĩ có thể giúp tôi tìm ra nguyên nhân và cách cải thiện tình trạng này.",
                StartTime = TimeOnly.Parse("16:15:00"),
                EndTime = TimeOnly.Parse("17:15:00"),
                MeetingUrl = "https://meet.google.com/svv-ekkz-boz",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%201%2FMeetEvidence1.png?alt=media&token=08df4039-d923-4a8c-82b5-94355bbf8555"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("02-05-2025 17:30:12", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("01-05-2025 09:23:45", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("01-05-2025 09:23:45", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            // Toàn - Thịnh 
            #region Booking 2
            new Booking
            {
                BookingId = Guid.Parse("9C347A04-4581-4F92-BCB0-64C421E3EEE2"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("0A9DAD22-7B87-408B-A377-71DBBE004ABC"),
                Day = DateOnly.Parse("2025-05-05"),
                Notes = "Tôi thường xuyên bị đau đầu và cần một cuộc tư vấn sớm trước khi đi công tác. Mong bác sĩ có thể giúp tôi tìm ra giải pháp.",
                StartTime = TimeOnly.Parse("09:15:00"),
                EndTime = TimeOnly.Parse("10:15:00"),
                MeetingUrl = "https://meet.google.com/tyn-vafz-asn",
                EvidenceUrls = [],
                CancellationReason = "Rất tiếc, tôi có việc đột xuất và không thể tham gia. Xin hẹn lại sau.",
                IsReviewed = false,
                Status = BookingStatus.Cancelled,
                CompletedAt = null,
                CreatedAt = DateTime.ParseExact("03-05-2025 14:08:32", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025 18:15:47", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            // Toàn - Quang
            #region Booking 3
            new Booking
            {
                BookingId = Guid.Parse("D203CDA3-84D8-4B38-A09B-15975005EA82"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("6BCE17D4-909F-4FAD-B125-0074793F22BD"),
                Day = DateOnly.Parse("2025-04-12"),
                Notes = "Tôi đã gặp khó khăn trong việc ngủ trong vài tuần qua. Hy vọng bác sĩ có thể tư vấn cho tôi những cách tự nhiên để cải thiện giấc ngủ.",
                StartTime = TimeOnly.Parse("15:00:00"),
                EndTime = TimeOnly.Parse("16:00:00"),
                MeetingUrl = "https://meet.google.com/sfn-wpjg-fzp",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%209%2FMeetEvidence9.jpg?alt=media&token=1e75415d-51f4-4906-b818-7ca7699a5fcb"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Reported,
                CompletedAt = null,
                CreatedAt = DateTime.ParseExact("01-04-2025 20:47:22", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025 20:47:22", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            // Duy - Thế Anh
            #region Booking 4
            new Booking
            {
                BookingId = Guid.Parse("fa8f2dd7-8f5e-4da1-aa9c-64d95feeb8ed"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                Day = DateOnly.Parse("2025-04-23"),
                Notes = "Tôi mới bắt đầu tập gym và cảm thấy đau cơ. Mong bác sĩ có thể hướng dẫn tôi cách tập luyện đúng cách.",
                StartTime = TimeOnly.Parse("09:00:00"),
                EndTime = TimeOnly.Parse("10:00:00"),
                MeetingUrl = "https://meet.google.com/abc-defg-hij",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%202%2FMeetEvidence2.jpg?alt=media&token=ef5723e8-9ef2-4c54-b7fd-368eec0be809"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("27-04-2025 09:55:18", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("21-04-2025 16:30:29", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("21-04-2025 16:30:29", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                UpdatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
            },
            #endregion

            // Duy - Xuân Quang
            #region Booking 5
            new Booking
            {
                BookingId = Guid.Parse("fd79d35c-785e-4b43-a471-37272379bb1e"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                Day = DateOnly.Parse("2025-04-11"),
                Notes = "Tôi đang tìm kiếm một chế độ ăn kiêng hiệu quả để giảm cân. Đã thử nhiều cách nhưng chưa thấy kết quả như mong muốn.",
                StartTime = TimeOnly.Parse("10:15:00"),
                EndTime = TimeOnly.Parse("11:30:00"),
                MeetingUrl = "https://meet.google.com/pqr-stuv-wxy",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%203%2FMeetEvidence3.jpg?alt=media&token=0b3f9ea2-4dac-45ab-8d48-3dd2b768a945"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("15-04-2025 11:25:37", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("10-04-2025 08:12:44", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("10-04-2025 08:12:44", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                UpdatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
            },
            #endregion

            // Duy - Tiến Phát
            #region Booking 6
            new Booking
            {
                BookingId = Guid.Parse("a5586882-da12-4f03-8f9f-75b9bee2ae36"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                Day = DateOnly.Parse("2025-03-19"),
                Notes = "Tôi thường bị đau lưng khi ngồi làm việc lâu. Mong bác sĩ có thể tư vấn cho tôi những bài tập và cách chọn ghế ngồi phù hợp.",
                StartTime = TimeOnly.Parse("15:30:00"),
                EndTime = TimeOnly.Parse("14:45:00"),
                MeetingUrl = "https://meet.google.com/ghi-jklm-nop",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%204%2FMeetEvidence4.jpg?alt=media&token=0e4d43af-7e9e-41ff-ab4e-f8eb9e0a2287"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("20-03-2025 14:40:52", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("18-03-2025 21:03:18", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("18-03-2025 21:03:18", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                UpdatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
            },
            #endregion

            // Đại - Văn Dũng
            #region Booking 7
            new Booking
            {
                BookingId = Guid.Parse("8cffde44-a077-496e-8b56-b4f64a4c472f"),
                UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                Day = DateOnly.Parse("2025-04-05"),
                Notes = "Tôi muốn tìm hiểu về chế độ ăn uống lành mạnh cho người tập thể thao. Tôi tập 4 buổi mỗi tuần và cần lời khuyên từ bác sĩ.",
                StartTime = TimeOnly.Parse("11:45:00"),
                EndTime = TimeOnly.Parse("13:00:00"),
                MeetingUrl = "https://meet.google.com/xyz-uvwx-yza",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%205%2FMeetEvidence5.jpg?alt=media&token=4242f00b-35d5-460a-9321-370e4a15ed6a"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("06-04-2025 12:57:23", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("02-04-2025 17:33:09", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("02-04-2025 17:33:09", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                UpdatedBy = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
            },
            #endregion

            // Đại - Nhật Quang
            #region Booking 8
            new Booking
            {
                BookingId = Guid.Parse("4bbfc94b-1613-4950-8861-e087214a7a77"),
                UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
                Day = DateOnly.Parse("2025-04-11"),
                Notes = "Gần đây tôi hay bị đau dạ dày sau khi ăn cay. Mong bác sĩ có thể tư vấn cho tôi chế độ ăn phù hợp để cải thiện tình trạng này.",
                StartTime = TimeOnly.Parse("14:00:00"),
                EndTime = TimeOnly.Parse("13:15:00"),
                MeetingUrl = "https://meet.google.com/jkl-mnop-qrst",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%206%2FMeetEvidence6.jpg?alt=media&token=5d212134-e697-4b18-89e3-206c59a3882f"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("12-04-2025 13:11:45", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("08-04-2025 07:29:13", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("08-04-2025 07:29:13", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                UpdatedBy = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
            },
            #endregion

            // Khanh - Quốc Duy
            #region Booking 9
            new Booking
            {
                BookingId = Guid.Parse("5f0f10f3-66d8-4c51-a895-8550a54ffeaf"),
                UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                Day = DateOnly.Parse("2025-03-26"),
                Notes = "Tôi đang cảm thấy căng thẳng kéo dài do công việc và rất khó để thư giãn. Mong bác sĩ có thể giúp tôi tìm cách giải tỏa stress.",
                StartTime = TimeOnly.Parse("15:15:00"),
                EndTime = TimeOnly.Parse("14:30:00"),
                MeetingUrl = "https://meet.google.com/lmn-opqr-stuv",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%207%2FMeetEvidence7.jpg?alt=media&token=970579e0-e34c-40f2-84b2-d8dca6e01a02"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("27-03-2025 15:28:57", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("26-03-2025 10:44:32", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("26-03-2025 10:44:32", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                UpdatedBy = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
            },
            #endregion

            // Khanh - Thịnh
            #region Booking 10
            new Booking
            {
                BookingId = Guid.Parse("ef4e1ca8-b700-45cc-a48e-0307f5e1fd99"),
                UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                Day = DateOnly.Parse("2025-05-02"),
                Notes = "Tôi vừa phục hồi sau chấn thương đầu gối và cần tư vấn về các bài tập nhẹ nhàng để không làm tổn thương thêm.",
                StartTime = TimeOnly.Parse("10:30:00"),
                EndTime = TimeOnly.Parse("11:45:00"),
                MeetingUrl = "https://meet.google.com/abc-defg-hijk",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%208%2FMeetEvidence8.jpg?alt=media&token=1c960cb6-2132-4c77-bef5-c97515bba1af"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("03-05-2025 11:42:18", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("01-05-2025 19:05:47", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("01-05-2025 19:05:47", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                UpdatedBy = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
            },
            #endregion

            // Toàn - Thịnh
            #region Booking 11
            new Booking
            {
                BookingId = Guid.Parse("874e5430-3fbe-43c2-80a4-53d30bfb4e32"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                Day = DateOnly.Parse("2025-04-22"),
                Notes = "Tôi đang tìm kiếm một tư vấn dinh dưỡng để cải thiện thói quen ăn uống của mình. Hy vọng bác sĩ có thể giúp tôi xây dựng một kế hoạch ăn uống hợp lý.",
                StartTime = TimeOnly.Parse("09:45:00"),
                EndTime = TimeOnly.Parse("10:45:00"),
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%201%2FMeetEvidence1.png?alt=media&token=08df4039-d923-4a8c-82b5-94355bbf8555"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("23-12-2025 11:23:57", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("21-04-2025 12:28:57", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("21-04-2025 12:28:57", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            // Toàn - Thịnh
            #region Booking 12
            new Booking
            {
                BookingId = Guid.Parse("876dc22f-3df5-4188-a44b-943d6f7bd1b3"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                Day = DateOnly.Parse("2025-01-20"),
                Notes = "Tôi muốn hẹn khám tim mạch để kiểm tra huyết áp và nhịp tim định kỳ. Cảm thấy cần thiết để theo dõi sức khỏe của mình.",
                StartTime = TimeOnly.Parse("11:30:00"),
                EndTime = TimeOnly.Parse("12:45:00"),
                MeetingUrl = "https://meet.google.com/efg-hijk-lmn",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%209%2FMeetEvidence9.jpg?alt=media&token=1e75415d-51f4-4906-b818-7ca7699a5fcb"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("22-01-2025 14:20:20", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("19-01-2025 17:50:11", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("19-01-2025 17:50:11", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            // Duy - Thịnh
            #region Booking 13
            new Booking
            {
                BookingId = Guid.Parse("c10bba32-5eb5-4dee-a38a-cb9ae944b704"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                Day = DateOnly.Parse("2025-02-17"),
                Notes = "Tôi đang cảm thấy căng thẳng và muốn gặp chuyên gia tâm lý để tìm cách kiểm soát cảm xúc tốt hơn.",
                StartTime = TimeOnly.Parse("15:15:00"),
                EndTime = TimeOnly.Parse("16:30:00"),
                MeetingUrl = "https://meet.google.com/opq-rstu-vwx",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%202%2FMeetEvidence2.jpg?alt=media&token=ef5723e8-9ef2-4c54-b7fd-368eec0be809"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("18-02-2025 20:21:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("16-02-2025 09:31:01", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("16-02-2025 09:31:01", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                UpdatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
            },
            #endregion

            // Duy - Thịnh
            #region Booking 14
            new Booking
            {
                BookingId = Guid.Parse("27a30bed-5e7d-4b85-b31e-ee94124946e3"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                Day = DateOnly.Parse("2025-03-07"),
                Notes = "Tôi cần một kế hoạch tập luyện cá nhân hóa để phù hợp với thể trạng của mình. Hy vọng chuyên viên có thể giúp tôi.",
                StartTime = TimeOnly.Parse("12:30:00"),
                EndTime = TimeOnly.Parse("13:45:00"),
                MeetingUrl = "https://meet.google.com/yza-bcde-fgh",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%203%2FMeetEvidence3.jpg?alt=media&token=0b3f9ea2-4dac-45ab-8d48-3dd2b768a945"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("08-03-2025 15:05:10", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("05-03-2025 16:22:15", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("05-03-2025 16:22:15", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                UpdatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
            },
            #endregion

            // Khải - Thịnh
            #region Booking 15
            new Booking
            {
                BookingId = Guid.Parse("4d34146b-4d0a-43e6-bf03-bf82f8aec772"),
                UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                Day = DateOnly.Parse("2025-03-15"),
                Notes = "Tôi muốn khám chức năng gan thận và cần tư vấn phòng ngừa bệnh nguy hại. Cảm thấy cần thiết để theo dõi sức khỏe của mình.",
                StartTime = TimeOnly.Parse("14:15:00"),
                EndTime = TimeOnly.Parse("15:15:00"),
                MeetingUrl = "https://meet.google.com/hij-klmn-opq",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%204%2FMeetEvidence4.jpg?alt=media&token=0e4d43af-7e9e-41ff-ab4e-f8eb9e0a2287"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("16-03-2025 14:22:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("12-03-2025 08:45:20", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("12-03-2025 08:45:20", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                UpdatedBy = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
            },
            #endregion

            // Khải - Thịnh
            #region Booking 16
            new Booking
            {
                BookingId = Guid.Parse("c0e6a488-58bf-495a-86a1-362e4df03072"),
                UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                Day = DateOnly.Parse("2025-04-13"),
                Notes = "Tôi muốn có một buổi tư vấn sức khỏe tổng quát để thiết lập mục tiêu dài hạn cho sức khỏe của mình. Cần một kế hoạch rõ ràng để theo dõi.",
                StartTime = TimeOnly.Parse("16:00:00"),
                EndTime = TimeOnly.Parse("17:00:00"),
                MeetingUrl = "https://meet.google.com/rst-uvwx-yza",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%205%2FMeetEvidence5.jpg?alt=media&token=4242f00b-35d5-460a-9321-370e4a15ed6a"],
                CancellationReason = null,
                IsReviewed = true,
                Status = BookingStatus.Completed,
                CompletedAt = DateTime.ParseExact("15-04-2025 12:45:20", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("11-04-2025 15:52:27", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("11-04-2025 15:52:27", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                UpdatedBy = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
            }
            #endregion
            );
        }
    }
}
