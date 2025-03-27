using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.ConsultantBank.Commands.CreateConsultantBank
{
    public class CreateConsultantBankCommandHandler(IConsultantBankRepository consultantBankRepository, 
        IBankRepository bankRepository, 
        IMapper mapper) : IRequestHandler<CreateConsultantBankCommand, Unit>
    {
        public async Task<Unit> Handle(CreateConsultantBankCommand request, CancellationToken cancellationToken)
        {
            var bank = await bankRepository.GetBankByBankName(request.CreateConsultantBankDTO.BankName);
            if (bank == null)
            {
                throw new Exception("Ngân hàng không tồn tại");
            }
            if(await consultantBankRepository.CheckAccountNumber(request.CreateConsultantBankDTO.AccountNumber))
            {
                throw new Exception("Số tài khoản đã tồn tại");
            }
            var newConsultantBank = mapper.Map<Domain.ConsultantBank>(request.CreateConsultantBankDTO);
            newConsultantBank.ConsultantBankId = Guid.NewGuid();
            newConsultantBank.BankId = bank.BankId;
            newConsultantBank.IsDefault = false;
            //newConsultantBank.IsVerified = false;
            newConsultantBank.Status = false;
            newConsultantBank.CreatedAt = DateTime.Now;
            newConsultantBank.UpdatedAt = DateTime.Now;
            consultantBankRepository.Add(newConsultantBank);
            await consultantBankRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
