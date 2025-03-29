using MediatR;

namespace Monhealth.Application
{
    public class GetWithDrawRequestListQueryHandler(IWithdrawalRepository withdrawalRepository)
    : IRequestHandler<GetWithdrawalRequestListQuery, List<GetWithdrawalRequestDTO>>
    {
        public async Task<List<GetWithdrawalRequestDTO>> Handle(GetWithdrawalRequestListQuery request, CancellationToken cancellationToken)
        {
            var queries = await withdrawalRepository.GetAllAsync();
            return queries.Select(wd => new GetWithdrawalRequestDTO
            {
                WithdrawalRequestId = wd.WithdrawalRequestId,
                ConsultantId = wd.ConsultantId,
                Description = wd.Description,
                Amount = wd.Amount,
                Status = wd.Status,
                CreatedAt = wd.CreatedAt,
                UpdatedAt = wd.UpdatedAt
            }).ToList();
        }
    }
}