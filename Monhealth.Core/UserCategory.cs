using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Core
{
    public class UserCategory : TimeEntity
    {
        public Guid UserCategoryId { get; set; }
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; } = null!;
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
    }
}