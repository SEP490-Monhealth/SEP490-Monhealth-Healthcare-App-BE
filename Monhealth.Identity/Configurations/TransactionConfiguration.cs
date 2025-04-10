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

            #region Transaction 1
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = Guid.NewGuid(),
                TransactionType = TransactionType.Earning,
                Description = "Nạp tiền từ VNPay",
                Amount = 1000000,
                Status = StatusTransaction.Completed,
                CreatedAt = new DateTime(2025, 03, 01, 13, 50, 00),
                UpdatedAt = new DateTime(2025, 03, 24, 17, 01, 00)
            },
            #endregion

            #region Transaction 2
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Withdrawal,
                Description = "Rút tiền về ngân hàng",
                Amount = 500000,
                Status = StatusTransaction.Pending,
                CreatedAt = new DateTime(2025, 03, 04, 04, 07, 00),
                UpdatedAt = new DateTime(2025, 04, 02, 22, 56, 00)
            },
            #endregion

            #region Transaction 3
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Refund,
                Description = "Hoàn tiền do hủy lịch",
                Amount = 300000,
                Status = StatusTransaction.Failed,
                CreatedAt = new DateTime(2025, 03, 09, 23, 35, 00),
                UpdatedAt = new DateTime(2025, 03, 22, 18, 40, 00)
            },
            #endregion

            #region Transaction 4
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Free,
                Description = "Lượt sử dụng miễn phí đầu tiên",
                Amount = 0,
                Status = StatusTransaction.Completed,
                CreatedAt = new DateTime(2025, 03, 10, 17, 02, 00),
                UpdatedAt = new DateTime(2025, 04, 22, 05, 04, 00)
            },
            #endregion

            #region Transaction 5
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = Guid.NewGuid(),
                TransactionType = TransactionType.Bonus,
                Description = "Thưởng đăng ký mới",
                Amount = 200000,
                Status = StatusTransaction.Pending,
                CreatedAt = new DateTime(2025, 03, 14, 11, 58, 00),
                UpdatedAt = new DateTime(2025, 03, 13, 20, 45, 00)
            },
            #endregion

            #region Transaction 6
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Earning,
                Description = "Nạp tiền qua Momo",
                Amount = 1500000,
                Status = StatusTransaction.Failed,
                CreatedAt = new DateTime(2025, 03, 15, 03, 48, 00),
                UpdatedAt = new DateTime(2025, 03, 05, 05, 25, 00)
            },
            #endregion

            #region Transaction 7
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Withdrawal,
                Description = "Rút tiền khẩn cấp",
                Amount = 700000,
                Status = StatusTransaction.Completed,
                CreatedAt = new DateTime(2025, 03, 16, 06, 49, 00),
                UpdatedAt = new DateTime(2025, 04, 27, 03, 57, 00)
            },
            #endregion

            #region Transaction 8
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Refund,
                Description = "Hoàn tiền dịch vụ lỗi",
                Amount = 250000,
                Status = StatusTransaction.Pending,
                CreatedAt = new DateTime(2025, 03, 20, 23, 45, 00),
                UpdatedAt = new DateTime(2025, 03, 17, 21, 44, 00)
            },
            #endregion

            #region Transaction 9
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = Guid.NewGuid(),
                TransactionType = TransactionType.Free,
                Description = "Điểm danh mỗi ngày",
                Amount = 50000,
                Status = StatusTransaction.Failed,
                CreatedAt = new DateTime(2025, 03, 22, 01, 38, 00),
                UpdatedAt = new DateTime(2025, 03, 11, 10, 25, 00)
            },
            #endregion

            #region Transaction 10
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Bonus,
                Description = "Nạp từ ShopeePay",
                Amount = 600000,
                Status = StatusTransaction.Completed,
                CreatedAt = new DateTime(2025, 03, 30, 16, 19, 00),
                UpdatedAt = new DateTime(2025, 03, 09, 01, 04, 00)
            },
            #endregion

            #region Transaction 11
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Earning,
                Description = "Tặng lượt dùng miễn phí",
                Amount = 0,
                Status = StatusTransaction.Pending,
                CreatedAt = new DateTime(2025, 03, 31, 12, 01, 00),
                UpdatedAt = new DateTime(2025, 04, 23, 00, 06, 00)
            },
            #endregion

            #region Transaction 12
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Withdrawal,
                Description = "Hoàn tiền bác sĩ hủy lịch",
                Amount = 200000,
                Status = StatusTransaction.Failed,
                CreatedAt = new DateTime(2025, 04, 01, 14, 53, 00),
                UpdatedAt = new DateTime(2025, 03, 02, 21, 49, 00)
            },
            #endregion

            #region Transaction 13
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = Guid.NewGuid(),
                TransactionType = TransactionType.Refund,
                Description = "Rút định kỳ",
                Amount = 1000000,
                Status = StatusTransaction.Completed,
                CreatedAt = new DateTime(2025, 04, 01, 15, 42, 00),
                UpdatedAt = new DateTime(2025, 04, 07, 08, 21, 00)
            },
            #endregion

            #region Transaction 14
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Free,
                Description = "Tặng tiền sinh nhật",
                Amount = 100000,
                Status = StatusTransaction.Pending,
                CreatedAt = new DateTime(2025, 04, 05, 04, 40, 00),
                UpdatedAt = new DateTime(2025, 03, 19, 17, 15, 00)
            },
            #endregion

            #region Transaction 15
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Bonus,
                Description = "Nạp qua ngân hàng",
                Amount = 800000,
                Status = StatusTransaction.Failed,
                CreatedAt = new DateTime(2025, 04, 09, 05, 11, 00),
                UpdatedAt = new DateTime(2025, 04, 26, 21, 25, 00)
            },
            #endregion

            #region Transaction 16
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Earning,
                Description = "Rút tiền thường kỳ",
                Amount = 400000,
                Status = StatusTransaction.Completed,
                CreatedAt = new DateTime(2025, 04, 12, 21, 31, 00),
                UpdatedAt = new DateTime(2025, 03, 05, 23, 05, 00)
            },
            #endregion

            #region Transaction 17
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = Guid.NewGuid(),
                TransactionType = TransactionType.Withdrawal,
                Description = "Lượt khám miễn phí",
                Amount = 0,
                Status = StatusTransaction.Pending,
                CreatedAt = new DateTime(2025, 04, 18, 08, 02, 00),
                UpdatedAt = new DateTime(2025, 03, 02, 15, 35, 00)
            },
            #endregion

            #region Transaction 18
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Refund,
                Description = "Hoàn tiền do lỗi kỹ thuật",
                Amount = 180000,
                Status = StatusTransaction.Failed,
                CreatedAt = new DateTime(2025, 04, 18, 19, 51, 00),
                UpdatedAt = new DateTime(2025, 04, 27, 08, 24, 00)
            },
            #endregion

            #region Transaction 19
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Free,
                Description = "Thưởng khách hàng thân thiết",
                Amount = 300000,
                Status = StatusTransaction.Completed,
                CreatedAt = new DateTime(2025, 04, 22, 16, 43, 00),
                UpdatedAt = new DateTime(2025, 04, 14, 07, 48, 00)
            },
            #endregion

            #region Transaction 20
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
                BookingId = null,
                TransactionType = TransactionType.Bonus,
                Description = "Rút tiền hoàn tất",
                Amount = 450000,
                Status = StatusTransaction.Pending,
                CreatedAt = new DateTime(2025, 04, 24, 17, 17, 00),
                UpdatedAt = new DateTime(2025, 03, 18, 17, 50, 00)
            }
            #endregion
            );
        }
    }
}
