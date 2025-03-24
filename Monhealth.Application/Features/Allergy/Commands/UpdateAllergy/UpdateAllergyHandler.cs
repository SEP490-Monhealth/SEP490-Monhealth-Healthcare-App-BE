using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Allergy.Commands.UpdateAllergy
{
    public class UpdateAllergyHandler : IRequestHandler<UpdateAllergyRequestHandler, bool>
    {
        private readonly IAllergyRepository _allergyRepository;
        public UpdateAllergyHandler(IAllergyRepository allergyRepository)
        {
            _allergyRepository = allergyRepository;
        }

        public async Task<bool> Handle(UpdateAllergyRequestHandler request, CancellationToken cancellationToken)
        {
            var user = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B");

            var allergyId = await _allergyRepository.GetByIdAsync(request.AllergyId);
            allergyId.AllergyName = request.Request.Name;
            allergyId.AllergyDescription = request.Request.Description;
            allergyId.UpdatedBy = user;
            _allergyRepository.Update(allergyId);
            await _allergyRepository.SaveChangeAsync();
            return true;
        }
    }
}