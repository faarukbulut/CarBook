namespace CarBook.Application.Features.Mediator.Results.CarPricingResults
{
	public class GetCarPricingWithTimePeriodQueryResult
	{
		public string Model { get; set; }
		public decimal HourlyAmount { get; set; }
		public decimal DailyAmount { get; set; }
		public decimal WeeklyAmount { get; set; }
		public string CoverImageUrl { get; set; }
	}
}
