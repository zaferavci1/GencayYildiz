using Microsoft.AspNetCore.Mvc;
using MvcStarting.Model;

namespace MvcStarting.Controllers
{
    public class ActionTypesController : Controller
    {
        #region ViewResult
        //public ViewResult GetProducts()
        //{
        //    ViewResult result = View();
        //    return result;
        //}
        #endregion
        #region PartialViewResult
        //ViewResult'dan temel farkı client tabanlı yapılan Ajax  isteklerinde kullanılır.
        //Mesela sayafanın bütününü ViewResult oluşturur ama sayfanın bir bölümünü belirli bir ksımını PartialViewResult oluşturur.
        //Bir sayfada bir yere tıkladığımızda sayfanın tamamı değilde bir kısmı yenileniyorsa bu durum PartialViewResult'dır.
        //public PartialViewResult GetProducts()
        //{
        //    PartialViewResult result = PartialView();
        //    return result;
        //} 
        #endregion
        #region JsonResult
        // Üretilen datayı Json türüne dönüştürüp üreten bir action türüdür.

        //public JsonResult GetProducts()
        //{
        //    JsonResult result = Json(new Product
        //    {
        //        Name = "terlik",
        //        Id = 1
        //    });
        //    return result;
        //}
        #endregion
        #region EmptyResult
        //Bazen gelen istekler durumunda bir iey döndürmek istemeyiz.
        //public EmptyResult GetProducts()
        //{
        //    return new EmptyResult();
        //}
        #endregion
        #region ContentResult
        //İstek neticesinde geriye bir metinsel değer dödnürmek istiyorsak ContentResult action metodunu kullanmalıyız.
        //public ContentResult GetProducts()
        //{
        //    ContentResult result = Content("Sebepsiz boş yere ayrılacaksan");
        //    return result;
        //    //Göderilen sayfanın formatı artık bir txt dir html değildir.  
        //}
        #endregion
        #region ActionResult
        //Gelen bir istek neticesinde geriye döndürelecek action türleri değişkenlik gösterebildiği durumlarda 
        //      kullanılan bir action türüdür.
        //Actio resultların Base'i atasıdır.
        //public ActionResult GetProducts()
        //{
        //    if (true)
        //    {
        //        return Content("merhaav");
        //    }
        //    else
        //    {
        //        return PartialView(new object());
        //    }
        //    return Json(new object());
        //}
        #endregion
    }
}
