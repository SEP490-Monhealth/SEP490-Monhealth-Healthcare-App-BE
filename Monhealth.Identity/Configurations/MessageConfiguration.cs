using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            var chatId1 = Guid.Parse("e7a3f1bd-d891-4a79-9086-9f3e79cf8e01");
            var consultantId1 = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203");
            var userId1 = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87");

            var chatId2 = Guid.Parse("f04b47df-8e5a-4bfa-8519-0ed5f9b1c7ea");
            var userId2 = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B");
            var consultantId2 = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203");

            var chatId3 = Guid.Parse("9b4dc3a1-5076-48f0-b91d-3d964ff1aa7d");
            var userId3 = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2");
            var consultantId3 = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203");

            builder.HasData(
            #region Message 1
            new Message
            {
                MessageId = Guid.Parse("f6a28d85-bc92-4f47-9255-bb15822ef6a1"),
                ChatId = chatId1,
                SenderId = userId1,
                Content = "Chào bác sĩ, tôi cần tư vấn về chế độ ăn.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:00:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:00:08")
            },
            #endregion

            #region Message 2
            new Message
            {
                MessageId = Guid.Parse("b5cc9df7-16f3-4d7a-a84d-2d03dca0de10"),
                ChatId = chatId1,
                SenderId = consultantId1,
                Content = "Chào bạn, bạn có thể chia sẻ thêm tình trạng sức khỏe hiện tại không?",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:03:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:03:08")
            },
            #endregion

            #region Message 3
            new Message
            {
                MessageId = Guid.Parse("2ae31844-2cb9-4f4d-8cd1-bfb809b2d69a"),
                ChatId = chatId1,
                SenderId = userId1,
                Content = "Tôi bị tiểu đường tuýp 2, hay mệt mỏi và hay khát nước.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:08:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:08:44")
            },
            #endregion

            #region Message 4
            new Message
            {
                MessageId = Guid.Parse("18a2f0bc-fd99-4b88-ae36-e25e4e132ba2"),
                ChatId = chatId1,
                SenderId = consultantId1,
                Content = "Bạn đã đi khám và dùng thuốc điều trị nào chưa?",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:12:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:12:30")
            },
            #endregion

            #region Message 5
            new Message
            {
                MessageId = Guid.Parse("bf1ef4a0-6b7a-4c1d-8576-3ed08e7cece4"),
                ChatId = chatId1,
                SenderId = userId1,
                Content = "Tôi đang dùng Metformin theo chỉ định của bác sĩ.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:16:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:16:09")
            },
            #endregion

            #region Message 6
            new Message
            {
                MessageId = Guid.Parse("3e8a2b1f-7f23-465b-b92d-d591b35c76de"),
                ChatId = chatId1,
                SenderId = consultantId1,
                Content = "Rất tốt. Bạn cần duy trì chế độ ăn ít tinh bột, nhiều rau xanh.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:20:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:20:09")
            },
            #endregion

            #region Message 7
            new Message
            {
                MessageId = Guid.Parse("882eb55e-b1ea-4f1e-9e91-f28e36e03349"),
                ChatId = chatId1,
                SenderId = userId1,
                Content = "Tôi có nên kiêng hoàn toàn trái cây không?",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:12:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:12:22")
            },
            #endregion

            #region Message 8
            new Message
            {
                MessageId = Guid.Parse("d44eafeb-d430-40e0-8673-f8a376b2bcdc"),
                ChatId = chatId1,
                SenderId = consultantId1,
                Content = "Không cần kiêng hoàn toàn, bạn có thể ăn táo, bưởi, dưa leo.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:21:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:21:23")
            },
            #endregion

            #region Message 9
            new Message
            {
                MessageId = Guid.Parse("715b2dcf-8b1e-46aa-b16b-6e6b5242eecc"),
                ChatId = chatId1,
                SenderId = userId1,
                Content = "Cảm ơn bác sĩ rất nhiều!",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:16:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:16:24")
            },
            #endregion

            #region Message 10
            new Message
            {
                MessageId = Guid.Parse("c81d1b8a-c914-4b4b-813c-6f22623733c2"),
                ChatId = chatId1,
                SenderId = consultantId1,
                Content = "Không có gì, bạn giữ sức khỏe nhé!",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:45:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:45:17")
            },
            #endregion

            #region Message 11
            new Message
            {
                MessageId = Guid.Parse("fa72b480-40a3-4aa6-b0e5-fc5bd882f301"),
                ChatId = chatId2,
                SenderId = userId2,
                Content = "Chào bác sĩ, dạo này tôi bị đau đầu liên tục.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:40:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:40:34")
            },
            #endregion

            #region Message 12
            new Message
            {
                MessageId = Guid.Parse("2e345b2b-8d2e-4e9a-86f2-4fc9cb01ef02"),
                ChatId = chatId2,
                SenderId = consultantId2,
                Content = "Bạn có bị mất ngủ hoặc áp lực công việc gần đây không?",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:33:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:33:28")
            },
            #endregion

            #region Message 13
            new Message
            {
                MessageId = Guid.Parse("1fa1138e-7a18-49a5-8758-3a71e4990e03"),
                ChatId = chatId2,
                SenderId = userId2,
                Content = "Đúng vậy, tôi làm việc với máy tính cả ngày và ngủ không ngon.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:48:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:48:40")
            },
            #endregion

            #region Message 14
            new Message
            {
                MessageId = Guid.Parse("b143ba57-3e1d-4172-8c7d-818f65332104"),
                ChatId = chatId2,
                SenderId = consultantId2,
                Content = "Bạn nên nghỉ mắt sau mỗi 30 phút làm việc và tập vài động tác giãn cơ.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T09:05:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T09:05:18")
            },
            #endregion

            #region Message 15
            new Message
            {
                MessageId = Guid.Parse("ec6f49fd-cbfb-4fe3-8a1f-cc99f40f5205"),
                ChatId = chatId2,
                SenderId = userId2,
                Content = "Tôi chưa từng thử. Có cần dùng thuốc không ạ?",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:28:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:28:15")
            },
            #endregion

            #region Message 16
            new Message
            {
                MessageId = Guid.Parse("2b58be2c-20cf-439e-853e-b6ed7aa5d706"),
                ChatId = chatId2,
                SenderId = consultantId2,
                Content = "Tạm thời bạn chỉ cần thay đổi thói quen sinh hoạt. Nếu không cải thiện sau 1 tuần, hãy tái khám.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:30:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:30:17")
            },
            #endregion

            #region Message 17
            new Message
            {
                MessageId = Guid.Parse("d1b2a250-bb24-43f2-b16a-23b8f3be0e07"),
                ChatId = chatId2,
                SenderId = userId2,
                Content = "Tôi hiểu rồi, cảm ơn bác sĩ.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T09:20:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T09:20:05")
            },
            #endregion

            #region Message 18
            new Message
            {
                MessageId = Guid.Parse("6cf9b540-1ae0-41c8-9e2b-7a89e4c3fc08"),
                ChatId = chatId2,
                SenderId = consultantId2,
                Content = "Không có gì. Bạn thử áp dụng và theo dõi nhé.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:51:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:51:51")
            },
            #endregion

            #region Message 19
            new Message
            {
                MessageId = Guid.Parse("2ea02b74-96e3-4fd5-b0a0-9bb3ecb9a209"),
                ChatId = chatId2,
                SenderId = userId2,
                Content = "Tôi sẽ thử thực hiện và cập nhật lại.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T09:12:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T09:12:27")
            },
            #endregion

            #region Message 20
            new Message
            {
                MessageId = Guid.Parse("75c64f06-1427-4a2b-90a3-8571e6375810"),
                ChatId = chatId2,
                SenderId = consultantId2,
                Content = "Chúc bạn mau khỏe!",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T09:35:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T09:35:31")
            },
            #endregion

            #region Message 21
            new Message
            {
                MessageId = Guid.Parse("aff2bdf2-2dc5-4957-8e3c-0377ecba3d21"),
                ChatId = chatId3,
                SenderId = userId3,
                Content = "Chào bác sĩ, tôi thường bị chóng mặt và nhức đầu.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T09:40:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T09:40:43")
            },
            #endregion

            #region Message 22
            new Message
            {
                MessageId = Guid.Parse("e54cb8f4-b614-4a91-a962-66535378cd22"),
                ChatId = chatId3,
                SenderId = consultantId3,
                Content = "Bạn có đo huyết áp gần đây không? Kết quả là bao nhiêu?",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T09:24:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T09:24:46")
            },
            #endregion

            #region Message 23
            new Message
            {
                MessageId = Guid.Parse("ee77a54e-fd3e-47db-9bc5-317e5fdc5f23"),
                ChatId = chatId3,
                SenderId = userId3,
                Content = "Tôi đo sáng nay là 150/95.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:44:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:44:18")
            },
            #endregion

            #region Message 24
            new Message
            {
                MessageId = Guid.Parse("7b2b3b94-36f3-44c2-8e25-8f531e02c124"),
                ChatId = chatId3,
                SenderId = consultantId3,
                Content = "Đó là chỉ số cao. Bạn đã từng bị huyết áp cao chưa?",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T09:55:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T09:55:09")
            },
            #endregion

            #region Message 25
            new Message
            {
                MessageId = Guid.Parse("bb372046-86cb-4a49-bcf4-13b35fef8d25"),
                ChatId = chatId3,
                SenderId = userId3,
                Content = "Trước đây tôi chưa từng bị, gần đây mới xuất hiện.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T10:00:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T10:00:12")
            },
            #endregion

            #region Message 26
            new Message
            {
                MessageId = Guid.Parse("1852bc57-4b6d-4f45-a120-017b0b4e0c26"),
                ChatId = chatId3,
                SenderId = consultantId3,
                Content = "Bạn nên hạn chế muối, không uống rượu bia, và tập thể dục nhẹ nhàng.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:50:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:50:18")
            },
            #endregion

            #region Message 27
            new Message
            {
                MessageId = Guid.Parse("3e8973e9-e1cf-44f5-a155-55a442198e27"),
                ChatId = chatId3,
                SenderId = userId3,
                Content = "Tôi nên ăn gì để giảm huyết áp?",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:52:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:52:18")
            },
            #endregion

            #region Message 28
            new Message
            {
                MessageId = Guid.Parse("ea91e4b0-bbfc-4a9c-a73d-c3c118038528"),
                ChatId = chatId3,
                SenderId = consultantId3,
                Content = "Bạn nên ăn rau xanh, chuối, khoai lang, cá và uống nhiều nước.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T09:48:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T09:48:21")
            },
            #endregion

            #region Message 29
            new Message
            {
                MessageId = Guid.Parse("0d37e44f-d0d2-4a40-90ae-24e7e05c0f29"),
                ChatId = chatId3,
                SenderId = userId3,
                Content = "Cảm ơn bác sĩ, tôi sẽ làm theo.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T08:56:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T08:56:40")
            },
            #endregion

            #region Message 30
            new Message
            {
                MessageId = Guid.Parse("9b0151cf-c9fa-4707-96ff-4b324387cb30"),
                ChatId = chatId3,
                SenderId = consultantId3,
                Content = "Bạn theo dõi chỉ số 3 ngày tới, nếu không giảm nên đi khám sớm nhé.",
                IsRead = false,
                CreatedAt = DateTime.Parse("2025-04-10T09:56:00"),
                UpdatedAt = DateTime.Parse("2025-04-10T09:56:15")
            }
            #endregion
            );
        }
    }
}
