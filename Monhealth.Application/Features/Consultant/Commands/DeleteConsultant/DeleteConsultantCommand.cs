using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Consultant.Commands.DeleteConsultant
{
    public class DeleteConsultantCommand : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }
    }
}
