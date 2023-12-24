using CarBook.Dto.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactor;

        public _AboutUsComponentPartial(IHttpClientFactory httpClientFactor)
        {
            _httpClientFactor = httpClientFactor;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactor.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44358/api/Abouts");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAbutDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
