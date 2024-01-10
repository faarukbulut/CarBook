﻿namespace CarBook.Application.Features.Mediator.Results.CarFeatureResults
{
	public class GetCarFeatureByCarIDQueryResult
	{
		public int CarFeatureID { get; set; }
		public int FeatureID { get; set; }
		public string FeatureName { get; set; }
		public bool Available { get; set; }
	}
}
