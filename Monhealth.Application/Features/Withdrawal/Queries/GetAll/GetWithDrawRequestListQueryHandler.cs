using MediatR;

namespace Monhealth.Application
{
    public class GetWithDrawRequestListQueryHandler(IWithDrawalRepository withDrawalRepository)
    : IRequestHandler<GetWithDrawalRequestListQuery, List<GetWithDrawalRequestDTO>>
    {
        public async Task<List<GetWithDrawalRequestDTO>> Handle(GetWithDrawalRequestListQuery request, CancellationToken cancellationToken)
        {
            var queries = await withDrawalRepository.GetAllAsync();
            return queries.Select(wd => new GetWithDrawalRequestDTO
            {
                Amount = wd.Amount,
                ConsultantId = wd.ConsultantId,
                Description = wd.Description,
                Status = wd.Status,
                WithDrawalRequestId = wd.WithDrawalRequestId,
                CreatedAt = wd.CreatedAt,
                UpdatedAt = wd.UpdatedAt
            }).ToList();
        }
    }
}