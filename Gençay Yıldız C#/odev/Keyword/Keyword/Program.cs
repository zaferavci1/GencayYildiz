using System;

namespace Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            #region KonseptliKeyword
            //Console.WriteLine("Hello World!");

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("for kelimesi kendi başına bir anlam ifade etmez");
            //}
            //int a = 0;
            //while (a < 1)
            //{
            //    Console.WriteLine("while kelimesi kendi başına bir anlam ifade etmez");
            //    a++;
            //}
            #endregion
            #region Yardımcı Manevratik Komutlar
            //1 break 
            //switch (10)
            //{
            //    case 5:


            //        break;
            //    case 6:


            //        break;
            //    case 7:

            //        break;
            //}

            //2 return
            //3 continue
            //goto
            #endregion
            #region break örnek1
            //char a;
            //int i = 0;
            //while (true)
            //{
            //    a = Convert.ToChar(Console.ReadLine());
            //    if (a == 't')
            //    {
            //        break;
            //    }
            //    i += i = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine(i);
            #endregion
            #region örnek2
            //int a = 0;
            //for(int i = 0; i < 5; i--)
            //{
            //    a=int.Parse(Console.ReadLine());
            //    if (a % 37 == 0)
            //    {
            //        break;
            //    }
            //}
            #endregion
            #region Continue
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 != 0)
            //        continue;

            //    Console.WriteLine(i);
            //}
            #endregion
            #region Continue ornek1
            //int carpim = 1;
            //while (true)
            //{
            //    string a = Console.ReadLine();
            //    if (a == "t")
            //    {
            //        Console.WriteLine(carpim);
            //        break;
            //    }
            //    else
            //    {
            //        int sayi = int.Parse(a);
            //        if (sayi < 0)
            //            continue;
            //        carpim *= sayi;
            //    }
            //}
            #endregion
            #region Range
            //int[] sayilar = { 1, 2, 35, 8, 9, 7, 56, 3, 12, 12 };

            //Range range = 2..7;
            //var sayilar2 = sayilar[range];
            //foreach(var item in sayilar2) {
            //    Console.WriteLine(item);  
            //}
            //Range range = ..; //Tüm diziyi kopyalayacak
            //var sayilar2 = sayilar[range];
            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}

            //Range range = 5..^3;
            //var sayilar2 = sayilar[range];
            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Dizi içerisinde dizi tanımlama
            //int[][] sayilar = new int[3][];
            //sayilar[0] = new int[3] {2,4,5 };
            //sayilar[1] = new int[5] { 45, 65, 76, 873, 67 };
            //sayilar[2] = new int[4] { 23, 12, 453, 6 };

            //Console.WriteLine(sayilar[0][2]);
            //sayilar[0][2] = 13;
            //Console.WriteLine(sayilar[0][2]);
            //Console.WriteLine(sayilar[0].Length + sayilar[1].Length + sayilar[2].Length+" ----------" );

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    for (int j = 0; j < sayilar[i].Length; j++)
            //    {
            //        Console.Write(sayilar[i][j]+"       ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

        }
    }
}
