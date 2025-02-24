using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Consultant.Queries.GetAllConsultants
{
    public class GetAllConsultantsQuery : IRequest<PageResult<GetAllConsultantsDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public bool? Status { get; set; }
        public GetAllConsultantsQuery(int page, int limit, bool? status)
        {
            Page = page;
            Limit = limit;
            Status = status;
        }
    }
}
