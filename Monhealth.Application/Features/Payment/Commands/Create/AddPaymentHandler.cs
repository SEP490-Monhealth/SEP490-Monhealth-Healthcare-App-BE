using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.Payment.Commands.Create
{
    public class AddPaymentHandler : IRequestHandler<AddPaymentRequest, Unit>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IUserRepository _userRepository;
        public AddPaymentHandler(IPaymentRepository paymentRepository,
        IUserRepository userRepository)
        {
            _paymentRepository = paymentRepository;
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(AddPaymentRequest request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);  
            var model = new Monhealth.Domain.Payment
            {
                Amount = request.Amount,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Status = request.Status,
                SubscriptionId = request.SubscriptionId,
                UserId = request.UserId,    
            };
            _paymentRepository.Add(model);
            await _paymentRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}