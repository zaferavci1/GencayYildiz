using Microsoft.AspNetCore.Mvc;

namespace View.Controllers
{
    public class TagHelperController : Controller
    {
        public IActionResult TagHelper()
        {
            /*
             * Tag helpers daha okunabilir, anlaşılabilir ve kolay geliştirilebilir bir view inşa etmemizi sağlayan; Asp.Net Core ile birlikte Html Helpersların yerine gelen yapılardır. 
             * View'deki kod maaliyetini oldukça düşürmektedir.
             */
            return View();
        }
    }
}
