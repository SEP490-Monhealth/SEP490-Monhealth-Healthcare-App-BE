using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Consultant.Commands.UpdateConsultant
{
    public class UpdateConsultantDTO
    {
        public Guid? ExpertiseId { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int Experience { get; set; }
    }
}
