using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Activity.Commands.CreateActivity
{
    public class CreateActivityDTO
    {
        public Guid? WorkoutId { get; set; }
        public Guid? UserId { get; set; }
    }
}
