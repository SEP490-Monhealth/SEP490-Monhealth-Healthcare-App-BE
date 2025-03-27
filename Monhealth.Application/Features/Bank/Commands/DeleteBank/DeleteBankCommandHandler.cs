using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Bank.Commands.DeleteBank
{
    public class DeleteBankCommandHandler(IBankRepository bankRepository) : IRequestHandler<DeleteBankCommand, bool>
    {
        public async Task<bool> Handle(DeleteBankCommand request, CancellationToken cancellationToken)
        {
            var bank = await bankRepository.GetByIdAsync(request.BankId);
            if (bank == null)
            {
                return false;
            }
            bankRepository.Remove(bank);
            await bankRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
