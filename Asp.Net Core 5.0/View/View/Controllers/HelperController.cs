using Microsoft.AspNetCore.Mvc;
using View.Models;

namespace View.Controllers
{
    public class HelperController : Controller
    {
        /*
         * Adı üstünde yardımcı metotlardır.
         */
        public IActionResult UrlHelper()
        {
            /*
             * Asp.Net Core Mvc uygulamlaarında bizlere url oluşturmak için yardımcı metotlar içeren ve o anki url e ait bizlere bilgi veren bir sınıftır
             */
            Url.Action("UrlHelper");
            Url.ActionLink();//local ve host bilgisini de saklar url de
            //Url.ActionContext; O andaki url'e dair tüm bilgilere erişmemizi sağlayan propertydir.
            return View();
        }
        public IActionResult HtmlHelper()
        {
            /*
             * Html etiketlerini server tabanlı oluşturmanızı sağlayan sözde(bize serverda daha fazla yük bindiriyor) yardımcı metotları barındırmakta
             * Hedeflenen .cshtml doayalarını render etmemizi sağlayan yapılardır.
             * O anki contexte dair bilgi edinmemizi sağlar
             * Veri taşıma kontrollerine erişim sağlar
             */
            //Html.Partial() hedef view'ı render etmemizi sağlayan metottur.
            User u = new()
            {
                Id = 1,
                LastName = "avcı",
                Name = "zafer"
            };
            ViewBag.Mesaj = "Merhaba";

            //Html.RenderPartial metodu hedef viewı render etmemizi sağlayan metottur. Html Render partial metodu sayfanın textwriter'ını kullandığı için Html.Patial'a göre daha performanslıdır. Ayriyetten scope içerisinde kullanılır.

            //Html.ActiomnLink Url oluşturur.



            return View();
        }
    }
}
