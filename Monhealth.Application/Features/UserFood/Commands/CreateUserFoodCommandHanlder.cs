using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserFood.Commands
{
    public class CreateUserFoodCommandHandler : IRequestHandler<CreateUserFoodCommand, Unit>
    {
        private readonly IUserFoodRepository _userFoodRepository;

        public CreateUserFoodCommandHandler(IUserFoodRepository userFoodRepository)
        {
            _userFoodRepository = userFoodRepository;
        }

        public async Task<Unit> Handle(CreateUserFoodCommand request, CancellationToken cancellationToken)
        {
            var userFood = new Monhealth.Domain.UserFood
            {
                UserId = request.UserId,
                Categories = request.Categories,
                Allergies = request.Allergies
            };

            _userFoodRepository.Add(userFood);

            await _userFoodRepository.SaveChangeAsync();

            return Unit.Value;
        }
    }
}
