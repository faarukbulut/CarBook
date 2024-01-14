﻿namespace CarBook.Application.Features.Mediator.Results.ReviewResults
{
	public class GetReviewByCarIdQueryResult
	{
		public int ReviewID { get; set; }
		public string CustomerName { get; set; }
		public string CustomerImage { get; set; }
		public string Comment { get; set; }
		public int RatingValue { get; set; }
		public DateTime ReviewDate { get; set; }
		public int CarID { get; set; }
	}
}
