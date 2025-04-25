using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Consultant.Commands.RejectConsultant
{
    public class RejectConsultantCommandHandler(IConsultantRepository consultantRepository) : IRequestHandler<RejectConsultantCommand, bool>
    {
        public async Task<bool> Handle(RejectConsultantCommand request, CancellationToken cancellationToken)
        {
            var consultant = await consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null)
                throw new BadRequestException("Không tìm thấy chuyên viên");

            if (consultant.VerificationStatus == VerificationStatus.Verified)
                throw new BadRequestException("Chuyên viên đã được xác thực, không thể từ chối");

            if (consultant.VerificationStatus == VerificationStatus.Rejected)
                throw new BadRequestException("Chuyên viên đã bị từ chối trước đó");

            consultant.VerificationStatus = VerificationStatus.Rejected;
            consultant.Status = false;

            consultant.UpdatedAt = DateTime.UtcNow;
            consultantRepository.Update(consultant);
            await consultantRepository.SaveChangeAsync();
            return true;
        }
    }
}
