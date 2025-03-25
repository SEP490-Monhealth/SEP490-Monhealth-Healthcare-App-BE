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
            var user = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B");
            var model = new Monhealth.Domain.Allergy
            {
                AllergyName = request.Name,
                AllergyDescription = request.Description,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = user
            };
            _allergyRepository.Add(model);
            await _allergyRepository.SaveChangeAsync();
            return true;
        }
    }
}