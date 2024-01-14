using CarBook.Application.Features.Mediator.Results.ReviewResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.ReviewQueries
{
	public class GetReviewByCarIdQuery : IRequest<List<GetReviewByCarIdQueryResult>>
	{
		public GetReviewByCarIdQuery(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
