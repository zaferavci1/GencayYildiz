using KullanicidanVeriAlmaYöntemleri.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KullanicidanVeriAlmaYöntemleri.Controllers
{
    public class Validations : Controller
    {
        public IActionResult Validation()
        {
            /*      Validation 
             * Bir degerin içinde bulunduğu sartlara uygun olması durumudur.
             * Belirlenen koşullara ve amaca uygun olup olmama durumunun kontrol edilmesidir.
             * Bu konrole göre verinin işleme tabi edilmesi durumudur.
             * 
             */

            /* Validation İşlemi Server tarafında kontrol ediliyor ise
             * Biz buna Server Side Validation deriz.
             * Client tarafında ise Client Side Validation denir. Client'a fazla güvenmeyiz Server tarafında da doğrulama da yaparız.
             * Validation Client ve Server tarafında uygulanmalıdır.
             */
            return View();
        }

        public IActionResult CreateProductValidations()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProductValidations(Product model)
        {
            /*İNANAILMAZ DERECEDE KÖTÜ KOT/MALİYET FAZLA/YÖNETİLEBİLİRLİK AZ
            if (string.IsNullOrEmpty(model.Name) && model.Name.Length<100 )
            {

            }
            */
            // ModelState: MVC'de bir type'ın data annotationsların durumunu kontrol eden ve geriye sonuç deönen bir propertydir.
            if (!ModelState.IsValid)//Fluent Validation da da ModelState ile yakalayabileceğiz
            {
                //doğrulanmaz ise 
                //loglanma
                //kullanıcı bilgilendirme
                //ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;
                var messages =ModelState.ToList();

                return View(model);// Modeli tekrar gönderdiğimiz için gidecek meseal name isimlli alana spanın içerisinde bu hata mesajını yazacak
            }

            //işlem/operasyon/algoritma burada tabi tutulur.
            return View();
        }

        /* Fluent Validation - En çok bilinen - En çok kullanılanlardan biri 
         * 
         */
    }
}