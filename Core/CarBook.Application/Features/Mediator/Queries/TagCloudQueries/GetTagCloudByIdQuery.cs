using CarBook.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByIdQuery : IRequest<GetTagCloudByIdQueryResult>
    {
        public GetTagCloudByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
