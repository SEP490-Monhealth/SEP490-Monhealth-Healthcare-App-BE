using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Expertise.Queries.GetAllExpertises
{
    public class GetAllExpertisesQuery : IRequest<PageResult<GetAllExpertisesDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetAllExpertisesQuery(int page, int limit)
        {
            Page = page;
            Limit = limit;
        }
    }
}
