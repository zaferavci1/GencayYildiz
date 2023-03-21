using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json;
using View.Models;
using View.Models.ViewModel;

namespace View.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{Id = 1,Name="kalem",Price=100},
                new Product{Id = 2,Name="silgi",Price=50},
                new Product{Id = 3,Name="acacak",Price=60},
                new Product{Id = 4,Name="pergel",Price=67},
            };
            #region Model bazlı veri gönderimi
            //return View(products);
            #endregion
            #region Veri taşıma kontrolleri
            #region ViewBag
            /*
             * ViewBag viewe gönderilecek yada taşınalacak datayı dynamic sekilde tanımlanan bir değişkenle taşımamızı sağlayan bir 
             *      veri taşıma kontrolüdür.
             */
            //ViewBag.products = products;//dynamic var keywordunun benzeridir ama değişkenin türü runtime da belli olur.
            #endregion
            #region ViewData
            /*
             * ViewBagde olduğu gibi actiondaki datayı viewe taşıyan kontroldür.
             * ViewData veriyi boxing ederek taşır.
             */
            //ViewData["products"] = products;
            #endregion
            #region TempData
            //ViewData'da olduğu gibi actiondaki datayı viewe taşıyan kontroldür.
            //TempData'da veriyi boxing ederek taşır.
            //TemData'yı ayıran nokta TemData veriyi farklı action metotlara da taşıyabilir.
            //TempData["products"] = products;
            //Bizim TempData'da veriyi taşıyabilmek için veriyi Serialize etmemiz gerekiyor. 
            // çünkü TempData veriyi bir cookie üzerinden taşıyor ve orada veri o şekilde taşınamıyor.

            var data = System.Text.Json.JsonSerializer.Serialize(products);
            TempData["products"] = data;

            #endregion
            #endregion

            //ViewData["x"] = 5;
            //TempData["x"] = 5;
            //ViewBag.x = 5;
            return RedirectToAction("Index2");
        }
        public IActionResult Index2()
        {
            //var v1 = ViewData["x"];
            //var v2 = TempData["x"]; // Sadece TempData'ya veri geldi
            //var v3 = ViewBag.x;

            //Burada tekrardan deserializer etmemiz lazım.
            var data = TempData["products"].ToString();
            List<Product> products = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(data);


            return View();
        }
        public IActionResult Tuple()
        {
            #region ViewModel Kullanımı
            /*
             * View'e biz toplu veri göndermek için Tuple kullanırız.
             * Tuple'dan farklı olarak da view model kullanırız. ViewModel bizim göndereceğimiz nesneleri içinde barındıran ayrı bir nesne.
             */

            //User user = new User()
            //{
            //    Id = 1,
            //    Name = "Zafer",
            //    LastName = "Avcı"
            //};

            //Product product = new Product()
            //{
            //    Id = 1,
            //    Name = "Silgi",
            //    Price = 10
            //};

            //ProductUser productUser = new ProductUser()
            //{
            //    Product = product,
            //    User = user
            //};
            #endregion
            #region Tuple Kullanımı
            User user = new User()
            {
                Id = 1,
                Name = "Zafer",
                LastName = "Avcı"
            };

            Product product = new Product()
            {
                Id = 1,
                Name = "Silgi",
                Price = 10
            };

            ProductUser productUser = new ProductUser()
            {
                Product = product,
                User = user
            };
            var tuple = (product, user);
            #endregion
            return View(tuple);
        }

    }
}
