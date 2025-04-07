using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Device : TimeEntity
    {
        [Key]
        public Guid DeviceId { get; set; }
        public Guid UserId { get; set; }
        public string ExpoPushToken { get; set; } = string.Empty;
        public string DeviceModel { get; set; } = string.Empty;
        public string Os { get; set; } = string.Empty;
        public string OsVersion { get; set; } = string.Empty;
        public string AppVersion { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
    }
}
