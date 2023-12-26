using CarBook.Application.Features.Mediator.Results.StatisticsResult;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.StatisticsResult
{
    public class GetAvgRentPriceForHourlyQuery : IRequest<GetAvgRentPriceForHourlyQueryResult>
    {
    }
}
