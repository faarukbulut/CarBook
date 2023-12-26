using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Queries.StatisticsResult;
using CarBook.Application.Features.Mediator.Results.StatisticsResult;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsResult
{
    public class GetAvgRentPriceForHourlyQueryHandler : IRequestHandler<GetAvgRentPriceForHourlyQuery, GetAvgRentPriceForHourlyQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAvgRentPriceForHourlyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForHourlyQueryResult> Handle(GetAvgRentPriceForHourlyQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAvgRentPriceForHourly();
            return new GetAvgRentPriceForHourlyQueryResult
            {
                AvgRentPriceForHourly = values,
            };
        }
    }
}
