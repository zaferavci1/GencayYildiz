using Microsoft.AspNetCore.Mvc;
using MvcStarting.Model;

namespace MvcStarting.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            Product product = new(); 
            //Veri üretildi
            return View();
        }
    }
}
