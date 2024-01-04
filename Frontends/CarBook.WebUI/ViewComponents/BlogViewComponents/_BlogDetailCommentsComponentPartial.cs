using CarBook.Dto.CommentDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailCommentsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailCommentsComponentPartial(IHttpClientFactory httpClientFactor)
        {
            _httpClientFactory = httpClientFactor;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44358/api/Comments/CommentListByBlog/{id}");
            var responseMessage2 = await client.GetAsync($"https://localhost:44358/api/Comments/CommentCountByBlog/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(jsonData);
                ViewBag.commentCount = jsonData2;

                return View(values);
            }


            return View();
        }
    }
}
