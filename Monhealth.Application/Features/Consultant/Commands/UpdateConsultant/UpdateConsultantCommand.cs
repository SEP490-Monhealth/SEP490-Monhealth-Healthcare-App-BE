using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Consultant.Commands.UpdateConsultant
{
    public class UpdateConsultantCommand : IRequest<bool>
    {
        public UpdateConsultantCommand()
        {
            
        }
    }
}
