// Bir sınıftan nesne üretilir iken ilk tetiklenen fonskşyon static constructor dur.
//  AMMA VELAKİN BELİLRLİ BİR DURUMA İSTİNADEN

/*
 * Constructor bir sınıftan her nesne üretildiğinde çalışan metottur. 
 * AMA static constructor bir sınıftan İLKkkkk NESNE üretildiğinde çalışan metottur
*/

using System.ComponentModel.DataAnnotations.Schema;

MyClass m1 = new MyClass();
MyClass m2 = new MyClass();

var database1 = Datebase.GetInstance;
var database3 = Datebase.GetInstance;
var database2 = Datebase.GetInstance;

database1.connectionString = "zafer";

Console.WriteLine();

class MyClass
{
    public MyClass()
    {
        //Bu sınıftan nesne üretilirken ilk tetiklenecek metottur.
        Console.WriteLine("MyClass constructoru tetiklendi");
    }
    static MyClass()
    {
        //Static constructor da erişim belirleyicisi yoktur.
        //Overloading yapılmaz. 
        //Yani parametre almaz.
        //İsmi sınıf ismi ile aynı olacaktır.


        // Bu sınıftan ilk nesne üretilirkne tetiklenecek ilk metottur.
        // üretilen ilk nesnenin dışında bir da tetiklenmez!
        Console.WriteLine("MyClass static constructoru tetiklendi");

        // Static constructorun tetiklenmesi için illa ilk nesnenin üretilmesine gerek yoktur. 
        //      İlgili sınıfın içersinde herhangi bir static yapılanmanın tetiklenmesi static const. tetiklenmesine sebep olacaktır.
        // bir sınıfta tetiklenme hakkı 1 seferdir.  
    }
}
#region Singleton Design Pattern
// Bir sınıftan uygulama bazında sade ve sadece 1 nesne oluşturulmasını isteniyorsa kullanabileceğin bir design patterndır.

class Datebase
{
    Datebase()
    {

    }
    public string connectionString { get; set; }
    static Datebase datebase;
    static public Datebase GetInstance
    {
        get
        {
            return datebase;
        }
    }

    static Datebase()
    {
        datebase = new Datebase();
    }
}
#endregion