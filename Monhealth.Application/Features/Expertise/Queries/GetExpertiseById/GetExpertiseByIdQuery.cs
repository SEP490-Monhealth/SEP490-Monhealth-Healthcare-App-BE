using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Features.Expertise.Queries.GetAllExpertises;

namespace Monhealth.Application.Features.Expertise.Queries.GetExpertiseById
{
    public class GetExpertiseByIdQuery : IRequest<GetExpertiseByIdDTO>
    {
        public Guid ExpertiseId { get; set; }
    }
}
