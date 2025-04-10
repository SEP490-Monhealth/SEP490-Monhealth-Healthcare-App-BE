using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            var chat_1 = Guid.Parse("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01");
            var consultant_1 = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203");
            var user_1 = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87");
            var now = DateTime.Parse("2025-04-11T00:00:00Z");

            builder.HasData(
            #region Message 1
                new Message
                {
                    MessageId = Guid.Parse("f6a28d85-bc92-4f47-9255-bb15822ef6a1"),
                    ChatId = chat_1,
                    SenderId = user_1,
                    Content = "Chào bác sĩ, tôi cần tư vấn về chế độ ăn.",
                    IsRead = false,
                    CreatedAt = now,
                    UpdatedAt = now
                },
            #endregion

            #region Message 2
                new Message
                {
                    MessageId = Guid.Parse("b5cc9df7-16f3-4d7a-a84d-2d03dca0de10"),
                    ChatId = chat_1,
                    SenderId = consultant_1,
                    Content = "Chào bạn, bạn có thể chia sẻ thêm tình trạng sức khỏe hiện tại không?",
                    IsRead = false,
                    CreatedAt = now,
                    UpdatedAt = now
                },
            #endregion

            #region Message 3
                new Message
                {
                    MessageId = Guid.Parse("2ae31844-2cb9-4f4d-8cd1-bfb809b2d69a"),
                    ChatId = chat_1,
                    SenderId = user_1,
                    Content = "Tôi bị tiểu đường tuýp 2, hay mệt mỏi và hay khát nước.",
                    IsRead = false,
                    CreatedAt = now,
                    UpdatedAt = now
                },
            #endregion

            #region Message 4
                new Message
                {
                    MessageId = Guid.Parse("18a2f0bc-fd99-4b88-ae36-e25e4e132ba2"),
                    ChatId = chat_1,
                    SenderId = consultant_1,
                    Content = "Bạn đã đi khám và dùng thuốc điều trị nào chưa?",
                    IsRead = false,
                    CreatedAt = now,
                    UpdatedAt = now
                },
            #endregion

            #region Message 5
                new Message
                {
                    MessageId = Guid.Parse("bf1ef4a0-6b7a-4c1d-8576-3ed08e7cece4"),
                    ChatId = chat_1,
                    SenderId = user_1,
                    Content = "Tôi đang dùng Metformin theo chỉ định của bác sĩ.",
                    IsRead = false,
                    CreatedAt = now,
                    UpdatedAt = now
                },
            #endregion

            #region Message 6
                new Message
                {
                    MessageId = Guid.Parse("3e8a2b1f-7f23-465b-b92d-d591b35c76de"),
                    ChatId = chat_1,
                    SenderId = consultant_1,
                    Content = "Rất tốt. Bạn cần duy trì chế độ ăn ít tinh bột, nhiều rau xanh.",
                    IsRead = false,
                    CreatedAt = now,
                    UpdatedAt = now
                },
            #endregion

            #region Message 7
                new Message
                {
                    MessageId = Guid.Parse("882eb55e-b1ea-4f1e-9e91-f28e36e03349"),
                    ChatId = chat_1,
                    SenderId = user_1,
                    Content = "Tôi có nên kiêng hoàn toàn trái cây không?",
                    IsRead = false,
                    CreatedAt = now,
                    UpdatedAt = now
                },
            #endregion

            #region Message 8
                new Message
                {
                    MessageId = Guid.Parse("d44eafeb-d430-40e0-8673-f8a376b2bcdc"),
                    ChatId = chat_1,
                    SenderId = consultant_1,
                    Content = "Không cần kiêng hoàn toàn, bạn có thể ăn táo, bưởi, dưa leo.",
                    IsRead = false,
                    CreatedAt = now,
                    UpdatedAt = now
                },
            #endregion

            #region Message 9
                new Message
                {
                    MessageId = Guid.Parse("715b2dcf-8b1e-46aa-b16b-6e6b5242eecc"),
                    ChatId = chat_1,
                    SenderId = user_1,
                    Content = "Cảm ơn bác sĩ rất nhiều!",
                    IsRead = false,
                    CreatedAt = now,
                    UpdatedAt = now
                },
            #endregion

            #region Message 10
                new Message
                {
                    MessageId = Guid.Parse("c81d1b8a-c914-4b4b-813c-6f22623733c2"),
                    ChatId = chat_1,
                    SenderId = consultant_1,
                    Content = "Không có gì, bạn giữ sức khỏe nhé!",
                    IsRead = false,
                    CreatedAt = now,
                    UpdatedAt = now
                }
                #endregion
            );
        }
    }
}
