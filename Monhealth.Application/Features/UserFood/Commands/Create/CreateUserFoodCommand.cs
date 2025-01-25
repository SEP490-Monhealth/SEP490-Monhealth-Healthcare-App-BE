using MediatR;

namespace Monhealth.Application.Features.UserFood.Commands
{
    public class CreateUserFoodCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Allergies { get; set; }

        public CreateUserFoodCommand(CreateUserFoodDto request)
        {
            UserId = request.UserId;
            Categories = request.Categories;
            Allergies = request.Allergies;
        }
    }
}
