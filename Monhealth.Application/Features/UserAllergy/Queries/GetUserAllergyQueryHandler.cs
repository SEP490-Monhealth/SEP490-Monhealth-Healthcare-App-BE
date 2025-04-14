using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetUserAllergyQuery : IRequest<List<GetUserAllergyDTO>>
    {
        public Guid UserId { get; set; }
    }
    public class GetUserAllergyQueryHandler(IUserAllergyRepository userAllergyRepository) : IRequestHandler<GetUserAllergyQuery, List<GetUserAllergyDTO>>
    {
        public async Task<List<GetUserAllergyDTO>> Handle(GetUserAllergyQuery request, CancellationToken cancellationToken)
        {
            var userHasAllergy = await userAllergyRepository.GetUserAllergiesByUserId(request.UserId);
            List<GetUserAllergyDTO> userAllergyDTOs = new List<GetUserAllergyDTO>();
            if (userHasAllergy != null)
            {
                foreach (var allergies in userHasAllergy)
                {
                    GetUserAllergyDTO getUserAllergy = new GetUserAllergyDTO
                    {
                        AllergyId = allergies.AllergyId,
                        AllergyName = allergies.Allergy.AllergyName
                    };
                    userAllergyDTOs.Add(getUserAllergy);
                }
                return userAllergyDTOs;
            }
            else
                return new List<GetUserAllergyDTO>();

        }
    }
}