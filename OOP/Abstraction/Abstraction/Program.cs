#region Abstraction Nedir?
/*
 * Abstraction bir sınıfın memberlarından ihtiyaç noktasında gerekli olanları gösterip, gereksiz olanları göstermemek demek oluyor.
 * Abstraciton'ın interface'ler yada abstarct class'larla doğrudan ilişkiai yoktur.
 * Bir operasyon anında kullanılacak olan sınıfın sadece o andaki opersayona ait olan memeberlarını getirmek için(yani abstraction)
 *      ilgili memberları temsil edebilecek bir referansa ihtiyaç olacaktır.
 * Bu durumu classlarla öyle yada böyle gerçekleştirebilirsiniz lakin bu duruma en yatkın olanlar abstract classlar ve interfacelerdir.
 * Bir sınıfın birden fazla interface ile referans edilebilme durumları interfacelerin abstraciton işlemleri için daha uygun yapılar 
 *      olduğunu kanıtlıyor.
 * Abstraction davranışı kalıtım verme durumunda inheritance,
 *                       memberları gizleme/ayıklama yaptığından dolayı encapsulation ve
 *                       farklı referanslar kullandığı için inheritance kavramlarıyla doğrudan bağlantılıdır.
 * Abstarciton'ın amacı geliştiriciden bir sınıfa karşın olabilecek gereksiz ayrıntıları gizlemeyerek karmaşıklığı engellemektir.
 * O sınıftan üretilmiş bir instance'ı kullanırken ne yapabileceğini göstermek ama yapabilceği hakkında bilgi vermemmektir.
 * Ayrıca yerine göre uygulama ayrıntılarını gizlemek ilgil davranışların erişilebilir olmasını sağlamakta abstarction'ın bir hedefi diyebiliriz.
 * 
 */
#endregion
