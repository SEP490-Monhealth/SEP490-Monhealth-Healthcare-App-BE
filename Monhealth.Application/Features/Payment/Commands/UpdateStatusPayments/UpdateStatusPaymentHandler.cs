using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Payment.Commands.UpdateStatusPayments
{
    public class UpdateStatusPaymentHandler(IPaymentRepository paymentRepository) :
        IRequestHandler<UpdateStatusPaymentQueries, bool>
    {
        public async Task<bool> Handle(UpdateStatusPaymentQueries request, CancellationToken cancellationToken)
        {
            var payment = await paymentRepository.GetPayemntByOrderCodeAsync(request.PaymentId);
            if (payment == null) throw new BadRequestException($"Không tìm thấy thanh toán bằng OrderCode:{request.PaymentId}");
            payment.Status = Core.PaymentStatus.Completed;
            await paymentRepository.SaveChangeAsync();
            return true;
        }
    }
}
