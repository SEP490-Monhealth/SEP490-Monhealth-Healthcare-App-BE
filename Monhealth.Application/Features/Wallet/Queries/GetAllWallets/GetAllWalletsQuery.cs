using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Wallet.Queries.GetAllWallets
{
    public class GetAllWalletsQuery : IRequest<PageResult<GetAllWalletsDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }

    }
}
