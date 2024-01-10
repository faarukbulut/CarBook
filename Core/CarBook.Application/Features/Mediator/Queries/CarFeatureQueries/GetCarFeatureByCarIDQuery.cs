using CarBook.Application.Features.Mediator.Results.CarFeatureResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.CarFeatureQueries
{
	public class GetCarFeatureByCarIDQuery : IRequest<List<GetCarFeatureByCarIDQueryResult>>
	{
		public GetCarFeatureByCarIDQuery(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
