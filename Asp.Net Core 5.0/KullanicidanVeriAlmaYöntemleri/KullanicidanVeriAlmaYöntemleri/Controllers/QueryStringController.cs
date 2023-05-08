using Microsoft.AspNetCore.Mvc;

namespace KullanicidanVeriAlmaYöntemleri.Controllers
{
    public class QueryData
    {
        public int A { get; set; }
        public string B { get; set; }
    }
    public class QueryStringController : Controller
    {
        /*
         * Güvenlik gerektirmeyen verilerin URL üzerinden tasinması için kullanilan yapılanmadır.
         *   https://.......com/sehir/ankara?ilce=cankaya
         *   Yapilan requestın türü her ne olursa olsun query String degerleri tasinabilir.
         */

        //public IActionResult VeriAl(string a, string b)
        public IActionResult VeriAl(QueryData data)
        {
            var queryString = Request.QueryString;//Request yapılan endpoint'e query string parametresi eklenmiş mi eklenmemiş mi bunu kontrol eder.
            //var a = Request.Query["a"].ToString();
            //var  b = Request.Query["b"].ToString();
            
            return View();
        }
    }
}
