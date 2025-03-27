using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Bank.Commands.UpdateBank
{
    public class UpdateBankCommandHandler(IBankRepository bankRepository, IMapper mapper) : IRequestHandler<UpdateBankCommand, bool>
    {
        public async Task<bool> Handle(UpdateBankCommand request, CancellationToken cancellationToken)
        {
            if (await bankRepository.CheckBankNameExisted(request.UpdateBankDTO.BankName))
            {
                throw new Exception("Tên ngân hàng đã tồn tại");
            }

            if (await bankRepository.CheckBankCodeExisted(request.UpdateBankDTO.BankCode))
            {
                throw new Exception("Mã ngân hàng đã tồn tại");
            }

            if (await bankRepository.CheckShortNameExisted(request.UpdateBankDTO.ShortName))
            {
                throw new Exception("Tên viết tắt của ngân hàng đã tồn tại");
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
