using MediatR;
using Monhealth.Application.Models;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class GetWithDrawRequestListQueryHandler(IWithdrawalRepository withdrawalRepository)
    : IRequestHandler<GetWithdrawalRequestListQuery, PageResult<GetWithdrawalRequestDTO>>
    {
        public async Task<PageResult<GetWithdrawalRequestDTO>> Handle(GetWithdrawalRequestListQuery request, CancellationToken cancellationToken)
        {
            var queries = await withdrawalRepository.GetAllWithdrawalRequestAsync(request.Page, request.Limit, request.Status);
            var withdDrawList = new List<GetWithdrawalRequestDTO>();
            foreach (var wd in queries.Items)
            {
                var withDrawDTO = new GetWithdrawalRequestDTO
                {
                    WithdrawalRequestId = wd.WithdrawalRequestId,
                    ConsultantId = wd.ConsultantId,
                    Description = wd.Description,
                    Amount = wd.Amount,
                    Status = wd.Status,
                    CreatedAt = wd.CreatedAt,
                    UpdatedAt = wd.UpdatedAt
                };
                withdDrawList.Add(withDrawDTO);
            }
            return new PageResult<GetWithdrawalRequestDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(queries.TotalCount / (double)request.Limit),
                TotalItems = queries.TotalCount,
                Items = withdDrawList
            };
        }
    }
}