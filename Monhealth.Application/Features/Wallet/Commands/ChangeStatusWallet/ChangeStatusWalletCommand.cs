using MediatR;

namespace Monhealth.Application.Features.Wallet.Commands.ChangeStatusWallet
{
    public class ChangeStatusWalletCommand : IRequest<bool>
    {
        public Guid WalletId { get; set; }
    }
}
