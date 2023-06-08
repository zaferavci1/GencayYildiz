# Moduler Tasarım
## Araba Ornegi
- Arabanın direksiyonunda çıkan sıkıntının arabanın motor aksamını veya tekerlerde bir soruna yol aşmasını önlemek amacıyla direksiyonun kendi başına bir parça olması modulerliği arttırıyor.
## Insan Ornegi
- Dis agrısının ayaklarını etkilememesi.
- Parmaktaki bir hastaligin mideyi etkilememesi.
## Dunya uzerinde her yerde bu modulerligi gorebiliriz.
## PartialView Yapılanması
- Moduler Tasarım Yapılanmasında her bir modulu ayrı bir cshtml olarak tasarlanmasını ve ihtiyaç doğrultusunda iligli parçanın cagrılıp kullanılmasını sağlayan bir yöntemdir.
- Partial klasoru ilgili view klasorunun altinda olusturulur.
- Kullanacagimiz Partial'i ilgili viewda kullanmak icinn 3 yontemimiz var:
1. TagHelper
     ### < partial name =" Dosya dizini buraya gelecek " > 
2. @Html.Partial("ilgili partial klasorunun dizini buraya gelecek.")
3. @{Html.RenderPartial("ilgili dosya dizini")}
