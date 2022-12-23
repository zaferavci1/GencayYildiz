using System;
using System.Collections;

namespace foreach_iterasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Iterasyon vs Döngü

            //foreach(İterasyon)   BİR DÖNG DEĞİLDİR!!!!
            //
            ArrayList arrayList = new ArrayList() { 1, 2, 3, 5, 6, 4, 8, 7, 9, 10};

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
