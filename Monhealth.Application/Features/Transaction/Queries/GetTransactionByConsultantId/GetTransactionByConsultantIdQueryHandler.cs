using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId
{
    public class GetTransactionByConsultantIdQueryHandler : IRequestHandler<GetTransactionByConsultantIdQuery, PageResult<GetTransactionByConsultantIdDTO>>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IWalletRepository _walletRepository;
        private readonly IMapper _mapper;
        public GetTransactionByConsultantIdQueryHandler(ITransactionRepository transactionRepository, IWalletRepository walletRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _walletRepository = walletRepository;
            _mapper = mapper;
        }
        public async Task<PageResult<GetTransactionByConsultantIdDTO>> Handle(GetTransactionByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            //var wallet = await _walletRepository.GetWalletByConsultantId(request.ConsultantId);
            //if (wallet == null)
            //{
            //    throw new Exception("Không tìm thấy ví");
            //}
            var getTransaction = await _transactionRepository.GetTransactionByWalletId(request.Page, request.Limit, request.ConsultantId, request.Status);
            if (getTransaction == null)
            {
                throw new Exception("Không tìm thấy giao dịch");
            }
            return new PageResult<GetTransactionByConsultantIdDTO>()
            {
                Items = _mapper.Map<List<GetTransactionByConsultantIdDTO>>(getTransaction.Items),
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(getTransaction.TotalCount / (double)request.Limit),
                TotalItems = getTransaction.TotalCount,
            };

        }
    }
}
