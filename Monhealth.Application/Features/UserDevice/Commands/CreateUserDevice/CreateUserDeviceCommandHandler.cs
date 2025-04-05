using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserDevice.Commands.CreateUserDevice
{
    public class CreateUserDeviceCommandHandler(IUserDeviceRepository userDeviceRepository, IMapper mapper) : IRequestHandler<CreateUserDeviceCommand, Unit>
    {
        public async Task<Unit> Handle(CreateUserDeviceCommand request, CancellationToken cancellationToken)
        {
            var newUserDevice = mapper.Map<Domain.UserDevice>(request.CreateUserDeviceDTO);
            newUserDevice.UserDeviceId = Guid.NewGuid();
            newUserDevice.CreatedAt = DateTime.Now;
            newUserDevice.UpdatedAt = DateTime.Now;
            userDeviceRepository.Add(newUserDevice);
            await userDeviceRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
