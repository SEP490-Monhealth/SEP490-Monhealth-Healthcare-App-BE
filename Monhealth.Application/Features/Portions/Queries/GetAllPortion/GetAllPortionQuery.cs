using MediatR;
using Monhealth.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion
{
    public class GetAllPortionQuery : IRequest<PageResult<PortionDto>>
    {
        public int page { get; set; }
        public int limit { get; set; }
        public GetAllPortionQuery(int pageIndex, int pageSize)
        {
            page = pageIndex;
            limit = pageSize;
        }
    }
}
