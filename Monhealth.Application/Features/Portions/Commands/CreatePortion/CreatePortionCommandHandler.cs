using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Commands.CreateFoodPortion
{
    public class CreatePortionCommandHandler : IRequestHandler<CreatePortionCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IPortionRepository _portionRepository;
        private readonly IFoodRepository _foodRepository;

        public CreatePortionCommandHandler(IMapper mapper, IPortionRepository portionRepository, IFoodRepository foodRepository)
        {
            _portionRepository = portionRepository;
            _foodRepository = foodRepository;
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
            var foods = await _foodRepository.GetByIdsAsync(request.FoodIds);
            if(foods.Count != request.FoodIds.Count)
            {
                // Neu mon an khong ton tai => tra ve loi
                var missingFoodIds = request.FoodIds.Except(foods.Select(f => f.FoodId)).ToList();
                throw new Exception($"Món ăn với ID không tồn tại: {string.Join(", ", missingFoodIds)}");
            }

            // lien ket mon an voi khau phan an
            var foodPortions = new List<FoodPortion>();
            foreach(var food in foods)
            {
                var foodPortion = new FoodPortion
                {
                    FoodPortionId = Guid.NewGuid(),
                    FoodId = food.FoodId,
                    PortionId = portion.PortionId
                };
                foodPortions.Add(foodPortion);
                food.FoodPortions.Add(foodPortion);
            }

            await _foodRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
