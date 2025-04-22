using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Consultant.Commands.CreateConsultant
{
    public class CreateConsultantCommandHandler : IRequestHandler<CreateConsultantCommand, Unit>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly ICertificateRepository _certificateRepository;
        private readonly IWalletRepository _walletRepository;
        private readonly IMapper _mapper;
        private readonly IUserRoleRepository userRoleRepository;
        private readonly ISystemNotificationService systemNotificationService;

        public CreateConsultantCommandHandler(IConsultantRepository consultantRepository,
                                                IExpertiseRepository expertiseRepository,
                                                ICertificateRepository certificateRepository,
                                                IWalletRepository walletRepository,
                                                IMapper mapper,
                                                IUserRoleRepository userRoleRepository,
                                                ISystemNotificationService systemNotificationService
                                                )
        {
            _consultantRepository = consultantRepository;
            _expertiseRepository = expertiseRepository;
            _certificateRepository = certificateRepository;
            _walletRepository = walletRepository;
            _mapper = mapper;
            this.userRoleRepository = userRoleRepository;
            this.systemNotificationService = systemNotificationService;
        }
        public async Task<Unit> Handle(CreateConsultantCommand request, CancellationToken cancellationToken)
        {
            var today = DateTime.Now;
            // Create Expertise                
            var expertise = await _expertiseRepository.GetExpertiseByNameAsync(request.CreateConsultantDTO.ExpertiseName);
            if (expertise == null)
            {
                expertise = _mapper.Map<Domain.Expertise>(request.CreateConsultantDTO);
                expertise.ExpertiseId = Guid.NewGuid();
                expertise.CreatedAt = today;
                expertise.UpdatedAt = today;
                _expertiseRepository.Add(expertise);

            }
            // Create Consultant
            var consultant = await _consultantRepository.GetConsultantByUserId(request.CreateConsultantDTO.UserId);
            if (consultant != null) { throw new BadRequestException("Người dùng này đã là chuyên viên tư vấn"); }
            var newConsultant = _mapper.Map<Domain.Consultant>(request.CreateConsultantDTO);
            newConsultant.ConsultantId = Guid.NewGuid();
            newConsultant.ExpertiseId = expertise.ExpertiseId;
            newConsultant.CreatedAt = today;
            newConsultant.UpdatedAt = today;
            _consultantRepository.Add(newConsultant);

            // Create Certificate
            var newCertificate = _mapper.Map<Domain.Certificate>(request.CreateConsultantDTO);
            newCertificate.CertificateId = Guid.NewGuid();
            newCertificate.ExpertiseId = expertise.ExpertiseId;
            newCertificate.ConsultantId = newConsultant.ConsultantId;
            //newCertificate.ImageUrls = JsonSerializer.Serialize(request.CreateConsultantDTO.Images);
            newCertificate.ImageUrls = request.CreateConsultantDTO.ImageUrls;
            newCertificate.CreatedAt = today;
            newCertificate.UpdatedAt = today;
            _certificateRepository.Add(newCertificate);

            //Create Wallet
            var wallet = new Domain.Wallet
            {
                WalletId = Guid.NewGuid(),
                ConsultantId = newConsultant.ConsultantId,
                Balance = 0,
                CreatedAt = today,
                UpdatedAt = today,
            };
            _walletRepository.Add(wallet);

            //assign new role for consultant 
            var consultantRole = await userRoleRepository.GetRoleConsultant("Consultant");
            // xoa role
            var userId = newConsultant?.UserId;
            if (userId.HasValue)
            {
                var userRole = await userRoleRepository.GetUserRoleByUserIdAsync(userId.Value);
                if (userRole != null)
                {
                    // Nếu người dùng đã có role, xóa bản ghi cũ trước khi thêm role mới
                    userRoleRepository.Remove(userRole);
                }
                // Tạo bản ghi mới cho UserRole với RoleId mới
                var newUserRole = new IdentityUserRole<Guid>
                {
                    UserId = userId.Value,
                    RoleId = consultantRole.Id
                };
                userRoleRepository.Add(newUserRole);
            }

            //Send notification create new Consultant
            await systemNotificationService.NotifyNewConsultantRegistrationAsync((Guid)userId, cancellationToken);

            await _certificateRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
