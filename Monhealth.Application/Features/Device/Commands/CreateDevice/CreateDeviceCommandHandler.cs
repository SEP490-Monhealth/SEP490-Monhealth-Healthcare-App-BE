using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserDevice.Commands.CreateUserDevice
{
    public class CreateDeviceCommandHandler(IDeviceRepository deviceRepository, IMapper mapper) : IRequestHandler<CreateDeviceCommand, Unit>
    {
        public async Task<Unit> Handle(CreateDeviceCommand request, CancellationToken cancellationToken)
        {
            var checkExpoPushToken = await deviceRepository.GetExpoPushToken(request.CreateDeviceDTO.UserId,
                request.CreateDeviceDTO.ExpoPushToken);
            if (checkExpoPushToken != null)
            {
                checkExpoPushToken.UpdatedAt = DateTime.UtcNow;
            }
            else
            {
                var newUserDevice = mapper.Map<Domain.Device>(request.CreateDeviceDTO);
                newUserDevice.DeviceId = Guid.NewGuid();
                newUserDevice.CreatedAt = DateTime.UtcNow;
                newUserDevice.UpdatedAt = DateTime.UtcNow;
                deviceRepository.Add(newUserDevice);
            }
            await deviceRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
