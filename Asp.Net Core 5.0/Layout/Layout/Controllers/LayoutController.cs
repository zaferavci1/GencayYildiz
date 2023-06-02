using Microsoft.AspNetCore.Mvc;

namespace Layout.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Sayfa1()
        {
            ViewBag.mesaj = "merhaba Render body fonksiyonu için deneme yapıyorum.";
            return View();
        }
    }
}
