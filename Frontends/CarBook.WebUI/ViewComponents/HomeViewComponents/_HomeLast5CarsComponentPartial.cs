using CarBook.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeLast5CarsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeLast5CarsComponentPartial(IHttpClientFactory httpClientFactor)
        {
            _httpClientFactory = httpClientFactor;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44358/api/Cars/GetCarLast5WithBrand");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarLast5WithBrandDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
