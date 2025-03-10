using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Wallet.Queries.GetAllWallets
{
    public class GetAllWalletsQuery : IRequest<List<GetAllWalletsDTO>>
    {
    }
}
