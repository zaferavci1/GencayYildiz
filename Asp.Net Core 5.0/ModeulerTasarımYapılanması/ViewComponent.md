# Partial View 
- Partial View yapılanması ihtiyacı olan verilerli controller üzerinden sağlanması Controller üzerindeki maliyeti arttırmakta ve SOLID prensipleri dışına çıkılmaktadır.
- PartialView yapısal olarak controller üzerinden beslenmektedir.

# View Component
- İhtiyacı olan dataları controller üzerinden değil direkt kendi cs dosyasından elde etmektedir. Boylece controller uzerindeki luzumsuz maliyeti ortadan kaldırmaktadır.
- İki yapılanmadan oluşuyor. Bir kısmı .cshtml diğeri .cs dosyası üzerindedir.
- ViewComponent adında bir klasör olusturulur.
- cs dosyası isimlendirilmesinde ViewComponent adettendir sonuna eklenir.
- cs dosyası ViewComponent'dan türer.
- cs dosyası içerisinde Invoke metodu; tasarlanan viewcomponent cagrilip render edildiginde icerisinde calismasini isteidigimiz kodlar bu imzada bir metodun içerisinde yazilir.
- Render edilecek view(.cshtml) dosyası genellikle 2 yerde tutulur. 
     1. Olarak view'ın kullanılacak olduğu controller View klasorunun içerisinde Components klasoru altında cs dosyası ile aynı adı taşıyan klasorun altında bulunmalıdır.
     2. View klasoru altındaki Shared klasorununiçince Components klasoru ve onun içinde cs dosyası ile aynı isme sahip klasorun içerisinde bulunur.
- İlgili viewda @Component.InvokeAsync("cs dosyasının ismi gelecek."); Bu şekilde ilgili viewda çağırmış olacağız.
