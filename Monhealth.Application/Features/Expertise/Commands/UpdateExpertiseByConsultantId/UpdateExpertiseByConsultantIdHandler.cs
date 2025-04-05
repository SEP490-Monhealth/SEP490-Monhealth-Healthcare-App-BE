using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Expertise.Commands.UpdateExpertiseByConsultantId
{
    public class UpdateExpertiseByConsultantIdHandler(IConsultantRepository consultantRepository,
        IExpertiseRepository expertiseRepository

        ) : IRequestHandler<UpdateExpertiseByConsultantIdQueries, bool>
    {
        public async Task<bool> Handle(UpdateExpertiseByConsultantIdQueries request, CancellationToken cancellationToken)
        {
            var consultant = await consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null) throw new BadRequestException("Không tìm thấy Consultant bằng Id");
            var expertise = await expertiseRepository.GetExpertiseByNameAsync(request.UpdateDto.Name);
            if (expertise == null) throw new BadRequestException("Tên chuyên môn không đúng");

            consultant.ExpertiseId = expertise.ExpertiseId;
            await consultantRepository.SaveChangeAsync();
            return true;

        }
    }
}
