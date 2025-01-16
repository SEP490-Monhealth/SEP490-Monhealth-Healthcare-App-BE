using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class Type : BaseEntity
    {
        [Key]
        public Guid TypeId { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public string TypeDescription { get; set; } = string.Empty;
        public string TypeImage { get; set; } = string.Empty;

        public ICollection<Exercise> Exercises { get; set; }
    }
}
