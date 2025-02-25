using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Payment.Commands.Update
{
    public class UpdatePaymentCommandHandler : IRequestHandler<UpdatePaymentCommand, bool>
    {
        private readonly IPaymentRepository _paymentRepository;
        public UpdatePaymentCommandHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<bool> Handle(UpdatePaymentCommand request, CancellationToken cancellationToken)
        {
            var payment = await _paymentRepository.GetByIdAsync(request.PaymentId);
            if (payment == null) throw new BadRequestException("Không tìm thấy phiên thanh toán");
            if (request.UpdatePaymentDto.Amount > 0 && payment.Amount != request.UpdatePaymentDto.Amount)
            {
                payment.Amount = request.UpdatePaymentDto.Amount;

            }
            _paymentRepository.Update(payment);
            await _paymentRepository.SaveChangeAsync();
            return true;
        }
    }
}