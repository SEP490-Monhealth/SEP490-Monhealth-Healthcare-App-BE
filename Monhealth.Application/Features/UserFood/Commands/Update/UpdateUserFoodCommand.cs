using MediatR;

namespace Monhealth.Application.Features.UserFood.Commands.Update
{
    public class UpdateUserFoodCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Allergies { get; set; }
        public UpdateUserFoodCommand(Guid userId, UpdateUserFoodRequest update)
        {
            UserId = userId;
            Categories = update.Categories;
            Allergies = update.Allergies;
        }


    }
}