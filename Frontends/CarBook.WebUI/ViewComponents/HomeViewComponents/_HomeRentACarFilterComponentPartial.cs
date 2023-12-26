using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeRentACarFilterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
