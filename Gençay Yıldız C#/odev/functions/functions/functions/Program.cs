using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Metodun geriye değer döndürmesi ne  demektir
            //Console.WriteLine(Topla(5, 6));
            //bool sonuc = PersonelEkle("afer", "avcı", 20);
            //if (sonuc)
            //{

            //}
            //else
            //{

            //}
            #endregion
            #region Optional Parameters(İsteğe Bağlı Parametreler)
            /*
             •	Bir metodun parametrelerine zorunlu bir şekilde parametre göndermek istemiyorsak, 
            parametreye değeri isteğimize göre /opsiyonel olarak göndermek istiyorsak o parametrelerin bu durumu karşılayabilecek 
            bir ozellikte olması gerekiyor. 
            İste bu ozelliğide opsiyonel parametreler denmektedir
            Opsiyonel parametre demek biz değer göndermesek bile o parametreni bir default değeri vardır.
                Derleyici hata verir.
             */
            //X(15, 20);
            //X(15);
            //X();
            #endregion
            #region Başka Sınıflarda Tanımlanmış Metodun Kullanımı
            #region Referans ve Nesne Kavarmına Hafiften Giriş
            //Sınıf(Class) = Yeryzüündeki herhangi bir olguyu modellemeyi sağlar
            //içersinde ilgili olguya dair verileri tutacak alanlar(field) barındıran ve bu alanlar üzerinde işlem yapmamızı sağlayacak olan metotları barındıran yapı.
            //Nesne = calss'tan üretilen veri.
            //Referan = Class'tan üretilen veriyi kullanmaya yarar.
            #endregion

            //Matematik matematik=new Matematik();
            //Console.WriteLine(matematik.Carp(3, 5));

            #endregion
            #region Non-trailing Named Arguements
            //X(3, 5, "abc");
            //X(c: "abc", a: 12, b: 23);//bu özlleiği kullanırsak mümkğn mertebe butun paramteler için bu özelliği kullanın
            //Hangi parametreye hangi değerlerin gönderildiğini direk görebilmek için bu özelliği kulllanırız
            //Görecele bir şekilde çok parametreli fonksiyonlarda hedef parametrelere değer göndermemizi sağlayan bir yapıdır
            #endregion


        }
        #region geriye değer döndüren parametreler

        //static public bool PersonelEkle(string ad, string soyAd, int yas)
        //{
        //    if (yas>=20)
        //    {
        //        //veritabanına eklendi
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Personel 20 den küçük olamaz");
        //        return false;
        //    }
        //}

        //static public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        #endregion
        #region Optional 
        //static public void X(int a = 5, int b = 0)//b'nin default değeri oluştu ve istediğimiz gibi değer gönderebileceğiz
        //{

        //}
        #endregion
        #region Non-trailing
        //static void X(int a, int b, string c)
        //{

        //}
        #endregion
    }
    #region Class Oluşumu
    //class Matematik
    //{
    //    public int Topla(int sayi1, int sayi2)
    //    {

    //        return sayi1 + sayi2;
    //    }

    //    public int Cikar(int sayi1, int sayi2)
    //    {
    //        return sayi2 - sayi1;
    //    }
    //    public int Carp(int sayi1, int sayi2)
    //    {

    //        return sayi1 * sayi2;
    //    }

    //    public int Bol(int sayi1, int sayi2)
    //    {
    //        return sayi2 / sayi1;
    //    }
    //}
    #endregion
}
