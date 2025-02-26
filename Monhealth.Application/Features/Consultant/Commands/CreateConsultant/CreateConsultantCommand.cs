using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Consultant.Commands.CreateConsultant
{
    public class CreateConsultantCommand : IRequest<Unit>
    {
        public CreateConsultantDTO CreateConsultantDTO { get; set; }
        public CreateConsultantCommand(CreateConsultantDTO createConsultantDTO)
        {
            CreateConsultantDTO = createConsultantDTO;
        }
    }
}
