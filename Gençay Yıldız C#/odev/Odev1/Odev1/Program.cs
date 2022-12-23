using System;

namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Odev1
            //Console.WriteLine("1. urunun fiyatini giriniz: ");
            //int urun1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(urun1);

            //Console.WriteLine("2. urunun fiyatini giriniz: ");
            //int urun2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(urun2);

            //if ((urun1 + urun2) > 200)
            //{
            //    urun2 -= urun2 / 4;
            //    Console.WriteLine("Indirimli odenecek tutar: " + (urun2 + urun1));
            //}
            //else
            //{
            //    Console.WriteLine("Toplam tutar : " + (urun1 + urun2));
            //}
            #endregion
            #region Odev2
            //string kullaniciAdi, sifre, kullanici, sifr;
            //kullanici = "zafer";
            //sifr = "123";
            //Console.WriteLine("Kullanici adi giriniz: ");
            //kullaniciAdi = Console.ReadLine();

            //Console.WriteLine("Sifre giriniz: ");
            //sifre = Console.ReadLine();

            //string mesaj = (kullaniciAdi == kullanici && sifre == sifr) ? "Basarili giris yapıldı" : "Kullanici adi veya sife haatli";

            //Console.WriteLine(mesaj);
            #endregion
            #region Odev3
            //int sayi1, sayi2;
            //Console.WriteLine("SAyi1 'i giriniz: ");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sayi 2' yi giriniz: ");
            //sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Yapilacak islemi giriniz: ");
            //char islem = char.Parse(Console.ReadLine());

            //if (islem == '+')
            //{
            //    Console.WriteLine("Toplam : " + (sayi1 + sayi2));
            //}
            //else if (islem == '-')
            //{
            //    Console.WriteLine("Cikarma : " + (sayi1 - sayi2));
            //}
            //else if (islem == '*')
            //{
            //    Console.WriteLine("Carpma: " + (sayi1 * sayi2));
            //}
            //else
            //{
            //    Console.WriteLine("Bolme: " + (sayi1 / sayi2));
            //}

            //switch (islem)
            //{
            //    case '+':
            //        Console.WriteLine("Toplam : " + (sayi1 + sayi2));
            //        break;

            //    case '-':
            //        Console.WriteLine("Cikarma: " + (sayi2 - sayi1));
            //        break;
            //}

            //int sonuc = islem switch
            //{
            //    '+' => sayi1 + sayi2,
            //    '-' => sayi2 - sayi1,
            //    '*' => sayi1 * sayi2,
            //    _ => sayi2 / sayi1
            //};

            #endregion

           // pattern matching
            //int a = 5;
            //bool x = a is var o;//o'nun değerini runtime da 5 atadi
            //Console.WriteLine("o: " + o + "\n x: " + x);
            #region Try-Catch
            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());
            //}
            //catch (Exception hata)
            //{
            //    Console.WriteLine(hata.Message+"Duzgun sayi gir");

            //}
            #endregion
            #region ForLoop
            //for (int i = 0;  i < 10;  i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region While

            //while (true)
            //{
            //    if (DateTime.Now.Second % 5 == 0)
            //    {
            //        Console.WriteLine(DateTime.Now.Second);
            //    }
            //}
            #endregion
            #region cast
            //int  x = 1;
            //short y = (short)x;
            #endregion
        }
    }
}
