using MediatR;
using Monhealth.Application.Contracts.Persistence;
using System.Text.Json;

namespace Monhealth.Application.Features.UserFood.Commands
{
    public class CreateUserFoodCommandHanlder(IUserFoodRepository userFoodRepository) : IRequestHandler<CreateUserFoodCommand, Unit>
    {
        public async Task<Unit> Handle(CreateUserFoodCommand request, CancellationToken cancellationToken)
        {
            var userFood = new Monhealth.Domain.UserFood
            {
                UserId = request.UserId,
                Categories = JsonSerializer.Serialize(request.CreateUserFoodDto.Categories),
                Allergies = JsonSerializer.Serialize(request.CreateUserFoodDto.Allergies)
            };
            userFoodRepository.Add(userFood);
            await userFoodRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
