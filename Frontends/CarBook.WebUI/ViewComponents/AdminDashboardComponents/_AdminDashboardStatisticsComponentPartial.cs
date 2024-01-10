using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.AdminDashboardComponents
{
    public class _AdminDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
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

            #region GetBlogCount - 3
            var responseMessage3 = await client.GetAsync("https://localhost:44358/api/Statistics/GetBlogCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            var values3 = JsonConvert.DeserializeObject<GetBlogCountDto>(jsonData3);
            ViewBag.v3 = values3.BlogCount;
            #endregion

            #region GetBrandCount - 4
            var responseMessage4 = await client.GetAsync("https://localhost:44358/api/Statistics/GetBrandCount");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            var values4 = JsonConvert.DeserializeObject<GetBrandCountDto>(jsonData4);
            ViewBag.v4 = values4.BrandCount;
            #endregion

            return View();
        }
    }
}
