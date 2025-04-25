using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features
{
    public class CreateUserAllergyCommandHandler : IRequestHandler<CreateUserAllergyRequest, bool>
    {
        private readonly IUserAllergyRepository _userAllergyRepository;
        private readonly IAllergyRepository _allergyRepository;
        public CreateUserAllergyCommandHandler(IUserAllergyRepository userAllergyRepository,
        IAllergyRepository allergyRepository)
        {
            _userAllergyRepository = userAllergyRepository;
            _allergyRepository = allergyRepository;
        }

        public async Task<bool> Handle(CreateUserAllergyRequest request, CancellationToken cancellationToken)
        {
            var allergies = await _allergyRepository.GetAllergiesByList(request.Allergies);
            if (allergies.Count() != request.Allergies.Count())
            {
                return false;
            }
            _userAllergyRepository.AddRange(allergies.Select(a => new UserAllergy
            {
                     UserAllergyId = Guid.NewGuid(),
                     UserId = request.UserId,
                     AllergyId = a.AllergyId,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow
            }));
            await _userAllergyRepository.SaveChangeAsync();
            return true;
        }
    }
}