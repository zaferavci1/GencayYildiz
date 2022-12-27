using Microsoft.Extensions.Primitives;
using System;
using System.Text;

namespace dizilerde_verisel_performans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //30 ile 70 aralığı
            //int[] sayilar2 = sayilar[2..^3];//Bu bir fazldan maliyettir.
            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine("sayilar2:"+item);
            //}

            #region ArraySegmentNedir?
            //Bir dizinin bütününden ziyade belirli bir kısmına yahut  parçasına ihtiyaç dahilinde ilgili diziyikopyalamak yerine(
            // ki görece çok maliyetli bir ) bağımsız bir referans ile erişmemizi ve böylece salt bir şekilde temsil etmemizi sağlayan bir yapıdır.
            #endregion
            #region ArraySegment ile Dizinin belirli bir alanını referans etmek
            //ArraySegment<int> segment1 = new ArraySegment<int>(sayilar);
            //segment1 ile artık sayilar dizisini referans ediyorum. Bellekte aynı diziyi gösteriyor.
            //ArraySegment<int> segment2 = new ArraySegment<int>(sayilar,2,5); //2. indexten 5.'i adede
            //foreach (var item in segment2)
            //{
            //    Console.WriteLine(item);
            //}
            //sayilar[3] = 15;
            //segment1[3] *= 10;
            //segment2[3] *= 10;
            //Console.WriteLine(segment2.Array[3]);
            string a = "asdasff";
            ArraySegment<string> stringSegment= new ArraySegment<string>(a);
            
            #endregion
            #region StringSegment Nedir
            //Esasında metinsel değerlerdeki birçok analitik operasyonlardan bizleri kurtarmakta ve Substring vs. gibi fonksiyonlar yerine 
            //string değerde hedef kesit üzerinde işlem yapmamızı sağlayan bir türdür.
            //string text = "Ölüme gidelim dedin de mazot mu yok dedik.";
            //StringSegment segment = new StringSegment(text);
            //StringSegment segment1 = new StringSegment(text,2,5);
            //Console.WriteLine(segment1.Value);
            #endregion
            #region StringBuilder Sınıfı
            //string isim = "zafer", soyisim = "avci";
            //Console.WriteLine(isim + soyisim);
            //StringBuilder string birleştirme operasyonlarında + operatörüne nazaran yüksek maliyeti ortadan kaldırmak için arka planda
            //StringSegment algoritmasını kullanan ve bu algoritma ile bizlere ilgili değerleri olabilecek enn az maliyetle birleştrip döndüren bir sınıftır.

            //StringBuilder builder = new StringBuilder();
            //builder.Append(isim);
            //builder.Append(" ");
            //builder.Append(soyisim);
            //Console.WriteLine(builder.ToString());
            #endregion
            #region Span Türü
            //int[] sayilar = { 140, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            //Span<int> span = new Span<int>(sayilar);
            //Span<int> span2 = sayilar;
            //Span<int> span3 = new Span<int>(sayilar, 3, 4);
            
            //foreach (var item in span3)
            //{
            //    Console.WriteLine(item);
            //}

            //Span<int> span4 = sayilar.AsSpan();
            //Span<int> span5= sayilar.AsSpan(3,4);

            //string text= "Sen kalbimde batan bir günes ben yollarda çilekeş";
            ////metinsel ifadeler üzer,nde span readonlyspan olarak gelecektir
            //ReadOnlySpan<char> readonlySpan = text.AsSpan();
            //ReadOnlySpan<char> readonlySpan1 = text;

            #endregion

        }
    }
}
