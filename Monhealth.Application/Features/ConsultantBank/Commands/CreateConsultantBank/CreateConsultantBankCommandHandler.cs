using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.ConsultantBank.Commands.CreateConsultantBank
{
    public class CreateConsultantBankCommandHandler(IConsultantBankRepository consultantBankRepository,
        IBankRepository bankRepository,
        IMapper mapper) : IRequestHandler<CreateConsultantBankCommand, Unit>
    {
        public async Task<Unit> Handle(CreateConsultantBankCommand request, CancellationToken cancellationToken)
        {
            var bank = await bankRepository.GetByIdAsync(request.CreateConsultantBankDTO.BankId);
            if (bank == null)
            {
                throw new Exception("Ngân hàng không tồn tại");
            }

            // Check if the account number already exists
            if (await consultantBankRepository.CheckAccountNumber(request.CreateConsultantBankDTO.AccountNumber, null))
            {
                throw new Exception("Số tài khoản đã tồn tại");
            }

            // Get the current list of banks for the consultant
            var countBanks = await consultantBankRepository.GetConsultantBankByConsultantIdAsync(request.CreateConsultantBankDTO.ConsultantId);

            // Check if the consultant has reached the limit of 5 banks
            if (countBanks.Count() >= 5)
            {
                throw new BadRequestException("Giới hạn tài khoản của bạn có thể thêm là 5");
            }

            // Map the DTO to the domain entity
            var newConsultantBank = mapper.Map<Domain.ConsultantBank>(request.CreateConsultantBankDTO);

            // If it's the first bank, set it as default
            if (countBanks.Count() == 0)
            {
                newConsultantBank.IsDefault = true;
            }
            else
            {
                // For subsequent banks, use the IsDefault value from the request
                newConsultantBank.IsDefault = request.CreateConsultantBankDTO.IsDefault;
            }

            // If it's set to default, update the existing consultant's other banks to non-default
            if (newConsultantBank.IsDefault)
            {
                await consultantBankRepository.SetDefaultBankAccountAsync(newConsultantBank.ConsultantId);
            }

            newConsultantBank.ConsultantBankId = Guid.NewGuid();
            newConsultantBank.BankId = bank.BankId;
            newConsultantBank.CreatedAt = DateTime.Now;
            newConsultantBank.UpdatedAt = DateTime.Now;

            // Add the new bank account to the repository and save changes
            consultantBankRepository.Add(newConsultantBank);
            await consultantBankRepository.SaveChangeAsync(cancellationToken);

            return Unit.Value;
        }

    }
}
