#region Ref Keywordu
/*
 * Referansın kısaltmasıdır. Referanstan gelmektedir
 * Referans OOP kavramıdır. 
 * OOP'de nesneler RAM'de Heap bölgesinde tutulur. Heap deki verilere direk erişemeyiz.
 * OOP'de referanslar = operatoru ile iletişime geçebilmektedirler. Bir referans işaretlediği herhangi bir nesneyi = operatoru ile farklı bir referans a 
 *      işaretletebilir.
 * Yani referanslarda = operatoru neticesinde herhangi bir verisel/nesnesel türeme söz konusu olmmamakta. İşaretlenmiş nesne diğer referans tarafından
 *      işaretlenmektedir.
 * 
 * Değer türlü değişkenlerde referans çalışması yapmak istiyorsak ref keywordu kullanırız.
 * Ref keywordu değer türlü değişkenlerin referanslarını almamızı sağlar. Referans türlü gibi çalışmamızı sağlar.
 * Değer türlü değişkenlerde Shallow Copy(yzeysel kopyalama) yapmamızı sağlar. Normalde Deep Copy oluyordu. 
*/

#region Ornek 1
//int a = 0;
//ref int b = ref a;// b ye ref yamamızın sebebi bize bir referans değeri gelecek diyoruz.

//Console.WriteLine($"b: {b}");
//Console.WriteLine("a = 10 yaptık ve tekradan b değerini yazdırıyorum");
//a = 10;

//Console.WriteLine($"b: {b}");
#endregion
#region Ornek 2

//int y = 10;
//X(ref y); //değerini gönderiyoruz
//Console.WriteLine($"y: {y}");

//void X(ref int a)
//{
//    a = 21;
//    a += 12;
//}
#endregion
#endregion
#region Ref Returns
/*
 * Ref Returns ozelliği sadece metotolarda geçerlidir.
 * Meototlar geriye değer döndürebilen yapılardır. Ayrıca metotlarda geriye nesnelerde döndürülebilir. Ayrıca Ref Returns özelliği sayesinde
 *      değer türlü değişkenlerin referanslarını da geriye deöndürebilmekteyiz.
 */

#region Ornek 1

using System.Security.Cryptography.X509Certificates;

int a = 5;
int b = X(ref a);
Console.WriteLine(a);
Console.WriteLine(b);

ref int X(ref int a)
{
    a = 25;
    return ref a;
}


#endregion
#endregion