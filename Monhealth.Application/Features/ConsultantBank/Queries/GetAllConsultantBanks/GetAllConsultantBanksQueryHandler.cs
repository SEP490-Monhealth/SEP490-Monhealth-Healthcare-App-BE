using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Bank.Queries.GetAllBanks;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.ConsultantBank.Queries.GetAllConsultantBanks
{
    internal class GetAllConsultantBanksQueryHandler(IConsultantBankRepository consultantBankRepository, IMapper mapper) : IRequestHandler<GetAllConsultantBanksQuery, PageResult<GetAllConsultantBanksDTO>>
    {
        public async Task<PageResult<GetAllConsultantBanksDTO>> Handle(GetAllConsultantBanksQuery request, CancellationToken cancellationToken)
        {
            var listBanks =
             await consultantBankRepository.GetAllConsultantBanksAsync
             (request.Page, request.Limit, request.Search, request.Status);
            return new PageResult<GetAllConsultantBanksDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listBanks.TotalCount / (double)request.Limit),
                TotalItems = listBanks.TotalCount,
                Items = mapper.Map<List<GetAllConsultantBanksDTO>>(listBanks.Items)
            };
        }
    }
}
