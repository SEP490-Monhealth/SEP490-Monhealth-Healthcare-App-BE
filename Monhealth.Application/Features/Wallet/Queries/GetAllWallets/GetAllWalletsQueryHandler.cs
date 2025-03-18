using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Wallet.Queries.GetAllWallets
{
    public class GetAllWalletsQueryHandler : IRequestHandler<GetAllWalletsQuery, PageResult<GetAllWalletsDTO>>
    {
        private readonly IWalletRepository _walletRepository;
        private readonly IMapper _mapper;
        public GetAllWalletsQueryHandler(IWalletRepository walletRepository, IMapper mapper)
        {
            _walletRepository = walletRepository;
            _mapper = mapper;
        }


        async Task<PageResult<GetAllWalletsDTO>> IRequestHandler<GetAllWalletsQuery, PageResult<GetAllWalletsDTO>>.Handle(GetAllWalletsQuery request, CancellationToken cancellationToken)
        {
            var walletPaging = await _walletRepository.GetAllWalletAsync(request.Page, request.Limit);
            return new PageResult<GetAllWalletsDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(walletPaging.TotalCount / (double)request.Limit),
                TotalItems = walletPaging.TotalCount,
                Items = _mapper.Map<List<GetAllWalletsDTO>>(walletPaging.Items)
            };



        }
    }
}
