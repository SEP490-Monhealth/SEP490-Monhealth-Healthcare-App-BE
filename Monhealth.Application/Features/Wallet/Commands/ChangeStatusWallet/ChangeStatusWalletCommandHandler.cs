using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Wallet.Commands.ChangeStatusWallet
{
    public class ChangeStatusWalletCommandHandler : IRequestHandler<ChangeStatusWalletCommand, bool>
    {
        private readonly IWalletRepository _walletRepository;
        public ChangeStatusWalletCommandHandler(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }
        public async Task<bool> Handle(ChangeStatusWalletCommand request, CancellationToken cancellationToken)
        {
            var wallet = await _walletRepository.GetByIdAsync(request.WalletId);
            if (wallet == null)
            {
                return false;
            }
            wallet.Status = !wallet.Status;
            _walletRepository.Update(wallet);
            await _walletRepository.SaveChangeAsync();
            return true;
        }
    }
}
