using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
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

            #region GetAuthorCount - 3
            var responseMessage3 = await client.GetAsync("https://localhost:44358/api/Statistics/GetAuthorCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            var values3 = JsonConvert.DeserializeObject<GetAuthorCountDto>(jsonData3);
            ViewBag.v3 = values3.AuthorCount;
            #endregion

            #region GetBlogCount - 4
            var responseMessage4 = await client.GetAsync("https://localhost:44358/api/Statistics/GetBlogCount");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            var values4 = JsonConvert.DeserializeObject<GetBlogCountDto>(jsonData4);
            ViewBag.v4 = values4.BlogCount;
            #endregion

            #region GetBrandCount - 5
            var responseMessage5 = await client.GetAsync("https://localhost:44358/api/Statistics/GetBrandCount");
            var jsonData5= await responseMessage5.Content.ReadAsStringAsync();
            var values5 = JsonConvert.DeserializeObject<GetBrandCountDto>(jsonData5);
            ViewBag.v5 = values5.BrandCount;
            #endregion

            #region GetAvgRentPriceForHourly - 6
            var responseMessage6 = await client.GetAsync("https://localhost:44358/api/Statistics/GetAvgRentPriceForHourly");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            var values6 = JsonConvert.DeserializeObject<GetAvgRentPriceForHourlyDto>(jsonData6);
            ViewBag.v6 = values6.AvgRentPriceForHourly;
            #endregion

            #region GetAvgRentPriceForDaily - 7
            var responseMessage7 = await client.GetAsync("https://localhost:44358/api/Statistics/GetAvgRentPriceForDaily");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            var values7 = JsonConvert.DeserializeObject<GetAvgRentPriceForDailyDto>(jsonData7);
            ViewBag.v7 = values7.AvgRentPriceForDaily;
            #endregion

            #region GetAvgRentPriceForWeekly - 8
            var responseMessage8 = await client.GetAsync("https://localhost:44358/api/Statistics/GetAvgRentPriceForWeekly");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            var values8 = JsonConvert.DeserializeObject<GetAvgRentPriceForWeeklyDto>(jsonData8);
            ViewBag.v8 = values8.AvgRentPriceForWeekly;
            #endregion

            #region GetCarCountByTransmissionIsAuto - 9
            var responseMessage9 = await client.GetAsync("https://localhost:44358/api/Statistics/GetCarCountByTransmissionIsAuto");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            var values9 = JsonConvert.DeserializeObject<GetCarCountByTransmissionIsAutoDto>(jsonData9);
            ViewBag.v9 = values9.CarCountByTransmissionIsAuto;
            #endregion

            #region GetBrandNameByMaxCar - 10
            var responseMessage10 = await client.GetAsync("https://localhost:44358/api/Statistics/GetBrandNameByMaxCar");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            var values10 = JsonConvert.DeserializeObject<GetBrandNameByMaxCarDto>(jsonData10);
            ViewBag.v10 = values10.BrandNameByMaxCar;
            #endregion

            #region GetBlogTitleByMaxBlogComment - 11
            var responseMessage11 = await client.GetAsync("https://localhost:44358/api/Statistics/GetBlogTitleByMaxBlogComment");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            var values11 = JsonConvert.DeserializeObject<GetBlogTitleByMaxBlogCommentDto>(jsonData11);
            ViewBag.v11 = values11.BlogTitleByMaxBlogComment;
            #endregion

            #region GetCarCountByKmSmallerThen1000 - 12
            var responseMessage12 = await client.GetAsync("https://localhost:44358/api/Statistics/GetCarCountByKmSmallerThen1000");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            var values12 = JsonConvert.DeserializeObject<GetCarCountByKmSmallerThen1000Dto>(jsonData12);
            ViewBag.v12 = values12.CarCountByKmSmallerThen1000;
            #endregion

            #region GetCarCountByFuelGasolineOrDiesel - 13
            var responseMessage13 = await client.GetAsync("https://localhost:44358/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            var values13 = JsonConvert.DeserializeObject<GetCarCountByFuelGasolineOrDieselDto>(jsonData13);
            ViewBag.v13 = values13.CarCountByFuelGasolineOrDiesel;
            #endregion

            #region GetCarCountByFuelElectric - 14
            var responseMessage14 = await client.GetAsync("https://localhost:44358/api/Statistics/GetCarCountByFuelElectric");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            var values14 = JsonConvert.DeserializeObject<GetCarCountByFuelElectricDto>(jsonData14);
            ViewBag.v14 = values14.CarCountByFuelElectric;
            #endregion

            #region GetCarBrandAndModelByRentPriceDailyMax - 15
            var responseMessage15 = await client.GetAsync("https://localhost:44358/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            var values15 = JsonConvert.DeserializeObject<GetCarBrandAndModelByRentPriceDailyMaxDto>(jsonData15);
            ViewBag.v15 = values15.CarBrandAndModelByRentPriceDailyMax;
            #endregion

            #region GetCarBrandAndModelByRentPriceDailyMin - 16
            var responseMessage16 = await client.GetAsync("https://localhost:44358/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
            var values16 = JsonConvert.DeserializeObject<GetCarBrandAndModelByRentPriceDailyMinDto>(jsonData16);
            ViewBag.v16 = values16.CarBrandAndModelByRentPriceDailyMin;
            #endregion


            return View();
        }
    }
}
