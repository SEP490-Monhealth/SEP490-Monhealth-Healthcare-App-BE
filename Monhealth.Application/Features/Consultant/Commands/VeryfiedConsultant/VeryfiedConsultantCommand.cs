using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Consultant.Commands.VeryfiedConsultant
{
    public class VeryfiedConsultantCommand : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }

    }
}
