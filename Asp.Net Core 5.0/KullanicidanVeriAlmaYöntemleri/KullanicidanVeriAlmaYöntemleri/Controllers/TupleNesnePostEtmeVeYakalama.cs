using KullanicidanVeriAlmaYöntemleri.Models;
using Microsoft.AspNetCore.Mvc;

namespace KullanicidanVeriAlmaYöntemleri.Controllers
{
    public class TupleNesnePostEtmeVeYakalama : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            var tuple = (new Product(), new User());
            return View(tuple);
        }
        /* YANLIŞ OLAN
         * Bind mekanizmasında tuple turde bir nesneyi yakalamk istiyorsak ilk olarak bu tuple nesnenin içerisindeki datalar-neneler-objerler üretilip verilmesi lazım. Çünkü null bir degeri çağıramayız
         */
        [HttpPost]
        //public IActionResult CreateProduct((User user,Product product) model)
        //public IActionResult CreateProduct(User user, Product product)//gönderilen data tuple nesne olduğu için yakalayamadı
        public IActionResult CreateProduct([Bind (Prefix = "Item2")]User user, [Bind(Prefix = "Item1")] Product product)
        {
            return View();
        }
    }
}
