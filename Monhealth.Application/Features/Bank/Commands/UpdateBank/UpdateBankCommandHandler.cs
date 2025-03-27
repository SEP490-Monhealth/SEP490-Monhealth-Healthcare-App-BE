using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Bank.Commands.UpdateBank
{
    public class UpdateBankCommandHandler(IBankRepository bankRepository, IMapper mapper) : IRequestHandler<UpdateBankCommand, bool>
    {
        public async Task<bool> Handle(UpdateBankCommand request, CancellationToken cancellationToken)
        {
            var checkBankName = await bankRepository.CheckBankNameExisted(request.UpdateBankDTO.BankName);
            if (checkBankName != null)
            {
                throw new Exception("Tên ngân hàng đã tồn tại");
            }
            var bank = await bankRepository.GetByIdAsync(request.BankId);
            if(bank == null)
            {
                return false;
            }
            var bankToUpdate = mapper.Map(request.UpdateBankDTO, bank);
            bankToUpdate.UpdatedAt = DateTime.Now;
            bankRepository.Update(bankToUpdate);
            await bankRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
