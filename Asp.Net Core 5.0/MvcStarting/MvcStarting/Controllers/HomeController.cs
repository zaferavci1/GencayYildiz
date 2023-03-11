using Microsoft.AspNetCore.Mvc;

namespace MvcStarting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
