﻿using MediatR;
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
        public string sort { get; set; }
        public string order { get; set; }
        public GetAllPortionQuery(int pageIndex, int pageSize, string sortBy, string orderBy)
        {
            page = pageIndex;
            limit = pageSize;
            sort = sortBy;
            order = orderBy;
        }
    }
}
