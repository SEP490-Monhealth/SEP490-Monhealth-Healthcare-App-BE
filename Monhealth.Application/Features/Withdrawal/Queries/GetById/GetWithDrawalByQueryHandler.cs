using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetWithdrawalByQueryHandler(IWithdrawalRepository withdrawalRepository,
    IConsultantRepository consultantRepository,
    IConsultantBankRepository consultantBankRepository
    ) : IRequestHandler<GetWithdrawalByIdQuery, GetWithdrawalByIdDTO>
    {
        public async Task<GetWithdrawalByIdDTO> Handle(GetWithdrawalByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await withdrawalRepository.GetByIdAsync(request.WithdrawalRequestId);
            var consultant = await consultantRepository.GetConsultantById(query.ConsultantId);
            var consultantBank = await consultantBankRepository.GetConsultantBankById(query.ConsultantBankId);
            if (query == null) throw new Exception($"không tìm thấy id: {query}");
            return new GetWithdrawalByIdDTO
            {
                WithdrawalRequestId = query.WithdrawalRequestId,
                ConsultantId = query.ConsultantId,
                ConsultantBankId = query.ConsultantBankId,
                Consultant = new ConsultantDTOForId
                {
                    AvatarUrl = consultant?.AppUser?.Avatar ?? "",
                    Email = consultant?.AppUser?.Email ?? "",
                    FullName = consultant?.AppUser?.FullName ?? "",
                    PhoneNumber = consultant?.AppUser?.PhoneNumber ?? ""
                },
                ConsultantBank = new ConsultantBankDto
                {
                    AccountName = consultantBank?.AccountName ?? "",
                    AccountNumber = consultantBank?.AccountNumber ?? "",
                },
                ConsultantBankInformation = new ConsultantBankInformation
                {
                    BankName = consultantBank?.Bank?.BankName ?? "",
                    ShortName = consultantBank?.Bank?.ShortName ?? "",
                    LogoUrl = consultantBank?.Bank?.LogoUrl ?? ""
                },
                Description = query.Description,
                Amount = query.Amount,
                Status = query.Status,
                CreatedAt = query.CreatedAt,
                UpdatedAt = query.UpdatedAt,
            };
        }
    }
}