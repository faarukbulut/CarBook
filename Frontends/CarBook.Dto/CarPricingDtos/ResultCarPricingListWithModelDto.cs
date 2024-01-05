namespace CarBook.Dto.CarPricingDtos
{
	public class ResultCarPricingListWithModelDto
	{
		public string Model { get; set; }
		public decimal HourlyAmount { get; set; }
		public decimal DailyAmount { get; set; }
		public decimal WeeklyAmount { get; set; }
		public string CoverImageUrl { get; set; }
		public string BrandName { get; set; }
	}
}
