using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.DefaultLayoutViewComponents
{
    public class _BecomeADriverComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
