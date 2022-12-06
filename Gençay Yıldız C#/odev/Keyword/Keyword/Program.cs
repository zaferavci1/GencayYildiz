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
            int carpim = 1;
            while (true)
            {
                string a= Console.ReadLine();
                if (a == "t")
                {
                    Console.WriteLine(carpim);
                    break;
                }
                else
                { 
                    int sayi = int.Parse(a);
                    if (sayi < 0)
                        continue;
                    carpim *= sayi;
                }
            }
            #endregion
        }
    }
}
