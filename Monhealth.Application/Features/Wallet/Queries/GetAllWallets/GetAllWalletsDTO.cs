﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Wallet.Queries.GetAllWallets
{
    public class GetAllWalletsDTO : TimeEntity
    {
        public Guid WalletId { get; set; }
        public Guid ConsultantId { get; set; }
        public float Balance { get; set; }
        public bool Status { get; set; }
    }
}
