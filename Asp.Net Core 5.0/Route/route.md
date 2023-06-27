# Route
* >Gelecek olan isteğin hangi rotaya göre gideceğini belirleyen sablonlardır.
* >{} süslü parantezler route üzerinde parametrelere denk gelir.
* >MapControllerRoute() bize MapDefaultControllerRoute() metodundan farklı olarak customRoute hazılamamıza yardımcı olacak.
    * her custom route ın unique bir ismi olacak 
* >endpoints.MapControllerRoute("Default2", "anasayfa", new { controller = "Home", action = "Index" }); bu şekilde static bir route belilremiş olduk. Anasayfaya giderken direk belirlediğimiz controller üzerindeki actiona gidilecek.

*  @Html.ActionLink("Anasayfa", "Index", "Home");
 <br />
  a asp-action="Index" asp-controller="Home">Ana Sayfa</a> <br>
    * >cshtml sayfasında yapacağımız herhangi bir  action yönlendirmesi için htmlHelper vey TagHelper'lara verdiğimiz parametreler ile mimari bunlara en uygun rotayı seçip ona göre yönlendirme yapacak.

## Parametreler
* Biz route üzerinden süslü parantezler ile parametreler belirleyip bunu alıyoruz.
* Prametreleri KullanıcıdanVeriAlma yollarında yaptığımız gibi aynı şekillerde yakalayabiliriz. İster action metotta class ile veya metot parametresi ile yakalayabiliriz.
* Bu parametreler route üzerinden istediğimiz türde verebiliriz. 
    * Genel olarak string ile yakalarız metotta.
## Route Constraints
* > Route üzerinden allacağımız parametrelerin türlerini belirtmek için kullanırız. {id : int } bu şekilde id nin sadece integer bir değer alabilmesini sağlıyoruz. 
* > Integerdan farklı bir sayısal tür yazamıyoruz(Genel olarak).
* > Metinsel ifadeler için ise string ile birçok türü karşıladığımız çin belirtmemize gerek kalmıyor.
* > Metinsel ifadenin kaç karakter olabilceğini söyleyebiliriz.
    {x;length(12)?} burada x için girilecek parmetre 12 karakter olacak diyoruz.

## Custom Constraint
* > Constraint isimli bir klasörde tutarız.
* İçerisinde bir class ekleriz ve IRouteConstraint den implement ediyoruz.
* Bize route üzerinden  
        HttpContext httpContext,  
        IRouter route,   
        string routeKey,   
        RouteValueDictionary values,   
        RouteDirection routeDirection     
        bu verileri elde etmemizi sağlar.
* Uygulamaya eklememiz lazım bunun için ConfigureServices a services.Configure<RouteOptions>(options => options.ConstraintsMap.Add("custom",typeof(CustomConstraint)))  
şeklinde ekleriz. 
* id prametresine id:custom diyerek ekleme yapıyoruz. Araya giriyoruz.

## Attribute Routing
* > Controller gelen istekte kendisine geleceği rotayı belirleyebilmektedir. Kendi üzerinde belirler. Route Attribute'u sayesinde.
* [Route("[controller]/[action]")]
* >Stratupda MapControllers a eklememiz gerek. Bu bizim controller üzerinden rota belirlememizi sağlıyor.
* > Route şablonları özelleştirme:
+ [Route("ana/[action]")]  
bu tür şablonlarda hangi actionun tetikleneceğini de belirlemek istiyorsak o actionın üstyüne gelip yine attribute kullanarak bunu yapıyoruz.
* [Route("ana")]  
[Route("[action]")]   
[Route("in")]   
bu şekilde attribute routing ile bu tip belirlemeler yapıyoruz.  

* > MVC projelerinde Route şablonları Startup dosyasında hepsi belirleniyordur. Ama API yapılanmalarında controller bazlı route yapılanmasını görürüz.