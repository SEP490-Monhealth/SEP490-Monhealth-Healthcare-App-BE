using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            var today = DateTime.Now;

            builder.HasData(
            #region Chat 1
            new Chat
            {
                ChatId = Guid.Parse("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01"),
                UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                LastMessage = "Tôi cần tư vấn về chế độ ăn cho người tiểu đường.",
                CreatedAt = today,
                UpdatedAt = today
            },
            #endregion

            #region Chat 2
            new Chat
            {
                ChatId = Guid.Parse("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                LastMessage = "Bạn vui lòng cung cấp thêm thông tin sức khỏe để tôi hỗ trợ tốt hơn.",
                CreatedAt = today,
                UpdatedAt = today
            },
            #endregion

            #region Chat 3
            new Chat
            {
                ChatId = Guid.Parse("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d"),
                UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                LastMessage = "Tôi muốn hẹn lịch tư vấn vào tuần sau.",
                CreatedAt = today,
                UpdatedAt = today
            }
            #endregion
            );

        }
    }
}
