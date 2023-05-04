using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {

            return View();
        }
        public IActionResult CreateProduct()
        {
            /*
             * Bir action metot varsayılan (Default) olarak HttpGet türündendir
             * Bu controller Get isteiğinde tetiklenecek 
             * Biz Controller dan viewa bir nesne gönderdiğğimiz zaman Binding mekanizması yine çalışacak. 
             * Binding mekanizması iki yönlü olarak da çalışabiliyor. 
             * Biz controllerdan gönderdiğimiz nesne Post edilidiğinde yeni bir nesen oluşturulmayacaktır. Bizim gönderdiğimiz nesne üzerine yazılacaktır. Gönderdiğimiz nesen post controllerına geri gönderilecektir.
             */
            Product product = new Product()
            {
                Name = "Test",
                Quantity=0
            };
            return View(product);
        }

        [HttpPost]
        //public IActionResult CreateProduct(string txtProductName, string txtQuantity)
        public IActionResult CreateProduct(Product product)
        {
            // Bu controller Post isteiğinde tetiklenecek. Mimamri bunu bilecek
            // Request neticesinde gelen dataların hepsi ait olduğu contollerın parametlerinde yakalanmaktadır
            // Form içerisindeki input nesneleri post edildiğinde bu nesnelere karşılık gelen propertyleri karşılayan bir nesne ile otomatik olarak bind edilirler
            return View();
        }
    }
}
