using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Allergy.Queries.GetAll
{
    public class GetAllergyQuery : IRequest<PageResult<AllergyDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }

    }
}