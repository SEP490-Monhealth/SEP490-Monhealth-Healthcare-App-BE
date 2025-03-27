using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Bank.Commands.ChangeStatusBank
{
    public class ChangeStatusBankCommandHandler(IBankRepository bankRepository) : IRequestHandler<ChangeStatusBankCommand, bool>
    {
        public async Task<bool> Handle(ChangeStatusBankCommand request, CancellationToken cancellationToken)
        {
            var bank = await bankRepository.GetByIdAsync(request.BankId);
            if (bank == null)
            {
                return false;
            }
            bank.Status = !bank.Status;
            bankRepository.Update(bank);
            await bankRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
