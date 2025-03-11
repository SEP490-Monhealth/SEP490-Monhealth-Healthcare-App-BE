﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId
{
    public class GetTransactionByConsultantIdQueryHandler : IRequestHandler<GetTransactionByConsultantIdQuery, GetTransactionByConsultantIdDTO>
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
        public async Task<GetTransactionByConsultantIdDTO> Handle(GetTransactionByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var wallet = await _walletRepository.GetWalletByConsultantId(request.ConsultantId);
            if (wallet == null)
            {
                throw new Exception("Không tìm thấy ví");
            }
            var getTransaction = await _transactionRepository.GetTransactionByWalletId(wallet.WalletId);
            if (getTransaction == null)
            {
                throw new Exception("Không tìm thấy giao dịch");
            }
            return _mapper.Map<GetTransactionByConsultantIdDTO>(getTransaction);
        }
    }
}
