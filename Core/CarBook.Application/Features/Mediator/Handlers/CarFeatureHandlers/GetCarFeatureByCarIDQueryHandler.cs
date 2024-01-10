using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using CarBook.Application.Features.Mediator.Results.CarFeatureResults;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
	public class GetCarFeatureByCarIDQueryHandler : IRequestHandler<GetCarFeatureByCarIDQuery, List<GetCarFeatureByCarIDQueryResult>>
	{
		private readonly ICarFeatureRepository _repository;

		public GetCarFeatureByCarIDQueryHandler(ICarFeatureRepository repository)
		{
			_repository = repository;
		}

		public async Task<List<GetCarFeatureByCarIDQueryResult>> Handle(GetCarFeatureByCarIDQuery request, CancellationToken cancellationToken)
		{
			var values = _repository.GetCarFeaturesByCarId(request.Id);
			return values.Select(x =>  new GetCarFeatureByCarIDQueryResult
			{
				Available = x.Available,
				CarFeatureID= x.CarFeatureID,
				FeatureID= x.CarFeatureID,
				FeatureName	= x.Feature.Name
			}).ToList();
		}
	}
}
