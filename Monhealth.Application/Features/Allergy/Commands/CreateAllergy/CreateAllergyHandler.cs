using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Allergy.Commands.CreateAllergy
{
    public class CreateAllergyHandler : IRequestHandler<CreateAllergyRequest, bool>
    {
        private readonly IAllergyRepository _allergyRepository;
        private readonly IUserRepository _userRepository;
        public CreateAllergyHandler(IAllergyRepository allergyRepository,
        IUserRepository userRepository)
        {
            _allergyRepository = allergyRepository;
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(CreateAllergyRequest request, CancellationToken cancellationToken)
        { 
            var model = new Monhealth.Domain.Allergy
            {
                AllergyName = request.Name,
                AllergyDescription = request.Description,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            _allergyRepository.Add(model);
            await _allergyRepository.SaveChangeAsync();
            return true;
        }
    }
}