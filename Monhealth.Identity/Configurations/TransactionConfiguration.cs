using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasData(

            // WithdrawalRequest 1 Quang
            #region Transaction 1
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
                WalletId = Guid.Parse("3dbc8aed-a146-4b73-90f4-453bfbc2f071"),
                BookingId = null,
                WithdrawalRequestId = Guid.Parse("5cc2aef5-4eb3-49d4-82e1-146f13010b9a"),
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Withdrawal,
                OrderCode = null,
                Description = "Yêu cầu rút tiền từ tài khoản của tôi",
                Amount = 150000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("12-02-2025 12:34:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("12-02-2025 12:34:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // WithdrawalRequest 2 Thịnh
            #region Transaction 2
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                WalletId = Guid.Parse("32cd37ec-1b39-4d25-babd-6c81ef867d2f"),
                BookingId = null,
                WithdrawalRequestId = Guid.Parse("3258e138-05a5-4e03-9867-2315b661e16f"),
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Withdrawal,
                OrderCode = null,
                Description = "Xin rút tiền phục vụ cho mục đích khẩn cấp",
                Amount = 150000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("19-12-2024 11:18:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("19-12-2024 11:18:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // WithdrawalRequest 3 Thịnh
            #region Transaction 3
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                WalletId = Guid.Parse("32cd37ec-1b39-4d25-babd-6c81ef867d2f"),
                BookingId = null,
                WithdrawalRequestId = Guid.Parse("b9894913-e674-4eca-8c58-d89a435efc1d"),
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Withdrawal,
                OrderCode = null,
                Description = "Rút tiền từ tài khoản của tôi để trả nợ",
                Amount = 220000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("25-01-2025 13:57:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("25-01-2025 13:57:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // WithdrawalRequest 4 Thịnh
            #region Transaction 4
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                WalletId = Guid.Parse("32cd37ec-1b39-4d25-babd-6c81ef867d2f"),
                BookingId = null,
                WithdrawalRequestId = Guid.Parse("9224c37e-82f1-4ed9-a9d4-12eabe174d36"),
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Withdrawal,
                OrderCode = null,
                Description = "Xin rút số tiền còn lại trong tài khoản",
                Amount = 250000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("16-02-2025 22:43:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("16-02-2025 22:43:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // WithdrawalRequest 5 Thịnh
            // #region Transaction 5
            // new Transaction
            // {
            //     TransactionId = Guid.NewGuid(),
            //     UserId = null,
            //     ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
            //     WalletId = Guid.Parse("32cd37ec-1b39-4d25-babd-6c81ef867d2f"),
            //     BookingId = null,
            //     WithdrawalRequestId = Guid.Parse("1f6273e7-a96b-423d-843f-f00953f619a2"),
            //     UserSubscriptionId = null,
            //     SubscriptionId = null,
            //     TransactionType = TransactionType.Withdrawal,
            //     OrderCode = null,
            //     Description = "Rút một phần tiền từ tài khoản để sử dụng",
            //     Amount = 180000,
            //     Status = StatusTransaction.Completed,
            //     UpdatedAt = DateTime.ParseExact("03-03-2025 09:21:00", "dd-MM-yyyy HH:mm:ss", null),
            //     CreatedAt = DateTime.ParseExact("03-03-2025 09:21:00", "dd-MM-yyyy HH:mm:ss", null),
            //     CreatedBy = null,
            //     UpdatedBy = null,
            // },
            // #endregion

            // WithdrawalRequest 6 Thịnh
            // #region Transaction 6
            // new Transaction
            // {
            //     TransactionId = Guid.NewGuid(),
            //     UserId = null,
            //     ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
            //     WalletId = Guid.Parse("32cd37ec-1b39-4d25-babd-6c81ef867d2f"),
            //     BookingId = null,
            //     WithdrawalRequestId = Guid.Parse("f5628eba-2df4-479b-91e3-0377d49d81a5"),
            //     UserSubscriptionId = null,
            //     SubscriptionId = null,
            //     TransactionType = TransactionType.Withdrawal,
            //     OrderCode = null,
            //     Description = "Xin rút tiền để đáp ứng nhu cầu tài chính",
            //     Amount = 150000,
            //     Status = StatusTransaction.Completed,
            //     UpdatedAt = DateTime.ParseExact("07-04-2025 16:19:00", "dd-MM-yyyy HH:mm:ss", null),
            //     CreatedAt = DateTime.ParseExact("07-04-2025 16:19:00", "dd-MM-yyyy HH:mm:ss", null),
            //     CreatedBy = null,
            //     UpdatedBy = null,
            // },
            // #endregion

            // WithdrawalRequest 7 Thịnh
            // #region Transaction 7
            // new Transaction
            // {
            //     TransactionId = Guid.NewGuid(),
            //     UserId = null,
            //     ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
            //     WalletId = Guid.Parse("32cd37ec-1b39-4d25-babd-6c81ef867d2f"),
            //     BookingId = null,
            //     WithdrawalRequestId = Guid.Parse("86d7a91c-5c7e-4432-8fd1-b6c0cd001322"),
            //     UserSubscriptionId = null,
            //     SubscriptionId = null,
            //     TransactionType = TransactionType.Withdrawal,
            //     OrderCode = null,
            //     Description = "Yêu cầu chuyển tiền về tài khoản cá nhân của tôi",
            //     Amount = 300000,
            //     Status = StatusTransaction.Completed,
            //     UpdatedAt = DateTime.ParseExact("02-05-2025 10:26:00", "dd-MM-yyyy HH:mm:ss", null),
            //     CreatedAt = DateTime.ParseExact("02-05-2025 10:26:00", "dd-MM-yyyy HH:mm:ss", null),
            //     CreatedBy = null,
            //     UpdatedBy = null,
            // },
            // #endregion

            // WithdrawalRequest 8 Quốc Duy
            #region Transaction 8
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                WalletId = Guid.Parse("81140a5a-b05e-4ff2-b0ee-812913aeef23"),
                BookingId = null,
                WithdrawalRequestId = Guid.Parse("18d38d92-58d2-4fa3-aa5d-3c415b332161"),
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Withdrawal,
                OrderCode = null,
                Description = "Rút toàn bộ số dư trong tài khoản của tôi",
                Amount = 150000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("28-04-2025 14:41:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("28-04-2025 14:41:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // WithdrawalRequest 9 Thế Anh
            #region Transaction 9
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                WalletId = Guid.Parse("e370ae45-fa9a-4f3d-b06e-649f8caa7e43"),
                BookingId = null,
                WithdrawalRequestId = Guid.Parse("bc3a6a69-e7cf-4be7-8ce4-079f25e7d4e7"),
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Withdrawal,
                OrderCode = null,
                Description = "Đề nghị rút số tiền cần thiết ngay bây giờ",
                Amount = 100000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("10-12-2024 08:26:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("10-12-2024 08:26:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // WithdrawalRequest 10 Xuân Quang
            #region Transaction 10
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                WalletId = Guid.Parse("af37c11a-4773-4b3f-b5ad-1851ffa48feb"),
                BookingId = null,
                WithdrawalRequestId = Guid.Parse("eb449f17-520c-406a-b4cc-32caf4744d96"),
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Withdrawal,
                OrderCode = null,
                Description = "Rút tiền về tài khoản ngân hàng cá nhân",
                Amount = 321000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("23-02-2025 09:25:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("23-02-2025 09:25:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // WithdrawalRequest 11 Tiến Phát
            #region Transaction 11
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                WalletId = Guid.Parse("3f02d88c-72be-46df-abb1-5afb9023bfe0"),
                BookingId = null,
                WithdrawalRequestId = Guid.Parse("cd871471-b3dd-42a5-a501-50681d31f7f0"),
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Withdrawal,
                OrderCode = null,
                Description = "Yêu cầu chuyển tiền từ ví điện tử của tôi",
                Amount = 163000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("20-03-2025 10:47:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("20-03-2025 10:47:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // WithdrawalRequest 12 Văn Dũng
            #region Transaction 12
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                WalletId = Guid.Parse("b7d09e14-d5d7-4806-a6f7-e581f792ef1f"),
                BookingId = null,
                WithdrawalRequestId = Guid.Parse("a890a9f3-a19f-4271-af37-01f515e312a0"),
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Withdrawal,
                OrderCode = null,
                Description = "Rút tiền để phục vụ các mục đích cá nhân",
                Amount = 595000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("23-04-2025 11:46:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("23-04-2025 11:46:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // WithdrawalRequest 13 Văn Hữu Toàn Con
            #region Transaction 13
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                WithdrawalRequestId = Guid.Parse("2d802df9-28ec-405c-9533-e9407c5a9933"),
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Withdrawal,
                OrderCode = null,
                Description = "Yêu cầu rút tiền phục vụ cho dự án cá nhân",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("29-03-2025 10:28:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("29-03-2025 10:28:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 1
            #region Transaction 14
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("A0385565-B5F4-4AD3-915E-B95558C00F7D"),
                WalletId = null,
                BookingId = Guid.Parse("2816BE7A-00E3-4ACC-B7CB-28CA8F9FDD84"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 3
            #region Transaction 15
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("6BCE17D4-909F-4FAD-B125-0074793F22BD"),
                WalletId = null,
                BookingId = Guid.Parse("D203CDA3-84D8-4B38-A09B-15975005EA82"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Failed,
                UpdatedAt = DateTime.ParseExact("02-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("02-04-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 4
            #region Transaction 16
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                WalletId = null,
                BookingId = Guid.Parse("fa8f2dd7-8f5e-4da1-aa9c-64d95feeb8ed"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("28-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("28-04-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 5
            #region Transaction 17
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                WalletId = null,
                BookingId = Guid.Parse("fd79d35c-785e-4b43-a471-37272379bb1e"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("17-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("17-04-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 6
            #region Transaction 18
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                WalletId = null,
                BookingId = Guid.Parse("a5586882-da12-4f03-8f9f-75b9bee2ae36"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("21-03-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("21-03-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 7
            #region Transaction 19
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                WalletId = null,
                BookingId = Guid.Parse("8cffde44-a077-496e-8b56-b4f64a4c472f"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("07-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("07-04-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 8
            #region Transaction 20
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
                WalletId = null,
                BookingId = Guid.Parse("4bbfc94b-1613-4950-8861-e087214a7a77"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("13-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("13-04-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 9
            #region Transaction 21
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                WalletId = null,
                BookingId = Guid.Parse("5f0f10f3-66d8-4c51-a895-8550a54ffeaf"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("28-03-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("28-03-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 10
            #region Transaction 22
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                WalletId = null,
                BookingId = Guid.Parse("ef4e1ca8-b700-45cc-a48e-0307f5e1fd99"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("02-05-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("02-05-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // XXX
            // Earning booking 11
            #region Transaction 23
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                WalletId = null,
                BookingId = Guid.Parse("874e5430-3fbe-43c2-80a4-53d30bfb4e32"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("21-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("21-04-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 12
            #region Transaction 24
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                WalletId = null,
                BookingId = Guid.Parse("876dc22f-3df5-4188-a44b-943d6f7bd1b3"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("23-01-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("23-01-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 13
            #region Transaction 25
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                WalletId = null,
                BookingId = Guid.Parse("c10bba32-5eb5-4dee-a38a-cb9ae944b704"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("19-02-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("19-02-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 14
            #region Transaction 26
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                WalletId = null,
                BookingId = Guid.Parse("27a30bed-5e7d-4b85-b31e-ee94124946e3"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("09-03-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("09-03-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 15
            #region Transaction 27
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                WalletId = null,
                BookingId = Guid.Parse("4d34146b-4d0a-43e6-bf03-bf82f8aec772"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("17-03-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("17-03-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Earning booking 16
            #region Transaction 28
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = null,
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                WalletId = null,
                BookingId = Guid.Parse("c0e6a488-58bf-495a-86a1-362e4df03072"),
                WithdrawalRequestId = null,
                UserSubscriptionId = null,
                SubscriptionId = null,
                TransactionType = TransactionType.Earning,
                OrderCode = null,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = 200000,
                Status = StatusTransaction.Completed,
                UpdatedAt = DateTime.ParseExact("16-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("16-04-2025", "dd-MM-yyyy", null),
                CreatedBy = null,
                UpdatedBy = null,
            },
            #endregion

            // Nâng cấp gói Toàn
            #region Transaction 29
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = null,
                WalletId = null,
                BookingId = null,
                WithdrawalRequestId = null,
                UserSubscriptionId = Guid.Parse("539F85A5-E937-4DE4-C57A-08DD887F2CD1"),
                SubscriptionId = Guid.Parse("51789ABD-BBCC-42EF-9663-F2EA104302BD"),
                TransactionType = TransactionType.Fee,
                OrderCode = 1746083678981093,
                Description = "Thanh toán Gói Cao Cấp",
                Amount = 899000,
                Status = StatusTransaction.Completed,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            // Nâng cấp gói Khải
            #region Transaction 30
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                ConsultantId = null,
                WalletId = null,
                BookingId = null,
                WithdrawalRequestId = null,
                UserSubscriptionId = Guid.Parse("3978e53f-53e8-4650-9089-6e417858c27f"),
                SubscriptionId = Guid.Parse("51789ABD-BBCC-42EF-9663-F2EA104302BD"),
                TransactionType = TransactionType.Fee,
                OrderCode = 5375042521751054,
                Description = "Thanh toán Gói Cao Cấp",
                Amount = 899000,
                Status = StatusTransaction.Completed,
                CreatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                UpdatedBy = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
            },
            #endregion

            // Nâng cấp gói Duy
            #region Transaction 31
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                ConsultantId = null,
                WalletId = null,
                BookingId = null,
                WithdrawalRequestId = null,
                UserSubscriptionId = Guid.Parse("2ca216a2-6c36-480b-a312-5f1d8076dfcc"),
                SubscriptionId = Guid.Parse("e62b480d-16a6-4565-87fa-262870d75f68"),
                TransactionType = TransactionType.Fee,
                OrderCode = 8242629713049229,
                Description = "Thanh toán Gói Nâng Cao",
                Amount = 249000,
                Status = StatusTransaction.Completed,
                CreatedAt = DateTime.ParseExact("04-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("04-05-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                UpdatedBy = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
            }
            #endregion
            );
        }
    }
}
