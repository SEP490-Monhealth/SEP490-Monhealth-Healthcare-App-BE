using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetUserAllergyQuery : IRequest<GetUserAllergyDTO>
    {
        public Guid UserId { get; set; }
    }
    public class GetUserAllergyQueryHandler(IUserAllergyRepository userAllergyRepository) : IRequestHandler<GetUserAllergyQuery, GetUserAllergyDTO>
    {
        public async Task<GetUserAllergyDTO> Handle(GetUserAllergyQuery request, CancellationToken cancellationToken)
        {
            var userHasAllergy = await userAllergyRepository.GetUserAllergiesByUserId(request.UserId);
            List<string> allergyNames = new List<string>();

            if (userHasAllergy != null)
            {
                allergyNames = userHasAllergy.Select(u => u.Allergy.AllergyName).ToList();
            }

            return new GetUserAllergyDTO
            {
                Allergies = allergyNames
            };
        }
    }
}