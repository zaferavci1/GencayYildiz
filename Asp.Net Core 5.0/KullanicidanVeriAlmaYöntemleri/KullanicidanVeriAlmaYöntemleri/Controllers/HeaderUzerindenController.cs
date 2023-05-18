using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KullanicidanVeriAlmaYöntemleri.Controllers
{
    public class HeaderUzerindenController : Controller
    {
        public IActionResult VeriAl()
        {
            var headers = Request.Headers.ToList();
            return View();
        }
    }
}
