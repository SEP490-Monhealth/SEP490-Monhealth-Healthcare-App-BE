namespace Monhealth.Application.Features.UserDevice.Commands.CreateUserDevice
{
    public class CreateUserDeviceDTO
    {
        public Guid UserId { get; set; }
        public string ExpoPushToken { get; set; } = string.Empty;
    }
}
