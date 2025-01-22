using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserFood.Commands
{
    public class CreateUserFoodCommandHanlder(IUserFoodRepository userFoodRepository) : IRequestHandler<CreateUserFoodCommand, Unit>
    {
        public async Task<Unit> Handle(CreateUserFoodCommand request, CancellationToken cancellationToken)
        {
            var userFood = new Monhealth.Domain.UserFood
            {
                UserId = request.UserId,
                Allergies = request.CreateUserFoodDto.Allergies,
                Categories = request.CreateUserFoodDto.Categories
            };
            userFoodRepository.Add(userFood);
            await userFoodRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
