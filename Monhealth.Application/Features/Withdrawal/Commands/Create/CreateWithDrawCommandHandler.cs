using MediatR;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class CreateWithDrawCommandHandler(IWithdrawalRepository withdrawalRepository) : IRequestHandler<CreateWithdrawalRequestDTO, bool>
    {
        public async Task<bool> Handle(CreateWithdrawalRequestDTO request, CancellationToken cancellationToken)
        {
            WithdrawalRequest model = new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.NewGuid(),
                Amount = request.Amount,
                ConsultantId = request.ConsultantId,
                Description = request.Description,
                Status = Domain.Enum.WithdrawalStatus.Pending,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            withdrawalRepository.Add(model);
            await withdrawalRepository.SaveChangeASync();
            return true;
        }
    }
}