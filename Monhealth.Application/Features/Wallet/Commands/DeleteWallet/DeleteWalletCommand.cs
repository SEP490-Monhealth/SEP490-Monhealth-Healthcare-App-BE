﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Wallet.Commands.DeleteWallet
{
    public class DeleteWalletCommand : IRequest<bool>
    {
        public Guid WalletId { get; set; }
    }
}
