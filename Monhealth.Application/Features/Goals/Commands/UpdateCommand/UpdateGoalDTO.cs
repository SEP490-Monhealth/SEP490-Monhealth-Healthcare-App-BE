using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Commands.UpdateCommand
{
    public class UpdateGoalDTO
    {
        public string GoalType { get; set; }
        public int WeightGoal { get; set; }
    }
}
