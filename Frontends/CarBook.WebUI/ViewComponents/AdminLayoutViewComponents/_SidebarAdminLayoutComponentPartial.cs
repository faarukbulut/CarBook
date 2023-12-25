using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _SidebarAdminLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
