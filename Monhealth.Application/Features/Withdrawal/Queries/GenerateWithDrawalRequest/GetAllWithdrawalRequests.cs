using MediatR;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public sealed class GetAllWithdrawalRequests : IRequest<Response>
    {
       

        public sealed record Response(
            Guid Id,
            UserDto User,
            BankAccountDto BankAccount,
            float Amount,
            string Status,
            DateTime? CreatedAt,
            ProcessedInfoDto? ProcessedInfo
        )
        {
            public static async Task<Response> FromEntity(WithDrawalRequest request)
            {
                return new(
                                    request.WithDrawalRequestId,
                                    new UserDto(
                                        request.Consultant.ConsultantId,
                                        request.Consultant.AppUser.UserName,
                                        request.Consultant.AppUser.PhoneNumber,
                                        request.Consultant.AppUser.Email,
                                        request.Consultant.Wallet?.Balance ?? 0,
                                        request.Consultant.AppUser.Avatar
                                    ),
                                    new BankAccountDto(
                                        request.Consultant.ConsultantBanks.Select(cb => cb.Bank.BankId).Distinct().First(),
                                        request.Consultant.ConsultantBanks.Select(cb => cb.Bank.BankName).Distinct().First(),
                                        request.Consultant.ConsultantBanks.Select(cb => cb.Bank.BankCode).Distinct().First(),
                                        request.Consultant.ConsultantBanks.Select(cb => cb.Bank.ShortName).Distinct().First()
                                    ),
                                    request.Amount,
                                    request.Status.ToString(),

                                    request.CreatedAt,
                                    request.CreatedAt.HasValue
                                        ? new ProcessedInfoDto(
                                            request.CreatedAt.Value,
                                            request.Consultant.Wallet.Transactions.Select(tr => tr.TransactionId).Distinct().First()
                                        )
                                        : null
                                );
            }
        }

        public record UserDto(
            Guid Id,
            string Name,
            string Email,
            string Phone,
            float Balance,
            string Avatar
        );

        public record BankAccountDto(
            Guid Id,
            string BankName,
            string BankCode,
            string AccountName
        );

        public record ProcessedInfoDto(
            DateTime ProcessedAt,
            Guid? TransactionId
        );

    }
}