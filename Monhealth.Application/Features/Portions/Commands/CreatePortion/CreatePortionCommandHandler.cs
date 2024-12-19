using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Portions.Commands.CreateFoodPortion
{
    public class CreatePortionCommandHandler : IRequestHandler<CreatePortionCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IPortionRepository _portionRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IFoodPortionRepository _foodPortionRepository;

        public CreatePortionCommandHandler(IMapper mapper, IPortionRepository portionRepository, IFoodRepository foodRepository, IFoodPortionRepository foodPortionRepository)
        {
            _portionRepository = portionRepository;
            _foodRepository = foodRepository;
            _foodPortionRepository = foodPortionRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreatePortionCommand request, CancellationToken cancellationToken)
        {
            // tao khau phan an
            var portion = new Portion
            {
                PortionId = Guid.NewGuid(),
                PortionSize = request.PortionSize,
                PortionWeight = request.PortionWeight,
                MeasurementUnit = request.MeasurementUnit,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            _portionRepository.Add(portion);

            // lay cac mon an theo FoodIds
            var food = await _foodRepository.GetByIdAsync(request.FoodId);
            if (food == null)
            {
                throw new Exception("Món ăn không tồn tại.");
            }
            // lien ket mon an voi khau phan an
            var foodPortion = new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = food.FoodId,
                PortionId = portion.PortionId
            };
            _foodPortionRepository.Add(foodPortion);
            await _portionRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
