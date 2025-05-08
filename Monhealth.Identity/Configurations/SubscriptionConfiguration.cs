using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            var admin = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6");
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Subscription 1
            new Subscription
            {
                SubscriptionId = Guid.Parse("9dba3bb9-d153-4490-b39e-7c889cf01759"),
                SubscriptionName = "Gói Cơ Bản",
                SubscriptionDescription = "Gói dịch vụ miễn phí với các tính năng cơ bản để theo dõi sức khỏe và dinh dưỡng",
                Price = 0,
                DurationDays = 0,
                Features = ["Theo dõi chỉ số sức khỏe cơ bản\nQuản lý mục tiêu cá nhân\nTheo dõi lượng nước uống hàng ngày\nTruy cập danh sách bài tập giới hạn\nBáo cáo tiến độ cân nặng bản thân\nNhắn tin trực tiếp với chuyên gia"],
                BookingAllowance = 0,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Subscription 2
            new Subscription
            {
                SubscriptionId = Guid.Parse("e62b480d-16a6-4565-87fa-262870d75f68"),
                SubscriptionName = "Gói Nâng Cao",
                SubscriptionDescription = "Gói dịch vụ nâng cao với đầy đủ tính năng dinh dưỡng và tập luyện cá nhân hóa",
                Price = 249000,
                DurationDays = 30,
                Features = ["Tất cả tính năng của Gói Cơ Bản\nGợi ý bữa ăn hàng ngày theo mục tiêu\nTruy cập đầy đủ thư viện bài tập\nBáo cáo dinh dưỡng hàng tuần\nĐược lên kế hoạch ăn uống hằng tuần"],
                BookingAllowance = 0,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            },
            #endregion

            #region Subscription 3
            new Subscription
            {
                SubscriptionId = Guid.Parse("51789abd-bbcc-42ef-9663-f2ea104302bd"),
                SubscriptionName = "Gói Cao Cấp",
                SubscriptionDescription = "Gói dịch vụ cao cấp bao gồm tư vấn cá nhân từ chuyên gia dinh dưỡng và thể hình",
                Price = 899000,
                DurationDays = 30,
                Features = ["Tất cả tính năng của Gói Nâng Cao\nĐặt lịch tư vấn 1-1 với chuyên gia (3 buổi/tháng)\nKế hoạch dinh dưỡng cá nhân hóa\nNhận lời khuyên từ trợ lý dinh dưỡng\nĐánh giá và phản hồi lịch hẹn chi tiết"],
                BookingAllowance = 3,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin,
            }
            #endregion
            );
        }
    }
}