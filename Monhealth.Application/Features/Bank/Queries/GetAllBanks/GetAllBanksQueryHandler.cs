using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Bank.Queries.GetAllBanks
{
    public class GetAllBanksQueryHandler(IBankRepository bankRepository, IMapper mapper) : IRequestHandler<GetAllBanksQuery, PageResult<GetAllBanksDTO>>
    {
        public async Task<PageResult<GetAllBanksDTO>> Handle(GetAllBanksQuery request, CancellationToken cancellationToken)
        {
            var listBanks = await bankRepository.GetAllBanksAsync(request.Page, request.Limit, request.Search, request.Status);
            return new PageResult<GetAllBanksDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listBanks.TotalCount / (double)request.Limit),
                TotalItems = listBanks.TotalCount,
                Items = mapper.Map<List<GetAllBanksDTO>>(listBanks.Items)

            };
        }
    }
}
