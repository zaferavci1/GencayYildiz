using System;

namespace StringFonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Fonksiyonları
            string metin = "lAylaYloM GaliBa sAna gÖre sEvmELer...";
            #endregion
            #region contains
            //Console.WriteLine(metin.Contains("sana")); //bool dönecek
            #endregion
            #region StartsWith
            //Console.WriteLine(metin.StartsWith("l"));//true dönecek
            //Console.WriteLine(metin.StartsWith("L"));//false dönecek
            #endregion
            #region EndsWith
            //Console.WriteLine(metin.EndsWith("..."));
            #endregion
            #region Compare
            //metinleri birbiri ile karşılştırır. Sonuç olarak integer türde sonuç veren fonksiyon. 0 , 1 veya -1 döner
            //0 : ise her iki değer birbirine eşittir 
            //1 : soldaki sağdakinden alfanumerik olarak büyük
            //-1: sağdaki soldakinden alfanumerik olarak küçük
            //Console.WriteLine(string.Compare(metin, "z"));

            #endregion
            #region CompareTo
            //compare ile aynı amaç
            //Console.WriteLine(metin.CompareTo("z"));//-1
            //Console.WriteLine(metin.CompareTo("a"));//1
            //Console.WriteLine(metin.CompareTo(metin));//0
            #endregion
            #region IndexOf
            //verilen değerin string ifade içerisinde olup olmadığını geriye integer dödnüren fonsiyondur. Geriye int olarak index nosunu döndürür.
            //kelimenin ilk harfinin index numarsını dönderir.
            //eşleştirme söz konusu değilse -1 döner
            //Console.WriteLine(metin.IndexOf("la"));
            //Console.WriteLine(metin.IndexOf("a"));
            //Console.WriteLine(metin.IndexOf("y"));
            //ilk eşleşen değerin indexini döndürür
            #endregion
            #region Insert
            ////elinizdeki string degere veri eklememizi sağlar
            //string metin2=metin.Insert(metin.Length, "hopaşinanay");//string olarak geriye dönecek metinin orjinali elimizde duracak. 
            ////zaten bu bir metot özelliğindendir.
            //Console.WriteLine(metin2);
            #endregion
            #region Remove
            //metinden kırpma yapar.
            //Insert de oldugu gibi geriye string döner
            //elimizdeki orjinal veri değişmez
            //Console.WriteLine(metin.Remove(5));
            //Console.WriteLine(metin.Remove(5, 3));
            #endregion
            #region Replace
            //Elimizdeki metinsel ifadede belitilen değerleri yahut belirtilen diğer değerler ya da karekterler ile değiştirmemizi sağlar.
            //sonuç olarak string değer döner orjinal metin değişmez
            //Console.WriteLine(metin.Replace('a', 'b'));
            //Console.WriteLine(metin.Replace("la","lo"));
            #endregion
            #region Split En Önemlilerden Biri
            // Elmizdeki metinsel ifadeyi verilen değeri ayraç olarak kullanıp parçalayan ve sonucu string dizisi olarak donduren fonksiyondur.
            //verdiğimiz char ı metinden kesiyor 
            //string[] diziSplit = metin.Split(' ');
            //foreach (var item in diziSplit)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine("*/////////");
            //string[] diziSplitA = metin.Split('a');
            //foreach (var item in diziSplitA)
            //{
            //    Console.Write(item);
            //}
            #endregion
            #region Substring Çok Çok Önemli
            //metinsel ifadenin belli bir aralığını elde edip çalışmamızı sağlar
            //Console.WriteLine(metin.Substring(5));
            //Console.WriteLine(metin.Substring(5,10));
            #endregion
            #region ToLower
            //Console.WriteLine(metin.ToLower());
            #endregion
            #region ToUpper
            //Console.WriteLine(metin.ToUpper());
            #endregion
            #region Trim
            //METİNSEL İFADELERİN VARSA SOLUNDAKİ VE SAĞİNDAKİ BOŞLUK KARAKTERLERİNİ TEMİZLEYEN FONKSİYONDUR
            //Console.WriteLine("       ahmet".Trim());
            //Console.WriteLine("ahmet
            #endregion
            #region TrimEnd
            //sağdaki boşluğu siler sadece
            #endregion
            #region TrimStart
            //soldaki boşluğu silecek sadece
            #endregion

            //string isimSoyisim = "zafer".Insert(5,"avci") ;
            //Index i = 0, i2 = isimSoyisim.Length, i3 = ^3;
            //Console.WriteLine(isimSoyisim[i3]);
            //Console.WriteLine(isimSoyisim[0..^4]);

            //int a = 0;
            //string massage = Console.ReadLine();
            //for (int i = 0; i < massage.Length; i++)
            //{
            //    if (massage[i] == 'n')
            //        a++;
            //}
            //Console.WriteLine($"Toplam n karakteri: {a}");
            //Console.WriteLine(massage.Length);
            //string[] newMassage = massage.Split('n');
            //int sonuc = massage.Length-(massage.Length - newMassage.Length)-1;
            //Console.WriteLine(newMassage.Length + massage.Length);
            //Console.WriteLine($"Toplam n harfi: {sonuc}");


            #region KElime sayısı
            //string mesaj = Console.ReadLine();
            //int adet = 1;
            //while (true)
            //{
            //    int index = mesaj.IndexOf(' ');
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    adet++;
            //    mesaj = mesaj.Substring(index + 1);
            //}
            //Console.WriteLine(adet);
            #endregion

        }
    }
}
