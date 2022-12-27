using System;
using System.Security.Cryptography.X509Certificates;

namespace metotlarda_parametreler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region In Parameters
            // Metoda gönderilen parametrenin değerinin metot içerisinde değişmemesini sağlar.
            //Parametreye verilen değeri sabit tutabilmekteyiz
            //In komutu metodun parametresini readonly(sadece okunabilir) hale getirir.
            #endregion
            #region Local Function
            //Bir metot içersinde tanımlanmiş olan metottur
            //Metotoların tanımlı olduğu yerler: struct, abstract class, interface, record yapılanmalarında metot tanımlanır. 
            //      metotlar bu saydıklarımız dışında başka bir yerde tanmlanamaz

            //Local function özelliği sayesinde metot içerisinde metot tanmımlanabilir.
            //içersindeki metot direk geriye dönüş değeri ile imzası atılır.
            #region Tanımlama Kuralları
            //1. Erişim belirleyici(Access Modifier) yazılmaz.
            //2. Local function olarak tanımlanan fonksiyonun adı tanımlandığı fonksşyonun adından farklı olmalıdır. Aksi taktirde derleyci hata vermez!
            #endregion
            #region Kullanım Kuralları
            //Bir local function sade ve sadece tanımlandığı metodun içerisnde kullanılır.
            //Local function tanımlandığı metodun içerisinde her yerden erişilebilir.
            #endregion
            #region Amacı
            //1. Local functşon sadece tek  bir metotta tekrarlı bir şekilde kullanılacak bir algoritmayı/kod parçaçcığını/işlemi
            //o metotda özel bir şekilde tek seferlik tanımlamamızı ve kullanmmamızı sağlamaktadır.
            #endregion
            #region Muadilleri
            //Anonim, Delegate, Func 
            #endregion
            #endregion
            #region Static Local Function
            #endregion
        }
        #region In Keyword
        //static void X(in int a)
        //{
        //    a = 10;//hata veriyor
        //}
        #endregion
        #region Local
        //public static void X()
        //{
        //    Y();

        //    void Y()
        //    {
        //        Console.WriteLine("merhaba");
        //    }

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Y();
        //    }
        //}
        #endregion
        #region Static Local
        //public void X(int a)
        //{
        //    int b = 0;
            
        //    static void Y(int a,int b)
        //    {
        //        Console.WriteLine(a);
        //        Console.WriteLine(b);
        //    }
        //    Y(a, b);
        //}
        #endregion
        
    }
}
