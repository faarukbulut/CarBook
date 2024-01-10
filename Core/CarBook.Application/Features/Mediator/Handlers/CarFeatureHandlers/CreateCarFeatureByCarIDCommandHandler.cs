using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class CreateCarFeatureByCarIDCommandHandler : IRequestHandler<CreateCarFeatureByCarIDCommand>
    {
        private readonly ICarFeatureRepository _repository;

        public CreateCarFeatureByCarIDCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarFeatureByCarIDCommand request, CancellationToken cancellationToken)
        {
            _repository.CreateCarFeatureByCarId(new CarFeature
            {
                Available = false,
                CarID = request.CarID,
                FeatureID = request.FeatureID
            });
        }
    }
}
