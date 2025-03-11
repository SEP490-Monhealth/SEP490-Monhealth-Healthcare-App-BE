using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Wallet.Queries.GetWalletById
{
    public class GetWalletByIdQueryHandler : IRequestHandler<GetWalletByIdQuery, GetWalletByIdDTO>
    {
        private readonly IWalletRepository _walletRepository;
        private readonly IMapper _mapper;
        public GetWalletByIdQueryHandler(IWalletRepository walletRepository, IMapper mapper)
        {
            _walletRepository = walletRepository;
            _mapper = mapper;
        }
        public async Task<GetWalletByIdDTO> Handle(GetWalletByIdQuery request, CancellationToken cancellationToken)
        {
            var wallet = await _walletRepository.GetByIdAsync(request.WalletId);
            if (wallet == null) throw new BadRequestException("Không tìm thấy ví");
            return _mapper.Map<GetWalletByIdDTO>(wallet);
        }
    }
}
