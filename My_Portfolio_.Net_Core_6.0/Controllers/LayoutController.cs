using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio_.Net_Core_6._0.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
