using MediatR;

namespace Monhealth.Application.Features.UserFood.Commands
{
    public class CreateUserFoodCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public CreateUserFoodDto CreateUserFoodDto { get; set; }
        public CreateUserFoodCommand(Guid userId, CreateUserFoodDto createUserFoodDto)
        {
            UserId = userId;
            CreateUserFoodDto = createUserFoodDto;
        }
    }
}
