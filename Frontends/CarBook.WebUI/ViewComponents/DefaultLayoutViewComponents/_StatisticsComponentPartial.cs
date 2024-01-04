using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.DefaultLayoutViewComponents
{
    public class _StatisticsComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _StatisticsComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
        {
			var client = _httpClientFactory.CreateClient();

			#region GetCarCount - 1
			var responseMessage1 = await client.GetAsync("https://localhost:44358/api/Statistics/GetCarCount");
			var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
			var values1 = JsonConvert.DeserializeObject<GetCarCountDto>(jsonData1);
			ViewBag.v1 = values1.CarCount;
			#endregion

			#region GetLocationCount - 2
			var responseMessage2 = await client.GetAsync("https://localhost:44358/api/Statistics/GetLocationCount");
			var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
			var values2 = JsonConvert.DeserializeObject<GetLocationCountDto>(jsonData2);
			ViewBag.v2 = values2.LocationCount;
			#endregion

			#region GetBrandCount - 3
			var responseMessage5 = await client.GetAsync("https://localhost:44358/api/Statistics/GetBrandCount");
			var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
			var values5 = JsonConvert.DeserializeObject<GetBrandCountDto>(jsonData5);
			ViewBag.v3 = values5.BrandCount;
			#endregion

			#region GetCarCountByFuelElectric - 4
			var responseMessage14 = await client.GetAsync("https://localhost:44358/api/Statistics/GetCarCountByFuelElectric");
			var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
			var values14 = JsonConvert.DeserializeObject<GetCarCountByFuelElectricDto>(jsonData14);
			ViewBag.v4 = values14.CarCountByFuelElectric;
			#endregion






			return View();
        }
    }
}
