using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Commands.DeletePortion
{
    public class DeletePortionCommand : IRequest<bool>
    {
        public Guid PortionId { get; set; }
    }
}
