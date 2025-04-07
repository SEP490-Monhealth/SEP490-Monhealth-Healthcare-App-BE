namespace Monhealth.Application.Features.UserDevice.Commands.CreateUserDevice
{
    public class CreateDeviceDTO
    {
        public Guid UserId { get; set; }
        public string ExpoPushToken { get; set; } = string.Empty;
        public string DeviceModel { get; set; } = string.Empty;
        public string Os { get; set; } = string.Empty;
        public string OsVersion { get; set; } = string.Empty;
        public string AppVersion { get; set; } = string.Empty;
    }
}
