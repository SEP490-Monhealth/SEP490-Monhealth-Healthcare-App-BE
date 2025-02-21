using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Consultant.Queries.GetAllConsultants
{
    public class GetAllConsultantsQuery : IRequest<List<GetAllConsultantsDTO>>
    {
        public GetAllConsultantsDTO GetAllConsultantsDTO { get; set; }
    }
}
