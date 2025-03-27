using MediatR;

namespace Monhealth.Application
{
    public class GetWithDrawalByQueryHandler(IWithDrawalRepository withDrawalRepository) : IRequestHandler<GetWithDrawalByIdQuery, GetWithDrawalByIdDTO>
    {
        public async Task<GetWithDrawalByIdDTO> Handle(GetWithDrawalByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await withDrawalRepository.GetByIdAsync(request.WithDrawalRequestId);
            if (query == null) throw new Exception($"không tìm thấy id: {query}");
            return new GetWithDrawalByIdDTO
            {
               Amount = query.Amount,
               ConsultantId = query.ConsultantId,
               Description = query.Description,
               Status = query.Status,
               WithDrawalRequestId = query.WithDrawalRequestId,
               CreatedAt = query.CreatedAt,
               UpdatedAt = query.UpdatedAt
            };
        }
    }
}