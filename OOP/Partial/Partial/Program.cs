#region Partial Yapılanmalar Nelerdir?
/*
 * Partial yapılanmalar adı üstünde birer parçadırlar. Lakin bir bütünün parçalarıdır. 
 * Bir class'ın, interface'in yahut struct'ın aynı veya farklı dosyalarda birden fazla parçasının tasarlanması lakin bu parçaların 
 *      özünde bir bütün olarak kullanılmasını sağlayan, kodun daha organize ve kolay olmasını sağlayan yapılanmadır.
 * Bir nesne üretilmeye çalışıldığında özünde tek bir nesne üretilecektir.
 */
#endregion
#region Partial Yapılanmaların Kullanım Amacı
/*
 * Kod bölümleme: Büyük ve karmaşık yapılarda class'ları daha okunur ve anlaşılır hale getirmek için.
 * İş Bölümü: ekipler aynı class altında farklı kısımları geliştirmek için kullanılır.
 * Code Genereator: Code Generator tarafından yazılan kodlarınızın ezilmemesi için kullanılır.
 */
#endregion
#region Partial Yapılanmalarda Kısıtlamalar Nelerdir?
/*
 * Parça olan yapılanmaların hepsinin partial keywordu ile işaretlenmesi lazım.
 * İç içe partial türler olabilr.
 * Tüm partial yapılanmalar aynı namespace altında buluması gerkir. Farklı proje veya modüler de bulunamaz.
 * Partial olan bir yapının tüm parçlarının türleri ve isimleri atynı olmak zorundadir.
 */
#endregion
#region Partial olabilen yapılar.
// Class, Interface, Struct, Abstract Class, Record
#endregion

#region Partial Class
//using X;
//var x = new MyClass();
//x.
//namespace X
//{
//    partial class MyClass
//    {
//        partial class MyClass1
//        {

//        }
//        public void A()
//        {

//        }
//    }
//    partial class MyClass
//    {
//        partial class MyClass1
//        {

//        }
//        public void B()
//        {

//        }
//    }
//}
#endregion
#region Partial Record
//partial record x
//{

//}
//partial record x
//{

//}
#endregion
#region Partial Abstract Class
// partial keywordu class interface record struct dan önce gelmelidir.
//abstract partial class MyClass
//{

//}

//abstract partial class MyClass
//{

//}
#endregion
#region Partial Struct
//partial struct c
//{

//}
//partial struct c
//{

//}
#endregion
#region partial Interface
//partial interface IInterface
//{

//}
//partial interface IInterface
//{

//}
#endregion

#region partial metotlar nelerdir.
/*
 * partial metotlar class içerisinde bir imza olarak tanımlanır ve kullanıldığı zaman metodun içi doldurulur.
 * Bir nevi class içerisnde interface gibi bir durum uyguluyoruz.
 * Partial metotlar imza olarak belirlendikten sonra kullanılmayan imzalar compiler bunu yok sayacaktır.
 */
//new MyClass();
//partial class MyClass
//{
//    public MyClass()
//    {
//        P();
//        U();
//        Y();
//    }
//    partial void P();
//    partial void U();
//    partial void Y();

//    partial void Y()
//    {
//        Console.WriteLine("Partial metot Y çalıştı");
//    }
//}
#endregion
#region partial Metot Kuralları
/*
 * Partial metotlarda uygulama yoksa içleri doldurulmamışsa derleme esnasında yok sayılacağından runtime'da olmazlar.
 * Ancak partial yapılanmalar içerisinde tanımlanmalıdrılar.
 * Her daim void olacaklardır.
 * Static veya generic olabilirler.
 * Extern ve virtual olamazlar
 * out parametresş alamazlar lakin ref parametresi alabilirler.
 * Partial metotların gövdeleri tanımlandıysa public olarak işaretlenebilirler.
 */
#endregion