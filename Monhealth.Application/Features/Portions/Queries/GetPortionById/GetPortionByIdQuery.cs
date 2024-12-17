using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Queries.GetPortionById
{
    public class GetPortionByIdQuery : IRequest<GetPortionByIdDto>
    {
        public Guid PortionId { get; set; }
    }
}
