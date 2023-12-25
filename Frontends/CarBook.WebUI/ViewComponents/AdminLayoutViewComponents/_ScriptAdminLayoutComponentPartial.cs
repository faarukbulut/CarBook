using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _ScriptAdminLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
