using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserFood.Commands.Update
{
    public class UpdateUserFoodCommandHandler : IRequestHandler<UpdateUserFoodCommand, Unit>
    {
        private readonly IUserFoodRepository _userFoodRepository;
        public UpdateUserFoodCommandHandler(IUserFoodRepository userFoodRepository)
        {
            _userFoodRepository = userFoodRepository;
        }

        public async Task<Unit> Handle(UpdateUserFoodCommand request, CancellationToken cancellationToken)
        {
            var id = await _userFoodRepository.GetUserFoodByUserIdAsync(request.UserId);
            id.Allergies = request.Allergies;
            id.Categories = request.Categories;
            id.UpdatedAt = DateTime.Now;
            _userFoodRepository.Update(id);
            await _userFoodRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}