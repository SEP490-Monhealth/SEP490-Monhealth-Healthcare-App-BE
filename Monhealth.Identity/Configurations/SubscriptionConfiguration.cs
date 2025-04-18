using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            var userId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6");
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
                Features = ["Theo dõi chỉ số sức khỏe cơ bản\nQuản lý mục tiêu cá nhân\nTheo dõi lượng nước uống hàng ngày\nTruy cập danh sách bài tập giới hạn\nBáo cáo tiến độ hàng tuần cơ bản"],
                BookingAllowance = 0,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
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
                Features = ["Tất cả tính năng của Gói Cơ Bản\nGợi ý bữa ăn hàng ngày theo mục tiêu\nTruy cập đầy đủ thư viện bài tập\nNhận thông báo nhắc nhở theo lịch trình\nPhân tích chỉ số dinh dưỡng chi tiết"],
                BookingAllowance = 0,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
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
                Features = ["Tất cả tính năng của Gói Nâng Cao\nTruy cập danh sách chuyên viên tư vấn chọn lọc\nĐặt lịch tư vấn 1-1 với chuyên gia (3 buổi/tháng)\nNhắn tin trực tiếp với chuyên gia\nKế hoạch dinh dưỡng và tập luyện cá nhân hóa\nĐánh giá và phản hồi dịch vụ chi tiết"],
                BookingAllowance = 3,
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            }
            #endregion
            );
        }
    }
}