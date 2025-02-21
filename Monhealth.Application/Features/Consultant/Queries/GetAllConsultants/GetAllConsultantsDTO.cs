using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Consultant.Queries.GetAllConsultants
{
    public class GetAllConsultantsDTO
    {
        public Guid ConsultantId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ExpertiseId { get; set; }
        public string Bio { get; set; } = string.Empty;
        public int? Experience { get; set; }
        public bool? Status { get; set; }
    }
}
