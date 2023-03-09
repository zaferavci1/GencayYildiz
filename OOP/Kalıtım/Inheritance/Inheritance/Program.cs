/*
 * Kalıtım veren class PARENT/BASE
 * Kalıtım alan class DERIVED class denir.
 * Bir sınfın sade ve sadece 1 tane base class ı olabilir. Benim babam base class dedem değil:)
 * Bir classın sadece bir base classı olduğu için bir class sadece ve sadece bir class tan türetilmesine izin verilir.
 * Birden fazla kalıtım almış class lar da kalıtım aldığı yapıların hepsi class değildir. (Interface)
 */

#region * Bir sınıf kalıtım aldığı sınıflar var ise ilk olarak aldığı class ları üretir. Hiyerarşik bir sıra vardır.

//new d();
//class a
//{
//    public a()
//    {
//        Console.WriteLine($"{nameof(a)}");
//    }
//}
//class b : a
//{
//    public b()
//    {
//        Console.WriteLine($"{nameof(b)}");
//    }
//}
//class c : b
//{
//    public c()
//    {
//        Console.WriteLine($"{nameof(c)}");
//    }

//}
//class d : c
//{
//    public d()
//    {
//        Console.WriteLine($"{nameof(d)}");
//    }
//}
#endregion
#region * Bİr sınıfın BASE classının constructor u parametre alıyor ise
class MyClass
{
    public MyClass(int a)
    {
        
    }
    public MyClass(int a ,string b)
    {
        
    }
    public int sayi { get; set; }
}

class MyClass1:MyClass
{
    public MyClass1():base(5)//base bize ana classın ctor'una erişim sağlıyor.
    {
        
    }

    public MyClass1(int a):base(a,"merhaba")// Biz base diyerek ana classın her constructur ına verdiğimiz parametreler ile erişebiliriz   
    { 
        base.sayi = 0; // base keywordu bize base class daki prop  u veya bir metodu da çağırmamızı sağlar. yalnız bunkar erişilebilir olmalıdır.   

    }
}
#endregion