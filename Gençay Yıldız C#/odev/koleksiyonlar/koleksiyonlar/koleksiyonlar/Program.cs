using System;
using System.Collections;

namespace koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList

            #region ArrayList Koleksiyon Tanımlama
            //Diziler tanımlanırken kaç eleman tutacağı bildirilmek zorundadır.
            int[] yaslar = new int[17];


            ArrayList _yaslar = new ArrayList();

            #endregion
            #region Tanımlanmış Koleksiyona Değer Atama


            for (int i = 0; i < yaslar.Length; i++)
            {
                yaslar[i] = i + 10;

                _yaslar.Add(i + 10);
            }
            #endregion
            #region Koleksiyonlardan Değer okuma
            //Diziler
            Console.WriteLine(yaslar[5]);

            //Koleksiyonlar
            Console.WriteLine(_yaslar[5]);

            #endregion
            #region ArrayList Kullanırken Boxing - Unboxing Durumları
            //ArrayList verilen datayı Boxing işlemine tabi tutar. 
            //ArrayList içersiindeki herhangi bir veriyi talep ettiğimizde o veriyi object olarak gelecektir.
            //Dolayısıyla kendi türünde işlem yapabilmek için unboxing işlemine tabi tumamız gerekir

            int toplam = 0;
            for (int i = 0; i < _yaslar.Count; i++)
            {
                if (_yaslar[i] is int)
                {
                    toplam += (int)_yaslar[i];
                }
            }
            #endregion
            #region ArryaList Collection Initializers(Koleksiyon İlklendirici) İle Değer Ekleme


            ArrayList arrayList = new ArrayList() { 10, 60, "ahmet " };


            #endregion


            #endregion
        }
    }
}
