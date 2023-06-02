# Layout
## Web Sayfalarının olmazsa olmazıdır.
## Sayfadan sayfaya gezinirken kullanıcıya tutarlı bir deneyim sağlar. Her sayfada ortak alanlar için tutarlılık sağlar.
## Tutarlı bir düzene sahip bir web sitesi oluşturmak için kullanılır.
## Layout dosyası özünde bir .cshtml dosyasıdır.
## AspNet Core MVC uygulamalarında layout dosyası View klasörünün altındaki Shared klasörü altında _Layout.cshtml oluşturulur. Bu durum genellikle böyledir.
# RenderBody()
## Layout üzerinde o anki render edilen View'ın resultunu nereye basılacağını ifade eden fonksiyondur.

# RenderSection() 
## Layout içerisinde isimsel bölümler oluşturmamızı sağlar. İhtiyaç doğrultusunda bu bölümlere render edilen view'lerden de içerik aktarılabilir.