# Middleware
* Middleware clientten gelen requeste karşılık gelen isteğe cevap olarak verilecek response a kadar geçen arada yapılacak işlemleri gerçekleştirmek ve gidişata yön veren kısımdır.
* Hangi yazılım dili olursa olsun bizim response ve request arasında gerçekleşen herşey middleware olarak adlandırılır.
* > Middlewareler sarmal bir şekilde devam eder. İç içe devam eder. Rekürsif bie şekilde ilerleyebilir.
* Configure metodu içerisinde middlewareler çağrılır. 
* Asp.NET Core miamrisinde middlewareler use adı ile başlar.
* Middlewarelerde tetilenme sırası önemlidir.
* Hazır middlewareler ***Run-Use-Map-MapWhen***
## Run Metodu
* Run fonksiyonu kendisinden sonra gelen metodu tetiklemez.
* Akış kesilecek ve iç içe olan middlewareler geri dönerek sonucu verecek.
* Kısa devre metodur.
## Use Metodu
* Sıradan sade bir middleware. Araya girer kendisinden sonrakini çağırır bitişe doğru da kendinden öncekini çağırırarak devam eder.
* Use metodu ***task*** parametresi de alır. task.Invoke(); metodu çağrıldıpında kendisinden bir sonraki middleware i çağırır.
## Map Metodu
* Gelen path(endpointe) göre filtreleme yapmak için kullanılır. Gelen Route üzerinden tetiklenen map metodu içierisinden isteğe göre middleware çağrılır.
## MapWhen Metodu
* Map'de gelen endpointe göre filtreleme işlemi yapılırken MapWhen metodunda ise gelen requestin herhangi bir özelliğine bakilarak filtreleme işlemi yapılıyor.
 
# Özel Middleware Oluşturma
* Oluşturduğumuz Middlewarein kendi işlmelerini yaptıktan sonra kendisinden sonra gelecek olan middlewarein tetiklenmesi için o middlewarei işaretleyecek olan delegatein belirlenmesi gerekiyor.  
Constructor kullanılabilir.
* Mimarideki bütün middlewareler varsayılan olarak IApplicationBuilder dönderiyor.