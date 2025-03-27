﻿using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Bank.Queries.GetBankById;
using Monhealth.Domain;

namespace Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankById
{
    public class GetConsultantBankByIdQueryHandler(IConsultantBankRepository consultantBankRepository, IMapper mapper) : IRequestHandler<GetConsultantBankByIdQuery, GetConsultantBankByIdDTO>
    {
        public async Task<GetConsultantBankByIdDTO> Handle(GetConsultantBankByIdQuery request, CancellationToken cancellationToken)
        {
            var consultantBank = await consultantBankRepository.GetByIdAsync(request.ConsultantBankId);
            if (consultantBank == null)
            {
                throw new Exception("Ngân hàng của tư vấn viên không tồn tại");
            }
            return mapper.Map<GetConsultantBankByIdDTO>(consultantBank);
        }
    }
}
