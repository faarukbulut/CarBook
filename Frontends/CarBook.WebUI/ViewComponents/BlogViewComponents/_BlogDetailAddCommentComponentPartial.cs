using CarBook.Dto.CommentDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailAddCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.blogID = id;

            var createCommentDto = new CreateCommentDto();
            return View(createCommentDto);
        }
    }
}
