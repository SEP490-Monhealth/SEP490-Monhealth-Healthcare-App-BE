using MediatR;

namespace Monhealth.Application.Features.Allergy.Commands.CreateAllergy
{
    public class CreateAllergyRequest : IRequest<bool>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}