using System;

namespace hazir_kutuphaneler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Math Sınıfı
            #region Abs
            //Mutlak değer işlemi yapar
            //Console.WriteLine(Math.Abs(-12));
            #endregion
            #region Ceiling
            //3.14 -> 4 YUKARI YUVARLAR
            //Console.WriteLine(Math.Ceiling(3.14));
            //Double verirsek double decimal verirsek decimal
            #endregion
            #region Floor
            //3.14 -> 3 AŞAĞI YUVARLAR
            //Console.WriteLine(Math.Floor(3.14));
            //Double verirsek double decimal verirsek decimal
            #endregion
            #region Round
            //Ondalıklı değeri en yakın olan tamsayıya yuvarlar
            //Console.WriteLine(Math.Round(3.14));
            #endregion
            #region Pow
            //üs alır, double doner
            //Console.WriteLine(Math.Pow(3,6));
            #endregion
            #region Sqrt
            //Kök alır, 2. derceden
            //Console.WriteLine(Math.Sqrt(16));
            #endregion
            #region Truncate
            //double sayılarda virgülden sonrayı atıyor 
            //Console.WriteLine(Math.Truncate(3.14));
            #endregion
            #endregion
            #region DateTime Struct'ı
            #region Now
            //Console.WriteLine(DateTime.Now);
            #endregion
            #region Today
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);
            #endregion
            #region Compare

            //DateTime tarih1 = new DateTime(2021, 01, 01);
            //DateTime tarih2 = new DateTime(2022, 01, 01);
            //int result = DateTime.Compare(tarih1, tarih2);//-1 0 ve 1 deöner

            //if (result > 0)
            //{
            //    Console.WriteLine($"{tarih1} büyüktür {tarih2}");
            //}
            //else if (result == 0)
            //{
            //    Console.WriteLine($"{tarih1} eşittir {tarih2}");
            //}
            //else
            //{
            //    Console.WriteLine($"{tarih1} küçüktür {tarih2}");
            //}
            #endregion
            #region AddDays
            DateTime tarih = new DateTime(2021,01,01,00,00,00);
            Console.WriteLine(tarih.AddDays(999));
            Console.WriteLine(tarih.AddSeconds(10));
            #endregion
            #region AddHours

            #endregion
            #region AddMonths

            #endregion
            #region AddYears

            #endregion
            #region AddMiliseconds

            #endregion
            #endregion
            #region TimeSpan Struct'ı
            //DateTime tari1 = DateTime.Now;
            //DateTime tari2 = new DateTime(2000,01,01);
            //TimeSpan span = tari1 - tari2;//Time span olarak dönüyor
            //Console.WriteLine(span.Days);
            #endregion
            #region Random Sınıfı
            //rastgele sayısal değer
            Random random = new Random();
            #region Next Fonksiyonu
            //random.Next();//0 -- int değer aralığında sayı üretecek
            //Console.WriteLine(random.Next());
            //Console.WriteLine(random.Next(100));//0--100 100 dahil değil
            //Console.WriteLine(random.Next(50,100));//50 -- 100 !100
            #endregion
            #region NextDouble Fonksiyonu
            Console.WriteLine(random.NextDouble());//0 -- 1 arasında
            while (true)
            {
                Console.WriteLine(random.NextDouble());
            }
            #endregion
            #endregion
        }
    }
}
