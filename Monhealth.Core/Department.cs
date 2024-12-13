using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Domain
{
    public class Department : BaseEntity
    {
        [Key]
        public Guid DepartmentId { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Consultant> Consultants { get; set; }

    }
}
