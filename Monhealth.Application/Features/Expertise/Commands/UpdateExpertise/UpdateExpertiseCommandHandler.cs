using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Expertise.Commands.UpdateExpertise
{
    public class UpdateExpertiseCommandHandler : IRequestHandler<UpdateExpertiseCommand, bool>
    {
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly IMapper _mapper;
        public UpdateExpertiseCommandHandler(IExpertiseRepository expertiseRepository, IMapper mapper)
        {
            _expertiseRepository = expertiseRepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(UpdateExpertiseCommand request, CancellationToken cancellationToken)
        {
            var checkExpertiseExisted = await _expertiseRepository.GetExpertiseByNameAsync(request.UpdateExpertiseDTO.ExpertiseName);
            if (checkExpertiseExisted != null)
            {
                throw new Exception("Chuyên môn đã tồn tại.");
            }
            var existingExpertise = await _expertiseRepository.GetByIdAsync(request.ExpertiseId);
            if (existingExpertise == null)
            {
                throw new Exception("Chuyên môn không tồn tại.");
            }
            var updateExpertise = _mapper.Map(request.UpdateExpertiseDTO, existingExpertise);
            updateExpertise.UpdatedAt = DateTime.Now;
            _expertiseRepository.Update(updateExpertise);
            await _expertiseRepository.SaveChangeAsync();
            return true;
        }
    }
}
