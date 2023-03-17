using Microsoft.AspNetCore.Mvc;
using MvcStarting.Model;

namespace MvcStarting.Controllers
{
    [NonController]
    public class ProductController : Controller
    {
        #region Non Action Ve Non Controller
        /*
         * controller içerisinde bir iş yapılmaz. Controller bir yönetim yeridir.
         * Bir isteğe göre o isteğe yönelik neler yapılacağının beynidir orası. Komut verir ve işlme yapılır.
         * Controller içerisindeki bütün metotlar bir action metottur.
         * Bizim request almamsı gereken metotlarımız için NonAction attribute'u eklememiz gerekiyor.
         *      Sadece algoritma,iş yapan bir metot olacaktır.
         */
        #endregion

        public IActionResult GetProducts()
        {
            return View();
        }

        [NonAction]
        public void X()//X metotu artık bir istek karşılamayacak
        {

        }
    }
}
