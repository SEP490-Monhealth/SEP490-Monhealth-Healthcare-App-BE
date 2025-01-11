using MediatR;

namespace Monhealth.Application.Features.Allergy.Commands.DeleteAllergy
{
    public class DeleteAllergyRequest : IRequest<bool>
    {
        public Guid AllergyId { get; set; }        
        public DeleteAllergyRequest(Guid allergyId)
        {
            AllergyId = allergyId;
        }


    }
}