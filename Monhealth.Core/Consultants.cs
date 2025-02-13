using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Domain
{
    public class Consultants : TimeEntity
    {
        public Guid ConsultantId { get; set; }
        public Guid UserId { get; set; }
        public string Bio { get; set; } = string.Empty;
        public string Expertise { get; set; } = string.Empty;
        public int Experience { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
    }
}
