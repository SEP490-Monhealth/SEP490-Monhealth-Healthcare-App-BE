using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Allergy.Commands.UpdateAllergy
{
    public class UpdateAllergyHandler : IRequestHandler<UpdateAllergyRequestHandler, bool>
    {
        private readonly IAllergyRepository _allergyRepository;
        public UpdateAllergyHandler(IAllergyRepository allergyRepository)
        {
            _allergyRepository = allergyRepository;
        }

        public async Task<bool> Handle(UpdateAllergyRequestHandler request, CancellationToken cancellationToken)
        {
            var allergy = await _allergyRepository.GetByIdAsync(request.AllergyId);
            if (allergy == null)
            {
                throw new KeyNotFoundException("Không tìm thấy dị ứng với ID đã cung cấp.");
            }

            var duplicateAllergy = await _allergyRepository.GetByNameAsync(request.Request.Name);
            if (duplicateAllergy != null && duplicateAllergy.AllergyId != request.AllergyId)
            {
                throw new InvalidOperationException("Tên dị ứng đã tồn tại. Vui lòng chọn tên khác.");
            }

            allergy.AllergyName = request.Request.Name;
            allergy.AllergyDescription = request.Request.Description;
            allergy.UpdatedAt = DateTime.UtcNow;

            _allergyRepository.Update(allergy);
            await _allergyRepository.SaveChangeAsync();

            return true;
        }

    }
}