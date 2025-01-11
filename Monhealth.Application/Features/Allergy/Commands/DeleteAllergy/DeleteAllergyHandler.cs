
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Allergy.Commands.DeleteAllergy
{
    public class DeleteAllergyHandler : IRequestHandler<DeleteAllergyRequest, bool>
    {
        private readonly IAllergyRepository _allergyRepository;

        public DeleteAllergyHandler(IAllergyRepository allergyRepository)
        {
            _allergyRepository = allergyRepository;
        }

        public async Task<bool> Handle(DeleteAllergyRequest request, CancellationToken cancellationToken)
        {
            var allergyId = await _allergyRepository.GetByIdAsync(request.AllergyId);
            if(allergyId == null) throw new Exception("Triệu chứng không tồn tại. ");
            _allergyRepository.Remove(allergyId);
            await _allergyRepository.SaveChangeAsync();
            return true; 
        }
    }
}