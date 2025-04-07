using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.UserSubscription.Commands.Create;
using Monhealth.Core.Enum;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;
namespace Monhealth.Application.Features.Payment.Commands.UpdateStatusPayments
{
    public class UpdateStatusPaymentHandler : IRequestHandler<UpdateStatusPaymentQueries, bool>
    {
        private readonly IPaymentRepository _paymentRepository;

        public UpdateStatusPaymentHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<bool> Handle(UpdateStatusPaymentQueries request, CancellationToken cancellationToken)
        {
            var payment = await _paymentRepository.GetPayemntByOrderCodeAsync(request.PaymentId);
            if (payment == null)
                throw new BadRequestException($"Không tìm thấy thanh toán : {request.PaymentId}");
            // Cập nhật trạng thái thanh toán
            payment.Status = Core.PaymentStatus.Completed;
            payment.UpdatedAt = DateTime.Now;
            await _paymentRepository.SaveChangeAsync();
            return true;
        }
    }
}
