using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class WithdrawalRequestConfiguration : IEntityTypeConfiguration<WithdrawalRequest>
    {
        public void Configure(EntityTypeBuilder<WithdrawalRequest> builder)
        {

            builder.HasData(

            // Nhật Quang 
            #region WithdrawalRequest 1  
            new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.Parse("5cc2aef5-4eb3-49d4-82e1-146f13010b9a"),
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
                ConsultantBankId = Guid.Parse("fe306f4c-7da1-473d-864a-20f3c257d616"),
                Description = "Yêu cầu rút tiền từ tài khoản của tôi",
                Reason = "",
                Amount = 150000,
                Status = WithdrawalStatus.Approved,
                UpdatedAt = DateTime.ParseExact("11-02-2025 14:30:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("11-02-2025 14:30:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Thịnh
            #region WithdrawalRequest 2
            new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.Parse("3258e138-05a5-4e03-9867-2315b661e16f"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ConsultantBankId = Guid.Parse("fe2e2e1c-6ac2-4732-a72a-78438b23328a"),
                Description = "Xin rút tiền phục vụ cho mục đích khẩn cấp",
                Reason = "",
                Amount = 150000,
                Status = WithdrawalStatus.Approved,
                UpdatedAt = DateTime.ParseExact("17-12-2024 15:24:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("17-12-2024 15:24:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Thịnh
            #region WithdrawalRequest 3
            new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.Parse("b9894913-e674-4eca-8c58-d89a435efc1d"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ConsultantBankId = Guid.Parse("fe2e2e1c-6ac2-4732-a72a-78438b23328a"),
                Description = "Rút tiền từ tài khoản của tôi để trả nợ",
                Reason = "",
                Amount = 220000,
                Status = WithdrawalStatus.Approved,
                UpdatedAt = DateTime.ParseExact("22-01-2025 16:43:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("22-01-2025 16:43:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Thịnh
            #region WithdrawalRequest 4  
            new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.Parse("9224c37e-82f1-4ed9-a9d4-12eabe174d36"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ConsultantBankId = Guid.Parse("fe2e2e1c-6ac2-4732-a72a-78438b23328a"),
                Description = "Xin rút số tiền còn lại trong tài khoản",
                Reason = "",
                Amount = 250000,
                Status = WithdrawalStatus.Approved,
                UpdatedAt = DateTime.ParseExact("15-02-2025 17:10:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("15-02-2025 17:10:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Thịnh
            // #region WithdrawalRequest 5 
            // new WithdrawalRequest
            // {
            //     WithdrawalRequestId = Guid.Parse("1f6273e7-a96b-423d-843f-f00953f619a2"),
            //     ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
            //     ConsultantBankId = Guid.Parse("a25001e8-ebd3-476e-bea2-c816709236bc"),
            //     Description = "Rút một phần tiền từ tài khoản để sử dụng",
            //     Reason = "",
            //     Amount = 180000,
            //     Status = WithdrawalStatus.Approved,
            //     UpdatedAt = DateTime.ParseExact("02-03-2025 07:10:00", "dd-MM-yyyy HH:mm:ss", null),
            //     CreatedAt = DateTime.ParseExact("02-03-2025 07:10:00", "dd-MM-yyyy HH:mm:ss", null),
            // },
            // #endregion

            // Thịnh
            // #region WithdrawalRequest 6
            // new WithdrawalRequest
            // {
            //     WithdrawalRequestId = Guid.Parse("f5628eba-2df4-479b-91e3-0377d49d81a5"),
            //     ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
            //     ConsultantBankId = Guid.Parse("a25001e8-ebd3-476e-bea2-c816709236bc"),
            //     Description = "Xin rút tiền để đáp ứng nhu cầu tài chính",
            //     Reason = "",
            //     Amount = 150000,
            //     Status = WithdrawalStatus.Approved,
            //     UpdatedAt = DateTime.ParseExact("06-04-2025 15:22:00", "dd-MM-yyyy HH:mm:ss", null),
            //     CreatedAt = DateTime.ParseExact("06-04-2025 15:22:00", "dd-MM-yyyy HH:mm:ss", null),
            // },
            // #endregion

            // Thịnh
            // #region WithdrawalRequest 7 
            // new WithdrawalRequest
            // {
            //     WithdrawalRequestId = Guid.Parse("86d7a91c-5c7e-4432-8fd1-b6c0cd001322"),
            //     ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
            //     ConsultantBankId = Guid.Parse("a25001e8-ebd3-476e-bea2-c816709236bc"),
            //     Description = "Yêu cầu chuyển tiền về tài khoản cá nhân của tôi",
            //     Reason = "",
            //     Amount = 300000,
            //     Status = WithdrawalStatus.Approved,
            //     UpdatedAt = DateTime.ParseExact("01-05-2025 09:37:00", "dd-MM-yyyy HH:mm:ss", null),
            //     CreatedAt = DateTime.ParseExact("01-05-2025 09:37:00", "dd-MM-yyyy HH:mm:ss", null),
            // },
            // #endregion

            // Quốc Duy
            #region WithdrawalRequest 8 
            new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.Parse("18d38d92-58d2-4fa3-aa5d-3c415b332161"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                ConsultantBankId = Guid.Parse("e86bb212-33bc-4ab5-8585-cd5b596b5af6"),
                Description = "Rút toàn bộ số dư trong tài khoản của tôi",
                Reason = "",
                Amount = 150000,
                Status = WithdrawalStatus.Approved,
                UpdatedAt = DateTime.ParseExact("27-04-2025 11:23:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("27-04-2025 11:23:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Thế Anh
            #region WithdrawalRequest 9 
            new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.Parse("bc3a6a69-e7cf-4be7-8ce4-079f25e7d4e7"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ConsultantBankId = Guid.Parse("69a0ff4b-b075-4bcd-8d32-e5d8319c622c"),
                Description = "Đề nghị rút số tiền cần thiết ngay bây giờ",
                Reason = "",
                Amount = 100000,
                Status = WithdrawalStatus.Approved,
                UpdatedAt = DateTime.ParseExact("09-12-2024 09:39:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("09-12-2024 09:39:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Xuân Quang
            #region WithdrawalRequest 10 
            new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.Parse("eb449f17-520c-406a-b4cc-32caf4744d96"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                ConsultantBankId = Guid.Parse("9d2ec54d-f40a-4fde-a887-8a8c67665cab"),
                Description = "Rút tiền về tài khoản ngân hàng cá nhân",
                Reason = "",
                Amount = 321000,
                Status = WithdrawalStatus.Approved,
                UpdatedAt = DateTime.ParseExact("22-02-2025 18:44:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("22-02-2025 18:44:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Tiến Phát
            #region WithdrawalRequest 11  
            new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.Parse("cd871471-b3dd-42a5-a501-50681d31f7f0"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                ConsultantBankId = Guid.Parse("3b958470-905a-4de2-9fcd-b813b75737cf"),
                Description = "Yêu cầu chuyển tiền từ ví điện tử của tôi",
                Reason = "",
                Amount = 163000,
                Status = WithdrawalStatus.Approved,
                UpdatedAt = DateTime.ParseExact("19-03-2025 07:55:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("19-03-2025 07:55:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Văn Dũng
            #region WithdrawalRequest 12 
            new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.Parse("a890a9f3-a19f-4271-af37-01f515e312a0"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ConsultantBankId = Guid.Parse("641d30de-59b8-41ec-95f2-bbea2b868367"),
                Description = "Rút tiền để phục vụ các mục đích cá nhân",
                Reason = "",
                Amount = 595000,
                Status = WithdrawalStatus.Approved,
                UpdatedAt = DateTime.ParseExact("22-04-2025 18:22:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("22-04-2025 18:22:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Van Huu Toan Con
            #region WithdrawalRequest 13 
            new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.Parse("2d802df9-28ec-405c-9533-e9407c5a9933"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                ConsultantBankId = Guid.Parse("952d2f64-b4e9-4895-81aa-89e60275e956"),
                Description = "Yêu cầu rút tiền phục vụ cho dự án cá nhân",
                Reason = "",
                Amount = 200000,
                Status = WithdrawalStatus.Approved,
                UpdatedAt = DateTime.ParseExact("28-03-2025 21:19:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("28-03-2025 21:19:00", "dd-MM-yyyy HH:mm:ss", null),
            },
            #endregion

            // Van Huu Toan Con
            #region WithdrawalRequest 14 
            new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.Parse("d8e947f2-9e1a-4240-9ce8-5d12e73492bb"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                ConsultantBankId = Guid.Parse("268c10f3-4054-4bc2-ac32-e2c402e2f981"),
                Description = "Rút số tiền cần thiết để thanh toán hóa đơn",
                Reason = "Rất tiếc, yêu cầu rút tiền của bạn không thể thực hiện tại thời điểm này",
                Amount = 120000,
                Status = WithdrawalStatus.Rejected,
                UpdatedAt = DateTime.ParseExact("12-04-2025 12:21:00", "dd-MM-yyyy HH:mm:ss", null),
                CreatedAt = DateTime.ParseExact("12-04-2025 12:21:00", "dd-MM-yyyy HH:mm:ss", null),
            }
            #endregion
            );
        }
    }
}
