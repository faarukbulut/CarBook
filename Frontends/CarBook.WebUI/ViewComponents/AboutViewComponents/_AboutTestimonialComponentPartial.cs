using CarBook.Dto.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
	public class _AboutTestimonialComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactor;

		public _AboutTestimonialComponentPartial(IHttpClientFactory httpClientFactor)
		{
			_httpClientFactor = httpClientFactor;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactor.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:44358/api/Testimonials");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
				return View(values);
			}

			return View();
		}
	}
}
