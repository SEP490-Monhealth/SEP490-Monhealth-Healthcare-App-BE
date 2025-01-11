using MediatR;

namespace Monhealth.Application.Features.Allergy.Queries.GetDetail
{
    public class GetAllergyDetailQuery : IRequest<AllergyDetailDTO>
    {
        public Guid AllergyId { get; set; }
    }
}