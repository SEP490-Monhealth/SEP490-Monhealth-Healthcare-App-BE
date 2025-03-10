using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Wallet.Queries.GetAllWallets
{
    public class GetAllWalletsQueryHandler : IRequestHandler<GetAllWalletsQuery, List<GetAllWalletsDTO>>
    {
        private readonly IWalletRepository _walletRepository;
        private readonly IMapper _mapper;
        public GetAllWalletsQueryHandler(IWalletRepository walletRepository, IMapper mapper)
        {
            _walletRepository = walletRepository;
            _mapper = mapper;
        }
        public async Task<List<GetAllWalletsDTO>> Handle(GetAllWalletsQuery request, CancellationToken cancellationToken)
        {
            var listWallet = await _walletRepository.GetAllAsync();
            return _mapper.Map<List<GetAllWalletsDTO>>(listWallet);
        }
    }
}
