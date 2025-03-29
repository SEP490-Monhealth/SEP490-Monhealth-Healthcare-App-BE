
using MediatR;

namespace Monhealth.Application
{
    public class RemoveWithDrawrCommandHandler(IWithdrawalRepository withdrawalRepository) : IRequestHandler<RemoveWithdrawRequest, bool>
    {
        public async Task<bool> Handle(RemoveWithdrawRequest request, CancellationToken cancellationToken)
        {
            var id = await withdrawalRepository.GetByIdAsync(request.WithdrawalRequestId);
            if (id == null) throw new Exception($"không tìm thấy id : {id}");
            withdrawalRepository.Remove(id);
            await withdrawalRepository.SaveChangeASync();
            return true;
        }
    }
}