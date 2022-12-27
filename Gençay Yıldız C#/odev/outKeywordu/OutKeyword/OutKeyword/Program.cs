#region Out Keyword
/*
 * Out keywordu metotların PARAMETRELERİ üzerinden dışarıya değer göndermemizi sağlayan keyworddur.
 * Bir metodun parametreleri INPUT'tur. 
 * Eğer ki bir metodun parametresş dışarıya değer göndercekse o parametrenin out keywordu ile işaretlenmesi
 *      gerekiyor
 */

//Output parametreleri barındıran bir metot çağırken, o metedun output parametrelerinden gelecek değerleri
//      karşılayacak değişkenşer belirlenmelidir.
#region Kullanım 1
//int _b = 0;
//string _d = "";

//int a = X(out _b, 123, out _d);
#endregion
#region Kullanım 2
//int a = X(out int _b, 123, out string _d);
//Console.WriteLine(_d);
//Console.WriteLine(_b);
//Console.WriteLine(a);
//int X(out int b, int c, out string d)
//{
//    //output parametreler varsa o parametrelere kendi içerisinde değer atanmalıdır.
//    b = 0;
//    d = "gençay";
//    return 0;
//}
#endregion

#region Tryparse

string a = "12a3";
if (int.TryParse(a, out int _b))
{
    Console.WriteLine("Dönüitü: "+ _b);
}
else
{
    Console.WriteLine("dönüşemedi");
}

#endregion
#endregion