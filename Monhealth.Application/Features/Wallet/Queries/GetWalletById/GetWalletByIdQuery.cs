using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Wallet.Queries.GetWalletById
{
    public class GetWalletByIdQuery : IRequest<GetWalletByIdDTO>
    {
        public Guid WalletId { get; set; }
    }
}
