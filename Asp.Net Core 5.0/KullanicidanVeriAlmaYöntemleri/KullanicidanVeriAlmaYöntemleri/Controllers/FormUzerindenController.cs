using KullanicidanVeriAlmaYöntemleri.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KullanicidanVeriAlmaYöntemleri.Controllers
{
    public class FormUzerindenController : Controller
    {
        public class Model
        {
            public string Value1 { get; set; }
            public string Value2 { get; set; }
            public string Value3 { get; set; }
        }

        public class MyClass
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
        }
        public IActionResult GetProducts()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        //public IActionResult VeriAl(IFormCollection datas)
        //public IActionResult VeriAl(string txtValue1,string txtValue2, string txtValue3)
        //public IActionResult VeriAl(Model model)
        //public IActionResult VeriAl(Product model)
        public IActionResult VeriAl(MyClass model)
        {
            //var value1 = (string)datas["txtValue1"];
            //var value2 = datas["txtValue2"];
            //var value3 = datas["txtValue3"];
              
            return View();
        }
    }
}
