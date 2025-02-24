using MediatR;
using Monhealth.Application.Contracts.Persistence;

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
             var paymentId = await _paymentRepository.GetByIdAsync(request.PaymentId);
             paymentId.Amount = request.Amount;
             _paymentRepository.Update(paymentId);
             await _paymentRepository.SaveChangeAsync();
             return true;
        }
    }
}