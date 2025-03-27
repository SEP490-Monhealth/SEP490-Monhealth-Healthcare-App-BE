using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Bank.Commands.CreateBank
{
    public class CreateBankCommand : IRequest<Unit>
    {
        public CreateBankDTO CreateBankDTO { get; set; }
        public CreateBankCommand(CreateBankDTO createBankDTO)
        {
            CreateBankDTO = createBankDTO;
        }
    }
}
