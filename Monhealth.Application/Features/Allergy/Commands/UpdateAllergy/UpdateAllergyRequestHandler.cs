using MediatR;

namespace Monhealth.Application.Features.Allergy.Commands.UpdateAllergy
{
    public class UpdateAllergyRequestHandler : IRequest<bool>
    {
        public Guid AllergyId { get; set; }
        public UpdateAllergyRequest Request { get; set; }

        public UpdateAllergyRequestHandler(Guid allergyId, UpdateAllergyRequest request)
        {
            AllergyId = allergyId;
            Request = request;
        }
    }
}