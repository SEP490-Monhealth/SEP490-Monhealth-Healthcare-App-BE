using Microsoft.EntityFrameworkCore;
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
                Notes = "Đặt lịch hẹn gặp chuyên viên để tư vấn về tình trạng sức khỏe",
                StartTime = TimeOnly.Parse("16:15:00"),
                EndTime = TimeOnly.Parse("17:15:00"),
                MeetingUrl = "https://meet.google.com/svv-ekkz-boz",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%201%2FMeetEvidence1.png?alt=media&token=08df4039-d923-4a8c-82b5-94355bbf8555"],
                CancellationReason = null,
                IsReviewed = true,
                CompletedAt = DateTime.ParseExact("02-05-2025", "dd-MM-yyyy", null),
                Status = BookingStatus.Completed,
                CreatedAt = DateTime.ParseExact("01-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-05-2025", "dd-MM-yyyy", null),
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
                Notes = "Hẹn gặp chuyên gia để nhận tư vấn về vấn đề sức khỏe hiện tại",
                StartTime = TimeOnly.Parse("09:15:00"),
                EndTime = TimeOnly.Parse("10:15:00"),
                MeetingUrl = "https://meet.google.com/tyn-vafz-asn",
                EvidenceUrls = [],
                CancellationReason = "Lịch hẹn của tôi cần phải hủy do thay đổi kế hoạch",
                IsReviewed = false,
                CompletedAt = null,
                Status = BookingStatus.Cancelled,
                CreatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
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
                Notes = "Đặt lịch hẹn để kiểm tra sức khỏe và nhận lời khuyên",
                StartTime = TimeOnly.Parse("15:00:00"),
                EndTime = TimeOnly.Parse("16:00:00"),
                MeetingUrl = "https://meet.google.com/sfn-wpjg-fzp",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%209%2FMeetEvidence9.jpg?alt=media&token=1e75415d-51f4-4906-b818-7ca7699a5fcb"],
                CancellationReason = null,
                IsReviewed = true,
                CompletedAt = null,
                Status = BookingStatus.Reported,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
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
                Notes = "Đặt lịch tư vấn để theo dõi sức khỏe định kỳ",
                StartTime = TimeOnly.Parse("09:00:00"),
                EndTime = TimeOnly.Parse("10:00:00"),
                MeetingUrl = "https://meet.google.com/abc-defg-hij",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%202%2FMeetEvidence2.jpg?alt=media&token=ef5723e8-9ef2-4c54-b7fd-368eec0be809"],
                CancellationReason = null,
                IsReviewed = true,
                CompletedAt = DateTime.ParseExact("27-04-2025", "dd-MM-yyyy", null),
                Status = BookingStatus.Completed,
                CreatedAt = DateTime.ParseExact("21-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("21-04-2025", "dd-MM-yyyy", null),
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
                Notes = "Hẹn gặp chuyên gia để nhận lời khuyên về chăm sóc sức khỏe cá nhân",
                StartTime = TimeOnly.Parse("10:15:00"),
                EndTime = TimeOnly.Parse("11:30:00"),
                MeetingUrl = "https://meet.google.com/pqr-stuv-wxy",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%203%2FMeetEvidence3.jpg?alt=media&token=0b3f9ea2-4dac-45ab-8d48-3dd2b768a945"],
                CancellationReason = null,
                IsReviewed = true,
                CompletedAt = DateTime.ParseExact("15-04-2025", "dd-MM-yyyy", null),
                Status = BookingStatus.Completed,
                CreatedAt = DateTime.ParseExact("10-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("10-04-2025", "dd-MM-yyyy", null),
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
                Notes = "Đặt lịch hẹn với chuyên viên để tư vấn về các biện pháp cải thiện sức khỏe",
                StartTime = TimeOnly.Parse("15:30:00"),
                EndTime = TimeOnly.Parse("14:45:00"),
                MeetingUrl = "https://meet.google.com/ghi-jklm-nop",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%204%2FMeetEvidence4.jpg?alt=media&token=0e4d43af-7e9e-41ff-ab4e-f8eb9e0a2287"],
                CancellationReason = null,
                IsReviewed = true,
                CompletedAt = DateTime.ParseExact("20-03-2025", "dd-MM-yyyy", null),
                Status = BookingStatus.Completed,
                CreatedAt = DateTime.ParseExact("18-03-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("18-03-2025", "dd-MM-yyyy", null),
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
                Notes = "Hẹn gặp để nhận tư vấn về chế độ ăn uống và lối sống lành mạnh",
                StartTime = TimeOnly.Parse("11:45:00"),
                EndTime = TimeOnly.Parse("13:00:00"),
                MeetingUrl = "https://meet.google.com/xyz-uvwx-yza",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%205%2FMeetEvidence5.jpg?alt=media&token=4242f00b-35d5-460a-9321-370e4a15ed6a"],
                CancellationReason = null,
                IsReviewed = true,
                CompletedAt = DateTime.ParseExact("06-04-2025", "dd-MM-yyyy", null),
                Status = BookingStatus.Completed,
                CreatedAt = DateTime.ParseExact("02-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("02-04-2025", "dd-MM-yyyy", null),
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
                Notes = "Đặt lịch khám sức khỏe để phát hiện sớm các bệnh lý tiềm ẩn",
                StartTime = TimeOnly.Parse("14:00:00"),
                EndTime = TimeOnly.Parse("13:15:00"),
                MeetingUrl = "https://meet.google.com/jkl-mnop-qrst",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%206%2FMeetEvidence6.jpg?alt=media&token=5d212134-e697-4b18-89e3-206c59a3882f"],
                CancellationReason = null,
                IsReviewed = true,
                CompletedAt = DateTime.ParseExact("12-04-2025", "dd-MM-yyyy", null),
                Status = BookingStatus.Completed,
                CreatedAt = DateTime.ParseExact("08-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("08-04-2025", "dd-MM-yyyy", null),
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
                Notes = "Hẹn gặp chuyên gia để được hướng dẫn cách cải thiện sức khỏe lâu dài",
                StartTime = TimeOnly.Parse("15:15:00"),
                EndTime = TimeOnly.Parse("14:30:00"),
                MeetingUrl = "https://meet.google.com/lmn-opqr-stuv",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%207%2FMeetEvidence7.jpg?alt=media&token=970579e0-e34c-40f2-84b2-d8dca6e01a02"],
                CancellationReason = null,
                IsReviewed = true,
                CompletedAt = DateTime.ParseExact("27-03-2025", "dd-MM-yyyy", null),
                Status = BookingStatus.Completed,
                CreatedAt = DateTime.ParseExact("26-03-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("26-03-2025", "dd-MM-yyyy", null),
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
                Notes = "Hẹn gặp bác sĩ để nhận tư vấn về chế độ tập luyện và thể dục phù hợp",
                StartTime = TimeOnly.Parse("10:30:00"),
                EndTime = TimeOnly.Parse("11:45:00"),
                MeetingUrl = "https://meet.google.com/abc-defg-hijk",
                EvidenceUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Fcomplete%2Fbooking%208%2FMeetEvidence8.jpg?alt=media&token=1c960cb6-2132-4c77-bef5-c97515bba1af"],
                CancellationReason = null,
                IsReviewed = true,
                CompletedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                Status = BookingStatus.Completed,
                CreatedAt = DateTime.ParseExact("01-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-05-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                UpdatedBy = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
            }
            #endregion

            );
        }
    }
}
