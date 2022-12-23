using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string
            //string ; referans türlü olduğu halde proglamlama dilinde bir keyword barındıran tek değerdir.
            //değeri heapte tutulur
            #endregion
            #region Null - Empty Durumları, Farkları
            /* NULL: bir değişken/nullable/referans eğer ki null alıyorsa  bu durum değişkenin herhangi bir alan tahsis 
             *      etmeiği anlamına gelir. ARSA YOK!
             *      değer türlü deişkenler null alamaz
             *      Null alabilen türler sadece referans türlerdirler.
             *      Değer türlü değişkenlerin null alabilmesi için nullable(?) olması gerekir.
             *      NULL bellekte yer kaplamaz
             *      Null olan bir değer üzerinde işlem yapmaya çalıştığımızda runtime hata verir.
             *      Lakin empty üzerinde bir işlem yapmak sıkıntı yaratmayacaktır.
             */

            //int? a = null;
            //string b = null;

            /*
             * 
             * EMPTY: Bir değişken/nullable/referans eğer ki empty ise bu değişkenin değeri yok anlamına gelir. 
             *      lakin alan tahsisinde bulunulmuştur. ARSA VAR LAKİN EV YOK!
             *      Tüm değerler empty alabilir.
             *      Alan tahsisinde bulunulup ardından ilgili alana bir değer koymamak empty durumudur.
             *      Default değerlerin olduğu durumlar empty olarak geçer
             *      Empty bellekte yer kaplar
             */
            //int c = 0;
            //bool d = false;
            //int[] e = new int[55];

            //empty dediğimizde aklımıza string'e "" değerinin verilemsi gelsin yeter.
            //string f = null; //Alan tahsisinde bulunmaz
            //string g = ""; //Alan tahsisinde bulunur
            //string b = string.Empty = string b = ""
            #endregion
            #region ISNullEmpty
            //string x = "";
            //if (x!= string.Empty && x is not null)
            //{

            //}

            //ISNUllOrEmpty fonskiyonu elimizdeki string ifadenin null yahut empty olup olmadığını kontrol eder ve 
            //geriye bool değer döner
            //if (string.IsNullOrEmpty(x))
            //{
            //    //eğerki değer null yada empty ise geriye true dönecek
            //}
            #endregion
            #region IsNullOrWhiteSpace
            //IsNUllOrWhiteSpace fonskiyonu elimizdeki string veriyi null,empty ve boşluk karakterlerinden 
            //    olma durumularında geriye bool değer döner
            //string x = "      ";
            //if (string.IsNullOrWhiteSpace(x))
            //{
            //true dondu
            //    Console.WriteLine("white space");
            //}
            #endregion
            #region string.format
            /*
             * 
             * 
             */
            //string isim = "zafer", soyisim = "avci", tcNo = "2138792345";
            //int yas = 21;
            //bool medeniHal = false;
            //string a=string.Format("TC No: {0} olan {1} {2} şahsın bilgileri Yas: {3} Medeni Hal: {4}", tcNo, isim, soyisim, yas, (medeniHal ? "evli" : "bekar"));
            //Console.WriteLine(a);
            #endregion
            #region string interpolation
            //string isim = "zafer", soyisim = "avci", tcNo = "2138792345";
            //int yas = 21;
            //bool medeniHal = false;
            //Console.WriteLine($"TC No: {tcNo} olan {isim} {soyisim} şahsın bilgileri Yas: {yas} Medeni Hal: {(medeniHal ? "evli":"bekar")}{{merhaba süslü parantez ile birlikte ekrana çıktı verecek}}");
            #endregion
            #region String kaçış operatoru
            //Console.WriteLine("merhab ben burad slaş kullanmak istiyoum \\ ilk kullanımda bize hata veriyor " +
            //    "çünkü bizden bazı \n tarzı kısa yollar var bundan dolayı kendini ezerek bu karakteri kullanabiliyoruz");
            #endregion
            #region Verbatim operatoru
            /*
             * biz bazı keyword isimlerini metot veya değişken ismi olarak kullanmak isterken hata oluşmaması için bize lazım olan operator 
             * verbatim (@) 
             */
            int @void = 2;
            string @class = "empty";
            #endregion
        }
    }
}
