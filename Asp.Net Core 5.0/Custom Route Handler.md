# Custom Route Handler
* > Herhagi belirlenmiş route şemasının controller sınıflarından ziiyade busiiness mantığında karsilanması ve orada is gorup response dınulmesi operasyonudur.
* Belirli spesifik çalışmalarda kullanırız. 
* Genel geçer operasyonlarda klasik controller mekanizmasi ile gelen requesti yakalayıp gerekli operasyonu gerçekleştireceksin...
* //https://localhost:5001/example-route enpointine gelen herhangi bir istek Controller'dan ziyade direkt olarak buradaki fonksiyon tarafından karşılanacaktır.
// Herhangi bir http isteği olabilir.

*  app.UseStaticFiles();// bu middleware bizim wwwroot klasörüne erişmmemizi sağlıyor.
* using MagickImage magickImage= new MagickImage(fileInfo); // işimiz bittiği zaman garbage collecktor ilgili nesneyi imha edecek