using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Domain
{
    public class UserDevice : TimeEntity
    {
        [Key]
        public Guid UserDeviceId { get; set; }
        public Guid UserId { get; set; }
        public string ExpoPushToken { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
    }
}
