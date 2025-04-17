using MediatR;

namespace Monhealth.Application
{
    public class UpdateWithDrawRequestCommandHandler(IWithdrawalRepository withdrawalRepository) : IRequestHandler<UpdateWithdrawalRequest, bool>
    {
        public async Task<bool> Handle(UpdateWithdrawalRequest request, CancellationToken cancellationToken)
        {
            var id = await withdrawalRepository.GetByIdAsync(request.WithdrawalRequestId);
            if (id == null)
            {
                throw new Exception($"Không tìm thấy id:{id}");
            }
            id.ConsultantBankId = request.WithdrawalRequestId;
            id.Amount = request.Request.Amount;
            id.Description = request.Request.Description;
            id.UpdatedAt = DateTime.Now;
            withdrawalRepository.Update(id);
            await withdrawalRepository.SaveChangeASync();
            return true;
        }
    }
}