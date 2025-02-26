using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Consultant.Commands.ChangeStatusConsultant
{
    public class ChangeStatusConsultantCommand : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }
    }
}
