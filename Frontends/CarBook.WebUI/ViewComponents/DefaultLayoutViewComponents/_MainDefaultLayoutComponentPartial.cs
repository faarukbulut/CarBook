using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.DefaultLayoutViewComponents
{
    public class _MainDefaultLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(string p)
        {
            ViewBag.p = p;
            return View();
        }
    }
}
