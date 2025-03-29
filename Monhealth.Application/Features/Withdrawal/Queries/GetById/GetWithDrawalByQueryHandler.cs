using MediatR;

namespace Monhealth.Application
{
    public class GetWithdrawalByQueryHandler(IWithdrawalRepository withdrawalRepository) : IRequestHandler<GetWithdrawalByIdQuery, GetWithdrawalByIdDTO>
    {
        public async Task<GetWithdrawalByIdDTO> Handle(GetWithdrawalByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await withdrawalRepository.GetByIdAsync(request.WithdrawalRequestId);
            if (query == null) throw new Exception($"không tìm thấy id: {query}");
            return new GetWithdrawalByIdDTO
            {
                WithdrawalRequestId = query.WithdrawalRequestId,
                ConsultantId = query.ConsultantId,
                Description = query.Description,
                Amount = query.Amount,
                Status = query.Status,
                CreatedAt = query.CreatedAt,
                UpdatedAt = query.UpdatedAt
            };
        }
    }
}