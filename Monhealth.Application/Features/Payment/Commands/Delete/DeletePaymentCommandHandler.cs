using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Payment.Commands.Create;

namespace Monhealth.Application.Features.Payment.Commands.Delete
{
    public class DeletePaymentCommandHandler : IRequestHandler<DeletePaymentCommand, bool>
    {
        private readonly IPaymentRepository _paymentRepository;
        public DeletePaymentCommandHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<bool> Handle(DeletePaymentCommand request, CancellationToken cancellationToken)
        {
            var payment = await _paymentRepository.GetByIdAsync(request.PaymentId);
            _paymentRepository.Remove(payment);
            await _paymentRepository.SaveChangeAsync();
            return true;
        }
    }
}