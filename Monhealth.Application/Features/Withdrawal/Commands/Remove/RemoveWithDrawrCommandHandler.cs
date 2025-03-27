
using MediatR;

namespace Monhealth.Application
{
    public class RemoveWithDrawrCommandHandler(IWithDrawalRepository withDrawalRepository) : IRequestHandler<RemoveWithdrawRequest, bool>
    {
        public async Task<bool> Handle(RemoveWithdrawRequest request, CancellationToken cancellationToken)
        {
            var id = await withDrawalRepository.GetByIdAsync(request.WithDrawalRequestId);
            if(id == null) throw new Exception($"không tìm thấy id : {id}");
            withDrawalRepository.Remove(id);
            await withDrawalRepository.SaveChangeASync();
            return true;
        }
    }
}