using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Payment.Commands.Create
{
    public class AddPaymentHandler : IRequestHandler<AddPaymentRequest, Unit>
    {
        private readonly IPaymentRepository _paymentRepository;

        public AddPaymentHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<Unit> Handle(AddPaymentRequest request, CancellationToken cancellationToken)
        {
            var model = new Monhealth.Domain.Payment
            {
                  Amount = request.Amount,
                  CreatedAt= DateTime.Now,
                  UpdatedAt = DateTime.Now,
                  Status = request.Status,
                  SubscriptionId = request.SubscriptionId
            };
            _paymentRepository.Add(model);
            await _paymentRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}