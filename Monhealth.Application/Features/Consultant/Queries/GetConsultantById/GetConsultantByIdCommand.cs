﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Consultant.Queries.GetConsultantById
{
    public class GetConsultantByIdCommand : IRequest<GetConsultantByIdDTO>
    {
        public Guid ConsultantId { get; set; }
    }
}
