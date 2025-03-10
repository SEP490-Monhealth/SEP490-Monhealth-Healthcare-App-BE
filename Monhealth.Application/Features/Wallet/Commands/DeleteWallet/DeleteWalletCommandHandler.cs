using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Wallet.Commands.DeleteWallet
{
    public class DeleteWalletCommandHandler : IRequestHandler<DeleteWalletCommand, bool>
    {
        private readonly IWalletRepository _walletRepository;
        public DeleteWalletCommandHandler(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }
        public async Task<bool> Handle(DeleteWalletCommand request, CancellationToken cancellationToken)
        {
            var wallet = await _walletRepository.GetByIdAsync(request.WalletId);
            if(wallet == null)
            {
                throw new Exception("Không tìm thấy ví");
            }
            _walletRepository.Remove(wallet);
            await _walletRepository.SaveChangeAsync();
            return true;
        }
    }
}
