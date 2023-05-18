using Microsoft.AspNetCore.Mvc;

namespace KullanicidanVeriAlmaYöntemleri.Controllers
{
    public class AjaxTabanliController : Controller
    {
        public class AjaxData
        {
            public string A { get; set; }
            public string B { get; set; }

        }
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VeriAl(AjaxData data)
        {

            return View();
        }
    }
}
