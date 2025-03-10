using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Wallet.Commands.ChangeStatusWallet
{
    public class ChangeStatusWalletCommand : IRequest<bool>
    {
        public Guid WalletId { get; set; }
    }
}
