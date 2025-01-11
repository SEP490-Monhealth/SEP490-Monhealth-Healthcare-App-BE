using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Allergy.Commands.CreateAllergy
{
    public class CreateAllergyHandler : IRequestHandler<CreateAllergyRequest, bool>
    {
        private readonly IAllergyRepository _allergyRepository;

        public CreateAllergyHandler(IAllergyRepository allergyRepository)
        {
            _allergyRepository = allergyRepository;
        }

        public async Task<bool> Handle(CreateAllergyRequest request, CancellationToken cancellationToken)
        {
            var model = new Monhealth.Core.Allergy{
                AllergyName = request.Name,
                AllergyDescription = request.Description
            };
            _allergyRepository.Add(model);
            await _allergyRepository.SaveChangeAsync();
            return true;
        }
    }
}