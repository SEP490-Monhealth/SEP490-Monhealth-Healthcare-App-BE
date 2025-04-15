using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Consultant.Queries.GetUrlMeetByConsultantId
{
    public class GetUrlMeetByConsultantIdQueryHandler(IConsultantRepository consultantRepository) : IRequestHandler<GetUrlMeetByConsultantIdQuery, GetUrlMeetByConsultantIdDto>
    {
        public async Task<GetUrlMeetByConsultantIdDto> Handle
            (GetUrlMeetByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var consultant = await consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null) throw new BadRequestException("Không tìm thấy tư vấn viên");

            return new GetUrlMeetByConsultantIdDto
            {
                ConsultantId = consultant.ConsultantId,
                MeetUrl = consultant.MeetUrl,
            };
        }
    }
}
