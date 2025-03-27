using MediatR;

namespace Monhealth.Application
{
    public class UpdateWithDrawRequestCommandHandler(IWithDrawalRepository withDrawalRepository) : IRequestHandler<UpdateWithDrawalRequest, bool>
    {
        public async Task<bool> Handle(UpdateWithDrawalRequest request, CancellationToken cancellationToken)
        {
            var id = await withDrawalRepository.GetByIdAsync(request.WithDrawalRequestId);
            if (id == null)
            {
                throw new Exception($"Không tìm thấy id:{id}");
            }
            id.Amount = request.Request.Amount;
            id.Description = request.Request.Description;
            id.UpdatedAt = DateTime.Now;
            withDrawalRepository.Update(id);
            await withDrawalRepository.SaveChangeASync();
            return true;
        }
    }
}