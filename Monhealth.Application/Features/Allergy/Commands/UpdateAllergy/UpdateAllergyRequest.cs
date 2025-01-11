using MediatR;

namespace Monhealth.Application.Features.Allergy.Commands.UpdateAllergy
{
    public class UpdateAllergyRequest : IRequest<bool>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}