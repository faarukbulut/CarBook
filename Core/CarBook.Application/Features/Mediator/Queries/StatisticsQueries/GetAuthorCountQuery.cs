using CarBook.Application.Features.Mediator.Results.StatisticsResult;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetAuthorCountQuery : IRequest<GetAuthorCountQueryResult>
    {
    }
}