using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Allergy.Queries.GetByUser
{
    public class GetAllergyByUserQuery : IRequest<List<AllergyByUserDTO>>
    {
        public Guid UserId { get; set; }
    }
}