using Microsoft.AspNetCore.Mvc;

namespace KullanicidanVeriAlmaYöntemleri.Controllers
{
    public class RouteUzerindenController : Controller
    {
        public class RouteData
        {
            public string A { get; set; }
            public string B { get; set; }
            public int Id { get; set; }
        }

        public IActionResult Index(object id)
        {
            return View();
        }

        public IActionResult Route(string id)
        {
            /*
             * QueryStringe göre güvenlik anlamında daha iyi
             */
            var values = Request.RouteValues;
            return View();
        }

        //public IActionResult CustomRoute(string id, string a, string b)
        public IActionResult CustomRoute(RouteData datas)
        {
            return View();
        }


    }
}
