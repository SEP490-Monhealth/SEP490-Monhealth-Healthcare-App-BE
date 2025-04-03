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
            var bank = await bankRepository.GetBankByBankCode(request.CreateConsultantBankDTO.BankCode);
            if (bank == null)
            {
                throw new Exception("Ngân hàng không tồn tại");
            }
            if (await consultantBankRepository.CheckAccountNumber(request.CreateConsultantBankDTO.AccountNumber, null))
            {
                throw new Exception("Số tài khoản đã tồn tại");
            }
            var countBanks = await consultantBankRepository.GetConsultantBankByConsultantIdAsync(request.CreateConsultantBankDTO.ConsultantId);
            if (countBanks.Count() >= 3)
            {
                throw new BadRequestException("Tài khoản của bạn đã thêm tối đa đủ 3");

            }
            var newConsultantBank = mapper.Map<Domain.ConsultantBank>(request.CreateConsultantBankDTO);
            if (newConsultantBank.IsDefault) //set default if true
            {
                await consultantBankRepository.SetDefaultBankAccountAsync(newConsultantBank.ConsultantId);
            }
            newConsultantBank.ConsultantBankId = Guid.NewGuid();
            newConsultantBank.BankId = bank.BankId;
            newConsultantBank.Status = false;
            newConsultantBank.CreatedAt = DateTime.Now;
            newConsultantBank.UpdatedAt = DateTime.Now;
            consultantBankRepository.Add(newConsultantBank);
            await consultantBankRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
