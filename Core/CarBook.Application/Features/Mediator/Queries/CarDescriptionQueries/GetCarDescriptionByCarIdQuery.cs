using CarBook.Application.Features.Mediator.Results.CarDescriptionResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.CarDescriptionQueries
{
	public class GetCarDescriptionByCarIdQuery : IRequest<GetCarDescriptionQueryResult>
	{
		public GetCarDescriptionByCarIdQuery(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
