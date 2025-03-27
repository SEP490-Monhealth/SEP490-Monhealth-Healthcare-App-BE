using MediatR;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class CreateWithDrawCommandHandler(IWithDrawalRepository withDrawalRepository) : IRequestHandler<CreateWithDrawalRequestDTO, bool>
    {
        public async Task<bool> Handle(CreateWithDrawalRequestDTO request, CancellationToken cancellationToken)
        {
            WithDrawalRequest model = new WithDrawalRequest
            {
                WithDrawalRequestId = Guid.NewGuid(),
                Amount = request.Amount,
                ConsultantId = request.ConsultantId,
                Description = request.Description,
                Status = Domain.Enum.WithDrawalStatus.Pending,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            withDrawalRepository.Add(model);
            await withDrawalRepository.SaveChangeASync();
            return true;
        }
    }
}