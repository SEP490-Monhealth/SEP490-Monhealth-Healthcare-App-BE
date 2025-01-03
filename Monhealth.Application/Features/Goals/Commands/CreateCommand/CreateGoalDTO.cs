using Monhealth.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Commands.CreateCommand
{
    public class CreateGoalDTO
    {
        public Guid UserId { get; set; }
        public string GoalType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; } = string.Empty;
        public string Status { get; set; }
    }
}
