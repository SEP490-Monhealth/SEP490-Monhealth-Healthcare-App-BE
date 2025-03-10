using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Wallet.Queries.GetWalletByConsultantId
{
    public class GetWalletByConsultantIdQueryHandler : IRequestHandler<GetWalletByConsultantIdQuery, GetWalletByConsultantIdDTO>
    {
        private readonly IWalletRepository _walletRepository;
        private readonly IMapper _mapper;
        public GetWalletByConsultantIdQueryHandler(IWalletRepository walletRepository, IMapper mapper)
        {
            _walletRepository = walletRepository;
            _mapper = mapper;
        }
        public async Task<GetWalletByConsultantIdDTO> Handle(GetWalletByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var wallet = await _walletRepository.GetWalletByConsultantId(request.ConsultantId);
            if (wallet == null) throw new BadRequestException("Không tìm thấy ví");
            return _mapper.Map<GetWalletByConsultantIdDTO>(wallet);
        }
    }
}
