using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceByUserId
{
    public class GetDeviceByUserIdDTO : TimeEntity
    {
        public Guid DeviceId { get; set; }
        public Guid UserId { get; set; }
        public string ExpoPushToken { get; set; } = string.Empty;
        public string DeviceModel { get; set; } = string.Empty;
        public string Os { get; set; } = string.Empty;
        public string OsVersion { get; set; } = string.Empty;
        public string AppVersion { get; set; } = string.Empty;
    }
}
