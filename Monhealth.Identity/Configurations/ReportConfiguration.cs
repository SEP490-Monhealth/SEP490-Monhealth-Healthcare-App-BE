using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasData(

            // Toàn - Quang
            #region Report 1 for Booking 3
            new Report
            {
                ReportId = Guid.Parse("92da7d04-4bf5-4aea-a9d7-c88f690275c8"),
                BookingId = Guid.Parse("D203CDA3-84D8-4B38-A09B-15975005EA82"),
                Reason = "Chuyên viên đến trễ hơn 15 phút so với lịch hẹn. Không có sự chuẩn bị trước về hồ sơ của tôi. Trong buổi tư vấn, chuyên viên thường xuyên kiểm tra điện thoại và tỏ ra thiếu tập trung. Các câu hỏi của tôi về cách cải thiện giấc ngủ không được trả lời đầy đủ, chỉ nhận được những lời khuyên chung chung mà tôi có thể tìm thấy trên internet. Khi tôi hỏi về các phương pháp cụ thể, chuyên viên đã đưa ra những lời khuyên không phù hợp với tình trạng sức khỏe của tôi đã nêu trong hồ sơ.",
                ImageUrls = ["https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fbookings%2Freport%2Fd203cda3-84d8-4b38-a09b-15975005ea82%2F92da7d04-4bf5-4aea-a9d7-c88f690275c8.webp?alt=media&token=140d3540-280d-4967-a9c7-d1016e20b3bd"],
                Status = StatusReport.Pending,
                CreatedAt = DateTime.ParseExact("12-04-2025 16:30:22", "dd-MM-yyyy HH:mm:ss", null),
                UpdatedAt = DateTime.ParseExact("12-04-2025 16:30:22", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B")
            }
            #endregion
            );
        }
    }
}