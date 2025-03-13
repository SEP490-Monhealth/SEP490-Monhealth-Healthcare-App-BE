using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Activity.Commands.DeleteActivity
{
    public class DeleteActivityCommand : IRequest<bool>
    {
        public Guid ActivityId { get; set; }
    }
}
