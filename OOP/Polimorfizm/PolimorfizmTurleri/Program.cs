#region Statik Polimorfizm
/*
 * Static keywordu ileride öğreneceğiz
 * Hangi fonksiyonun derleme zamanında çağrılacağına karar verildiği polimorfizm türüdğr.
 * Metot overloading bir polimorfizmken bu metotların hangisini derleme zamanında kullanılacağına karar vermek 
 *          static polimorfizmdir.
 */

//using System.Security.Cryptography;

//Matematik m = new();
//m.topla(4, 6);//derleme zmaanında biliniyor.
//class Matematik
//{
//    public long topla(int s1, int s2)
//        => s1 + s2;
//    public long topla(int s1, int s2, int s3)
//        => s1 + s2 + s3;
//    public long topla(int s1, int s2, int s3, int s4)
//        => s1 + s2 + s3 + s4;
//}
#endregion
#region Dinamik Poimorfizm
/*
 * Hangi fonksiyonun çalışacağına run time'da kara verilir.
 * C#'da dinamik polimorfizm denince akla Metot Override akla gelir.
 * Metot Override base classdaki Virtual metotların derleme zamanında duruma göre türetilmiş classda override edilmesi
 *          örenktir.
 * 
*/

//using System.Threading.Channels;

//Arac a = new();
//a.Basla();

//class Arac
//{
//    virtual public void Basla ()
//        => Console.WriteLine("araç çalıştı");//Bu metot ezilebir ama ezilmeyebilir de. Runtime'da kara verilecek
//}
//class Taksi:Arac
//{
//    public override void Basla()
//    {
//        Console.WriteLine("Taksi çalıştı");
//    }
//}
#endregion